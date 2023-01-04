<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="editProfile.aspx.cs" Inherits="WebDB.editProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
    <link href="~/Style/St.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">

         <div class="overlay"></div> 
    <img src="pics/img1.jpg" alt="" height="657vh" width="1366vh"/>
  

      <div class="signUpForm">
                <h2>Edit Here</h2>

          <asp:TextBox ID="TextBox1" runat="server" placeholder="Edit your Fullname"></asp:TextBox>

                <%--<input id="Fullname"   name="email" placeholder="Edit your Fullname"/>--%>

          <%--<asp:TextBox ID="TextBox2" runat="server" placeholder="Edit your CNIC"></asp:TextBox>--%>

                <%--<input id="CNIC"   name="" placeholder="Edit your CNIC"/>--%>
          <asp:TextBox ID="TextBox3" runat="server" placeholder="Edit your PhoneNumber"></asp:TextBox>


                <%--<input id="PhoneNumber" name="email" placeholder="Edit your PhoneNumber"/>--%>
                <asp:TextBox ID="TextBox4" runat="server" placeholder="Edit your Email"></asp:TextBox>
               
              <%--<input id="Email" type="email" name="" placeholder="Edit your Email"/>--%>

          <asp:TextBox ID="TextBox5" runat="server" placeholder="Edit your Age"></asp:TextBox>

                <%--<input id="age" type="number" name="email" placeholder="Edit your age"/>--%> 
          <asp:TextBox ID="TextBox6" runat="server" placeholder="Edit your Pasword"></asp:TextBox>

                <%--<input id="password" type="password" name="email" placeholder="Edit your password"/>--%> 
           

          <asp:Button ID="Button1" CssClass="btnn" runat="server" Text="Save Changes" OnClick="Button1_Click" />

            </div>
    </form>
</body>
</html>
