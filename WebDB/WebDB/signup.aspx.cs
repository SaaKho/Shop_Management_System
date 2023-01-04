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
    public partial class signup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        bool enterDataInSignTable()
        {
            String query = "insert into signUP(Email,Fullname,PhoneNumber,CNIC,age,location,password) values('" + TextBox1.Text + "','" + TextBox2.Text + "' ,'"+TextBox3.Text+"','"+TextBox4.Text+"','"+TextBox5.Text+"','"+TextBox6.Text+"','"+TextBox7.Text+"')";
           
            if (checkEmail() == false && checkCNIC()==false )
            {

                String Mycon = "Data Source=DESKTOP-8LJDBA0\\SQLEXPRESS;Initial Catalog=WebProject;Integrated Security=True";
                SqlConnection con = new SqlConnection(Mycon);
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = query;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }

          return false;
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            bool t = enterDataInSignTable();
            if (t == true)
            {

                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox5.Text = "";
                TextBox6.Text = "";
                TextBox7.Text = "";

                Response.Write("<script>alert('Accont created Successfully. Thanks!') </script>");
              //  book b=new book();
              //  b.Page_Lo();
                
              

            }
        }

        private Boolean checkCNIC()
        {
            Boolean CNIC = false;

            //String Mycon = "Data Source=DESKTOP-8LJDBA0\\SQLEXPRESS;Initial Catalog=WebProject;Integrated Security=True";

            String count_CNIC = "select count(*) from signUp where CNIC='" + TextBox4.Text + "'";
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-8LJDBA0\\SQLEXPRESS;Initial Catalog=WebProject;Integrated Security=True");

            SqlCommand cmd = new SqlCommand(count_CNIC, con);

            SqlDataAdapter sd = new SqlDataAdapter();
            con.Open();


            String S = cmd.ExecuteScalar().ToString();

            sd.SelectCommand = cmd;

            DataSet ds = new DataSet();
            sd.Fill(ds);

            long x = Int64.Parse(S);

            if (x > 0)
            {

                Response.Write("<script>alert('Already have account with this CNIC.Please use different CNIC!') </script>");
                CNIC = true;
                return CNIC;

            }
            con.Close();

            return CNIC;

        }

        private Boolean checkEmail()
        {

            Boolean email = false;

            //String Mycon = "Data Source=DESKTOP-8LJDBA0\\SQLEXPRESS;Initial Catalog=WebProject;Integrated Security=True";

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

                Response.Write("<script>alert('Already have account with this mail.Please use different mail!') </script>");

                email = true;
                return email;

            }
            con.Close();

            return email;


        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            Response.Redirect("login.aspx");
        }

    }
}