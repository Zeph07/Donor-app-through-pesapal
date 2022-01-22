using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.Adapters;
using Pesapal.APIHelper;
using System.Data.SqlClient;
using System.Data;

namespace donor.pages
{
    public partial class payment : System.Web.UI.Page 
    {
        
        
        protected string GetPesapalUrl()
        {
            Uri pesapalPostUri = new Uri("https://www.pesapal.com/API/PostPesapalDirectOrderV4");
            Uri pesapalCallbackUri = new Uri("http://localhost:1081/pages/paybeingprocessed.aspx");

            IBuilder builder = new APIPostParametersBuilderV2()
            .ConsumerKey("sBbDuUxj+w7T9hr9Fv+6U3TA+rCaaGVA")
            .ConsumerSecret("e4IXpeFgLxvjytdpON0FU6dVJjw=")
            .OAuthVersion(EOAuthVersion.VERSION1)
            .SignatureMethod(ESignatureMethod.HMACSHA1)
            .SimplePostHttpMethod(EHttpMethod.GET)
            .SimplePostBaseUri(pesapalPostUri)
            .OAuthCallBackUri(pesapalCallbackUri);


            APIHelper<IBuilder> helper = new APIHelper<IBuilder>(builder);
            var lineItems = new List<LineItem> { };
            var lineItem = new LineItem
            {
                Particulars = "donation",
                UniqueId = Session["id"].ToString(),
                Quantity = 1,
                UnitCost = Convert.ToInt32(Session["amount"]),
                
            };

            lineItem.SubTotal = (lineItem.Quantity * lineItem.UnitCost);
            lineItems.Add(lineItem);

            PesapalDirectOrderInfo webOrder = new PesapalDirectOrderInfo()
            {
                Amount = (lineItems.Sum(x => x.SubTotal)).ToString(),
                Description = "DONATION",
                Type = "MERCHANT",
                Reference = Session["id"].ToString(),
                Email = Session["email"].ToString(),
                FirstName = Session["name"].ToString(),
                PhoneNumber = Session["phone"].ToString(),

                LineItems = lineItems
            };

            return helper.PostGetPesapalDirectOrderUrl(webOrder);

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            string FirstName = Session["name"].ToString();
            string Email = Session["email"].ToString();
            string PhoneNumber = Session["phone"].ToString();
            string UnitCost = Session["amount"].ToString();
            string Reference = Session["id"].ToString();
                       
             
            var payments = GetPesapalUrl();
            Response.Redirect(payments);
        }
    }

}
