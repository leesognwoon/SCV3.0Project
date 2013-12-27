using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TouringBike.DB.Entity;
using TouringBike.DB.DAL;

namespace TouringBike.DB
{
    public partial class ProductUpdate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
            Product p = new Product();
            p = new ProductsDAL().SelectById(Convert.ToInt32(id));

            if (!IsPostBack)
            {
                txtId.Text = p.Id.ToString();
                txtName.Text = p.Name;
                txtNumber.Text = p.Number;
                txtCost.Text = p.Cost.ToString();
                txtPrice.Text = p.Price.ToString();
                txtDate.Text = p.SSdate.ToString();
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            string id = Request.QueryString["id"];

            p.Id = Convert.ToInt32(id);
            p.Name = txtName.Text.ToString();
            p.Number = txtNumber.Text.ToString();
            p.Cost = Convert.ToInt32(txtCost.Text);
            p.Price = Convert.ToInt32(txtPrice.Text);
            p.SSdate = DateTime.Now;

            new ProductsDAL().UpdateProduct(p);

            Response.Redirect("ProductsList.aspx");

        }
    }
}