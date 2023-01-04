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
       
    public partial class login : System.Web.UI.Page
    { 
      public String email;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
       
        private Boolean loginVerification()
         {
             if (checkEmail() == true && checkPassword() == true)
             {

                 //editProfile io = new editProfile();
                 //email = TextBox1.Text;
                 //io.get(email);
                 Response.Redirect("book.aspx?Parameter=" + TextBox1.Text);

             }

             else if(checkEmail() == false)
             {
                 Response.Write("<script>alert('Email is incorrect') </script>");
             }
             else if (checkPassword() == false)
             {
                 Response.Write("<script>alert('Password is incorrect') </script>");
             }

             return true;
         }

        private Boolean checkPassword() 
        { 
            String count_Password = "select count(*) from signUp where password='" + TextBox2.Text + "'";
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-8LJDBA0\\SQLEXPRESS;Initial Catalog=WebProject;Integrated Security=True");

            SqlCommand cmd = new SqlCommand(count_Password, con);

            SqlDataAdapter sd = new SqlDataAdapter();
            con.Open();


            String S = cmd.ExecuteScalar().ToString();

            sd.SelectCommand = cmd;

            DataSet ds = new DataSet();
            sd.Fill(ds);

            int p = Int32.Parse(S);

            if (p > 0)
            {
                //Response.Write("<script>alert('Already have account with this mail.Please use different mail!') </script>");           
                con.Close();
                return true;
            }
            con.Close();
            return false;
        }
        private Boolean checkEmail()
        {
            
            String count_Email = "select count(*) from signUp where Email='" + TextBox1.Text + "'";
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-8LJDBA0\\SQLEXPRESS;Initial Catalog=WebProject;Integrated Security=True");

            SqlCommand cmd = new SqlCommand(count_Email, con);

            SqlDataAdapter sd = new SqlDataAdapter();
            con.Open();


            String S = cmd.ExecuteScalar().ToString();

            sd.SelectCommand = cmd;

            DataSet ds = new DataSet();
            sd.Fill(ds);

            int x = Int32.Parse(S);

            if (x > 0)
            {
                 
                con.Close();
                return true;
            }
            con.Close();
            return false;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
              loginVerification();
        }
    }
}