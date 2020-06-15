using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace StoredProcWebForm
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string connectionstring = ConfigurationManager.ConnectionStrings["StoredProc"].ConnectionString;
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                SqlCommand sqlcom = new SqlCommand();
                sqlcom.Connection = con;
                sqlcom.CommandText = "GetTransactDetails";
                sqlcom.CommandType = CommandType.StoredProcedure;
                if (PurchaseOrderID.Value.Trim() != "")
                {
                    SqlParameter param = new SqlParameter("@PurchaseOrderID", PurchaseOrderID.Value);
                    sqlcom.Parameters.Add(param);
                }

                con.Open();
                SqlDataReader sd = sqlcom.ExecuteReader();
                searchResults.DataSource = sd;
                searchResults.DataBind();

            }
        }
    }

}

     
    