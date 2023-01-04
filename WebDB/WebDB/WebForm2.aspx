<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebDB.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    
        <style>

        li::before
        {
         color: white;
        }
        table {
          font-family: arial, sans-serif;
          border-collapse: collapse;
          width: 100%;
        }
        
        td, th {
          border: 1px solid #dddddd;
          text-align: left;
          padding: 8px;
          width: 100px;
        }
        
        tr:nth-child(even) {
          background-color: #dddddd;
        }
        </style>

        
<table>
    <tr>
      <th>Scholarship Name</th>
      <th>Link</th>
      <th>Scholarship Name</th>  
      <th>Link</th>
    </tr>
    <tr>
      <td>Alfreds Futterkiste</td>
      <td>
      <a style="text-decoration:underline; color: rgb(0, 126, 167);" href="https://www.w3schools.com">https://www.w3schools.com</a></td>
      <td>Japan</td>
      <td>
        <a style="text-decoration:underline; color: rgb(0, 126, 167);" href="https://www.w3schools.com">https://www.w3schools.com</a></td>
    </tr>
    <tr>
      <td>Centro comercial Moctezuma</td>
      <td>
        <a style="text-decoration:underline; color: rgb(0, 126, 167);" href="https://www.w3schools.com">https://www.w3schools.com</a></td>
      <td>Mexico</td>
      <td>
        <a style="text-decoration:underline; color: rgb(0, 126, 167);" href="https://www.w3schools.com">https://www.w3schools.com</a></td>
    </tr>
    <tr>
      <td>Ernst Handel</td>
      <td>
        <a style="text-decoration:underline; color: rgb(0, 126, 167);" href="https://www.w3schools.com">https://www.w3schools.com</a></td>
      <td>Austria</td>
      <td>
        <a style="text-decoration:underline; color: rgb(0, 126, 167);" href="https://www.w3schools.com">https://www.w3schools.com</a></td>
    </tr>
    <tr>
      <td>Island Trading</td>
      <td>
        <a style="text-decoration:underline; color: rgb(0, 126, 167);" href="https://www.w3schools.com">https://www.w3schools.com</a></td>
      <td>UK</td>
      <td>
        <a style="text-decoration:underline; color: rgb(0, 126, 167);" href="https://www.w3schools.com">https://www.w3schools.com</a></td>
    </tr>
    <tr>
      <td>Laughing Bacchus Winecellars</td>
      <td>
        <a style="text-decoration:underline; color: rgb(0, 126, 167);" href="https://www.w3schools.com">https://www.w3schools.com</a></td>
      <td>Canada</td>
      <td>
        <a style="text-decoration:underline; color: rgb(0, 126, 167);" href="https://www.w3schools.com">https://www.w3schools.com</a></td>
    </tr>
    <tr>
      <td>Magazzini Alimentari Riuniti</td>
      <td>
        <a style="text-decoration:underline; color: rgb(0, 126, 167);" href="https://www.w3schools.com">https://www.w3schools.com</a></td>
        <td>Italy</td>
        <td>
            <a style="text-decoration:underline; color: rgb(0, 126, 167);" href="https://www.w3schools.com">https://www.w3schools.com</a></td>
    </tr>
    
  </table>


    </form>
</body>
</html>
