<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="signup.aspx.cs" Inherits="WebDB.signup" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="~/Style/St.css" rel="stylesheet" type="text/css" />

</head>
<body>
    <form id="form1" runat="server">
    

        <div class="overlay"></div> 
    <img src="pics/b2.jpg" alt="" height="657vh" width="1366vh"/>
 

    <div class="signUpForm"> 
      <h2>Sign Up Here</h2> 
         
        <asp:TextBox ID="TextBox1" type="Email" runat="server" placeholder="Enter your Email"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" placeholder="Enter your name"></asp:TextBox>
        <asp:TextBox ID="TextBox3" runat="server" placeholder="Enter Phone Number"></asp:TextBox>
       
       <asp:TextBox ID="TextBox4" runat="server" placeholder="Enter your CNIC"></asp:TextBox>
        <asp:TextBox ID="TextBox5" type="number" runat="server" max="100" min="0" placeholder="Enter your Age"></asp:TextBox>
    
             <asp:TextBox ID="TextBox6" runat="server" placeholder=" Enter your location"></asp:TextBox>
       <asp:TextBox ID="TextBox7" type="password" runat="server" placeholder=" Enter your Password"></asp:TextBox>
       
        
         
        <br />
        <asp:Button class="btnn" ID="Button1" runat="server" Text="Sign Up" OnClick="Button1_Click" />
        <asp:Button class="btnn" ID="Button2" runat="server" Text="Login" OnClick="Button2_Click" />
       </div>

    </form>
</body>
</html>
