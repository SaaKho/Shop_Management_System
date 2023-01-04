using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;

using System.Configuration;
using System.Web.UI;

namespace WebDB
{
    public partial class editProfile:System.Web.UI.Page 
    {
       //editProfile e;
       public String s1;
       protected void Page_Load(object sender, EventArgs e)
       { 
           s1 = Request.QueryString["Parameter"].ToString();
         
           if (this.IsPostBack)      
                return;
                 
           setAttributes();

       }
       protected void setAttributes()
       {
           String query1 = "select Fullname from signUp where Email = '" + s1 + "'";
           String Mycon = "Data Source=DESKTOP-8LJDBA0\\SQLEXPRESS;Initial Catalog=WebProject;Integrated Security=True";
           SqlConnection con = new SqlConnection(Mycon);
           con.Open();
           SqlCommand cmd = new SqlCommand();
           cmd.CommandText = query1;
           cmd.Connection = con;
           cmd.ExecuteNonQuery();
           TextBox1.Text = cmd.ExecuteScalar().ToString();
           
           String query2 = "select PhoneNumber from signUp where Email = '" + s1 + "'";
           cmd.CommandText = query2;
           cmd.Connection = con;
           cmd.ExecuteNonQuery();
           TextBox3.Text = cmd.ExecuteScalar().ToString();

           String query3 = "select Email from signUp where  Email = '" + s1 + "'";
           cmd.CommandText = query3;
           cmd.Connection = con;
           cmd.ExecuteNonQuery();
           TextBox4.Text = cmd.ExecuteScalar().ToString();

           String query4 = "select age from signUp where  Email = '" + s1 + "'";
           cmd.CommandText = query4;
           cmd.Connection = con;
           cmd.ExecuteNonQuery();
           TextBox5.Text = cmd.ExecuteScalar().ToString();

           String query5 = "select password from signUp where  Email = '" + s1 + "'";
           cmd.CommandText = query5;
           cmd.Connection = con;
           cmd.ExecuteNonQuery();
           TextBox6.Text = cmd.ExecuteScalar().ToString();
       }
       

        protected void reflectChangesIntoDatabase()
        {

            String query1 = "update  signUp  set Fullname='" + TextBox1.Text + "' where Email = '" + s1 + "'";
            String Mycon = "Data Source=DESKTOP-8LJDBA0\\SQLEXPRESS;Initial Catalog=WebProject;Integrated Security=True";
            SqlConnection con = new SqlConnection(Mycon);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = query1;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();

            String query2 = "update  signUp  set PhoneNumber='" + TextBox3.Text + "' where Email = '" + s1 + "'";
            cmd.CommandText = query2;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();

            String query3 = "update  signUp  set Email='" + TextBox4.Text + "' where Email = '" + s1 + "'";
            cmd.CommandText = query3;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();


            String query4 = "update  signUp  set age='" + TextBox5.Text + "' where Email = '" + s1 + "'";
            cmd.CommandText = query4;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();

            String query5 = "update  signUp  set password='" + TextBox6.Text + "' where Email = '" + s1 + "'";
            cmd.CommandText = query5;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();

            con.Close();
             
            
            Response.Write("<script>alert('Changes Saved Successfully.') </script>");


            Response.Redirect("book.aspx?Parameter=" + TextBox4.Text);

           // Page page = HttpContext.Current.Handler as Page;
            //ScriptManager.RegisterStartupScript(page, page.GetType(),"success_msg", "Changes Saved Successfully ;window.location='book.aspx';", true);
            

        }

        protected void Button1_Click(object sender, EventArgs e)
        {        
            reflectChangesIntoDatabase();
        
        }



    }
}