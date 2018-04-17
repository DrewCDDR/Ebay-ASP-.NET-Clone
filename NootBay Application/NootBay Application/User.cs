using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NootBay_Application
{
    public class User
    {
        private Boolean person;
        private int id_user, rating_buyer, rating_seller, phone;
        private String nick, password, bio_user, name_user, email, picture;
        private DateTime date_creation, date_last;

        public User()
        {

        }

        public void setValues(String nick, String password, String name_user, String email, Boolean b)
        {
            this.rating_buyer = 0;
            this.rating_seller = 0;
            this.phone = 0;
            this.bio_user = "Insert bio.";
            this.picture = "";
            this.date_creation = DateTime.Now;
            this.date_last = DateTime.Now;
            this.nick = nick;
            this.password = password;
            this.name_user = name_user;
            this.email = email;
            this.person = b;
        }

        public Boolean getPerson()
        {
            return this.person;
        }

        public int getID()
        {
            return this.id_user;
        }

        public int getBuyerRating()
        {
            return this.rating_buyer;
        }

        public int getSellerRating()
        {
            return this.rating_seller;
        }

        public int getPhone()
        {
            return this.phone;
        }

        public String getNickname()
        {
            return this.nick;
        }

        public String getPassword()
        {
            return this.password;
        }

        public String getBio()
        {
            return this.bio_user;
        }

        public String getName()
        {
            return this.name_user;
        }

        public String getEmail()
        {
            return this.email;
        }

        public String getPicture()
        {
            return this.picture;
        }

        public DateTime getCreationDate()
        {
            return this.date_creation;
        }

        public DateTime getLastDate()
        {
            return this.date_last;
        }
    }
}