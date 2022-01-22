using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Net.Mail;
using System.Net;
using System.Net.Mime;


namespace donor.pages
{
    public partial class main :  System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {
            
           
        }

       

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into donorlist values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + DropDownList1.Text + "')";
            cmd.ExecuteNonQuery();
            Response.Write("Success!");
            Response.Redirect("checkout.aspx");

            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";

            
            con.Close();
        }

        

        protected void Button2_Click(object sender, EventArgs e)
        {
          /*  try
            {
                MailMessage Mail = new MailMessage();
                Mail.From = new MailAddress("donorapp3@gmail.com");
                Mail.To.Add(new MailAddress(TextBox2.Text));
                Mail.Subject = "Your Donation Pledge";
                Mail.Body = "This is to remind you about your donation pledge, the linkto pay ,if already paid kindly ignore";
                SmtpClient SMTP = new SmtpClient("smtp@gmail.com");
                SMTP.Port = 465;
                SMTP.EnableSsl = true;
                SMTP.Credentials = new System.Net.NetworkCredential("donorapp3@gmail.com", "Fruitjuice21");
                SMTP.Send(Mail);
                Label1.Text = "Mail sent";


            }

            catch (Exception ex)
            {
                Label1.Text = ex.StackTrace;
            }*/

            try
            {

                SmtpClient mySmtpClient = new SmtpClient("smtp.gmail.com");
                mySmtpClient.Port = 25;
         

                // set smtp-client with basicAuthentication
                mySmtpClient.UseDefaultCredentials = false;
                System.Net.NetworkCredential basicAuthenticationInfo = new
                   System.Net.NetworkCredential("donorapp3@gmail.com", "Fruitjuice21");
                mySmtpClient.Credentials = basicAuthenticationInfo;

                // add from,to mailaddresses
                MailAddress from = new MailAddress("donorapp3@gmail.com", "Donorapp");
                MailAddress to = new MailAddress("TextBox2.Text", "TextBox1.Text");
                MailMessage myMail = new System.Net.Mail.MailMessage("donorapp3@gmail.com", "TextBox2.Text");

              
                // set subject and encoding
                myMail.Subject = "Donation Pledge";
                myMail.SubjectEncoding = System.Text.Encoding.UTF8;

                // set body-message and encoding
                myMail.Body = "dont forget to send your contribution,link to site:http://localhost:1081/main.aspx";
                myMail.BodyEncoding = System.Text.Encoding.UTF8;
                // text or html
                myMail.IsBodyHtml = false;
                

                mySmtpClient.Send(myMail);
            }

        
            catch (Exception ex)
            {
                Label1.Text = ex.StackTrace;
            }
        }

        
        

        

       
             
       
       } 
           
         

        
    }
