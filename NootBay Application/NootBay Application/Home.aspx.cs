using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;

namespace NootBay_Application
{
    public partial class Home : System.Web.UI.Page
    {
        private User user;
        private MySqlConnection db_con;
        private MySqlCommand db_comm;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RegisterClicked(object sender, EventArgs e)
        {
            if (this.loginFrame.Visible == false)
            {
                this.registrationFrame.Visible = true;
            }
        }

        protected void RegistrateClicked(object sender, EventArgs e)
        {
            Boolean userCreated = false;
            NootBay_Application.User newUser = new NootBay_Application.User();
            // VERIFICAR QUE LOS CAMPOS NO ESTEN VACIOS.
            if (!(string.IsNullOrEmpty(this.nameTxt.Text)) && !(string.IsNullOrEmpty(this.nameTxt.Text)) &&
                !(string.IsNullOrEmpty(this.nameTxt.Text)) && !(string.IsNullOrEmpty(this.nameTxt.Text)))
            {
                // VERIFICAR QUE EL SELECT NO ESTE EN DEFAULT.
                if (Request.Form["accountType"].Equals("Select your account type..."))
                {
                    this.rError.Text = "Seleccione el tipo de cuenta, ya sea personal o empresarial.";
                    this.rError.Visible = true;
                }
                else
                {
                    this.rError.Text = "";
                    this.rError.Visible = false;

                    // CREAR EL USUARIO SEGUN TIPO DE CUENTA.
                    if (Request.Form["accountType"].Equals("Personal"))
                    {
                        newUser.setValues(this.nickTxt.Text, this.passTxt.Text,
                            this.nameTxt.Text, this.emailTxt.Text, true);
                    }
                    else if(Request.Form["accountType"].Equals("Business"))
                    {
                        newUser.setValues(this.nickTxt.Text, this.passTxt.Text,
                            this.nameTxt.Text, this.emailTxt.Text, false);
                    }

                    db_con = new MySqlConnection("Database=nootbay;" +
                                                 "Data Source=127.0.0.1;" +
                                                 "User Id=root;" +
                                                 "Password=123456");
                    try
                    {
                        db_con.Open();
                        db_comm = db_con.CreateCommand();
                        db_comm.CommandText = "insert into users(nick, pass, bio_user, rating_buyer, rating_seller, " +
                                                                " person, name_user, email, phone, picture, date_creation, date_last)" +
                                                                " values ('" +newUser.getNickname() 
                                                                          +"', '" +newUser.getPassword() 
                                                                          +"', '" +newUser.getBio()
                                                                          +"', '" +newUser.getBuyerRating()
                                                                          +"', '" +newUser.getSellerRating()
                                                                          +"', '" +(newUser.getPerson()? 1: 0)
                                                                          +"', '" +newUser.getName()
                                                                          +"', '" +newUser.getEmail()
                                                                          +"', '" +newUser.getPhone()
                                                                          +"', '" +newUser.getPicture()
                                                                          +"', '"+newUser.getCreationDate().ToString("yyyy-MM-dd")
                                                                          +")', '" +newUser.getLastDate().ToString("yyyy-MM-dd") +"');";

                        int rowsAffected = db_comm.ExecuteNonQuery();

                        if(rowsAffected == 1)
                        {
                            userCreated = true;
                        }
                    }
                    catch (System.Data.SqlClient.SqlException ex)
                    {
                        String msg = "Insert Error";
                        msg += ex.Message;
                        throw new Exception(msg);
                    }
                    finally
                    {
                        db_con.Close();
                    }
                }
            }
            else
            {
                this.rError.Text = "Campos incompletos...";
                this.rError.Visible = true;
            }

            if (userCreated)
            {
                user = newUser;
                this.registrationMsgSuccess.Text = "The user " + user.getNickname() + " has been created!";
                this.registrationFrame.Visible = false;
                this.registrationMsg.Visible = true;
                this.profile.Visible = true;
                this.login.Visible = false;
                this.register.Visible = false;
            }
        }

        protected void RegistrationClose(object sender, EventArgs e)
        {
            this.registrationMsgSuccess.Text = "";
            this.registrationMsg.Visible = false;
        }

        protected void LoginClicked(object sender, EventArgs e)
        {
            if (this.registrationFrame.Visible == false)
            {
                this.loginFrame.Visible = true;
            }
        }

        protected void ConnectClicked(object sender, EventArgs e)
        {
            this.loginFrame.Visible = false;
        }
    }
}