using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace donor.pages
{
    public partial class login : System.Web.UI.Page
        
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
        int i;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            i=0;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from login where username='"+txtusername.Text+"' and password='"+txtpassword.Text+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable ();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            i= Convert.ToInt32(dt.Rows.Count.ToString());
            if (i == 1)
            {
                Response.Redirect("manage.aspx");

            }
            else
            {
                Label1.Text = "you have entered invalid username and password";
            }

             con.Close();



        }
    }
}
