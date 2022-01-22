using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace donor.pages
{
    public partial class checkout : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataReader SR = null;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "Select Top(1) Name from donorlist order by id desc ";
            cmd.ExecuteNonQuery();
            SR = cmd.ExecuteReader();
            if (SR.Read())
            {
                TextBox1.Text = SR.GetValue(0).ToString();

            }
            con.Close();

            SqlDataReader SR2 = null;
            con.Open();
            SqlCommand cmd2 = con.CreateCommand();
            cmd.CommandText = "Select Top(1) Email from donorlist order by id desc";
            cmd.ExecuteNonQuery();
            SR2 = cmd.ExecuteReader();
            if (SR2.Read())
            {
                TextBox2.Text = SR2.GetValue(0).ToString();

            }
            con.Close();



            SqlDataReader SR3 = null;
            con.Open();
            SqlCommand cmd3 = con.CreateCommand();
            cmd.CommandText = "Select Top(1) Phone from donorlist order by id desc";
            cmd.ExecuteNonQuery();
            SR3 = cmd.ExecuteReader();
            if (SR3.Read())
            {
                TextBox3.Text = SR3.GetValue(0).ToString();

            }
            con.Close();


            SqlDataReader SR4 = null;
            con.Open();
            SqlCommand cmd4 = con.CreateCommand();
            cmd.CommandText = "Select Top(1) Amount from donorlist order by id desc";
            cmd.ExecuteNonQuery();
            SR4 = cmd.ExecuteReader();
            if (SR4.Read())
            {
                TextBox4.Text = SR4.GetValue(0).ToString();

            }
            con.Close();

            SqlDataReader SR5 = null;
            con.Open();
            SqlCommand cmd5 = con.CreateCommand();
            cmd.CommandText = "Select Top(1) id from donorlist order by id desc";
            cmd.ExecuteNonQuery();
            SR5 = cmd.ExecuteReader();
            if (SR5.Read())
            {
                TextBox5.Text = SR5.GetValue(0).ToString();

            }
            con.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["name"] = TextBox1.Text;
            Session["email"] = TextBox2.Text;
            Session["phone"] = TextBox3.Text;
            Session["amount"] = TextBox4.Text;
            Session["id"] = TextBox5.Text;

           if (TextBox4.Text != null)
            {

                Response.Redirect("payment.aspx");
            
            } 
        }

       
    }
}
