using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TouringBike.DB.DAL;
using TouringBike.DB.Entity;
using System.Data.SqlClient;

namespace TouringBike.DB
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetData();
            }

        }

        protected void GetData()
        {
            rptProducts.DataSource = new ProductsDAL().SelectProduct();
            rptProducts.DataBind();
        }

        protected void rptProducts_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "Delete")
            {
                //Response.Write("삭제 버튼이 클릭됐습니다.");
                //string connectionString = @"Data Source=.\SQLEXPRESS;" + "Initial Catalog=AdventureWorksLT2008;Integrated Security=SSPI";
                //SqlConnection conn = new SqlConnection(connectionString);

                //conn.Open();

                //string deleteSQL = "USP_DELETEPRODUCT";
                //SqlCommand cmd = new SqlCommand(deleteSQL, conn);
                //cmd.CommandType = System.Data.CommandType.StoredProcedure;

                //SqlParameter pidParam = new SqlParameter("@pid", System.Data.SqlDbType.Int);
                //pidParam.Value = Convert.ToInt32(e.CommandArgument.ToString());
                //cmd.Parameters.Add(pidParam);

                //cmd.ExecuteNonQuery();
           
                //rptProducts.DataSource = new ProductsDAL().SelectProduct();
                //rptProducts.DataBind();

                //conn.Close();

                Product p = new Product();
                p.Id = Convert.ToInt32(e.CommandArgument.ToString());

                new ProductsDAL().DeleteProduct(p);

                GetData();
            }

            else if (e.CommandName == "Update") 
            {
               
                Response.Redirect("ProductUpdate.aspx?id=" + e.CommandArgument.ToString());
                
            }
        }
    }
}