<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="NootBay_Application.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Noot Bay</title>
    <link href="Styles/Home.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="Home" runat="server">
        <div class = "main">
            <div class = "container">
                <h1 class = "title">Noot Noot</h1>
            </div>

            <div class = "nav container">
                <asp:Button CssClass = "btn" ID = "profile" runat="server"  Text = "Login" Visible = "false"/>
                <asp:Button CssClass = "btn" ID = "login" runat="server" OnClick="LoginClicked" Text = "Login" />
                <asp:Button CssClass = "btn" ID = "register" runat = "server" OnClick = "RegisterClicked" Text = "Register"/>
            </div>

            <asp:Panel CssClass = "panel" ID = "loginFrame" runat="server" Visible = "false">
                <asp:Label CssClass = "lbl" ID = "userLbl" runat ="server" Text ="Nickname: "/>
                <asp:TextBox CssClass ="textBox" ID = "userNicknameTextBox" runat ="server" placeholder ="Nickname..." />
                <asp:Label CssClass = "lbl" ID = "passLbl" runat ="server" Text ="Password: "/>
                <asp:TextBox CssClass ="textBox" ID = "passTextBox" runat ="server" placeholder ="Password..." />
                <asp:Button CssClass = "btn" ID = "connect" runat="server" OnClick="ConnectClicked" Text = "Connect" />
            </asp:Panel>

            <asp:Panel CssClass ="register panel" ID ="registrationFrame" runat="server" Visible="false">
                <div class = "container">
                    <asp:Label CssClass = "registration lbl" ID = "nameLabel" runat ="server" Text ="Name: "/>
                    <asp:TextBox CssClass ="textBox" ID = "nameTxt" runat ="server" placeholder ="Name..." />
                </div>
                <div class ="container">
                    <asp:Label CssClass = "registration lbl" ID = "nickLabel" runat ="server" Text ="Nickname: "/>
                    <asp:TextBox CssClass ="textBox" ID = "nickTxt" runat ="server" placeholder ="Nickname..." />
                </div>
                <div class ="container">
                    <asp:Label CssClass = "registration lbl" ID = "emailLabel" runat ="server" Text ="Email: "/>
                    <asp:TextBox CssClass ="textBox" ID = "emailTxt" runat ="server" placeholder ="Email..." />
                </div>
                <div class ="container">
                    <asp:Label CssClass = "registration lbl" ID = "type" runat ="server" Text ="Account type: "/>
                    <select id ="accountType" name ="accountType" size="1">
                      <option>Select your account type...</option>
                      <option>Personal</option>
                      <option>Business</option>      
                    </select>
                </div>
                <div class ="container">
                    <asp:Label CssClass = "registration lbl" ID = "passLabel" runat ="server" Text ="Password: "/>
                    <asp:TextBox CssClass ="textBox" ID = "passTxt" runat ="server" placeholder ="Password..." TextMode ="Password"/>
                </div>
                <asp:Label CssClass = "e registration lbl" ID = "rError" runat ="server" Text ="" Visible ="false"/>
                <asp:Button CssClass = "r btn" ID = "registrate" runat="server" OnClick="RegistrateClicked" Text = "Complete Registration" />
            </asp:Panel>

            <asp:Panel CssClass ="panel" ID ="registrationMsg" runat ="server" Visible ="false">
                <asp:Label CssClass = "lbl" ID = "registrationMsgSuccess" runat ="server" Text =""/>
                <asp:Button CssClass = "btn" ID = "registrationMsgClose" runat="server" OnClick ="RegistrationClose" Text = "Close"/>
            </asp:Panel>
        </div>
    </form>
</body>
</html>
