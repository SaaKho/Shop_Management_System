<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebDB.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
      <link href="~/Style/St.css" rel="stylesheet" type="text/css" />

</head>
<body>
    <form id="form1" runat="server">
   <div class="overlay"></div> 
              <img src="pics/netflix-3.png" alt="" height="657vh" width="1366vh"/>
               
              <div class="form1">
                <h2>Login Here</h2>

                <%--<input type="email" name="email" placeholder="Enter Email Here"/>
                <input type="password" name="" placeholder="Enter Password Here"/>--%>

         <asp:TextBox ID="TextBox1" runat="server" placeholder="Enter your Email"></asp:TextBox>
         <asp:TextBox ID="TextBox2" type="password" runat="server" placeholder=" Enter your Password"></asp:TextBox>
       

             <asp:Button ID="Button1" runat="server" CssClass="btnn" Text="Login" OnClick="Button1_Click"  />

            <p class="link">Don't have an account 
                <a href="signup.aspx">Sign up </a> here</p>

            </div>
    </form>
</body>
</html>
