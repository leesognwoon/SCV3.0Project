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
    public partial class ProductsAdd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.Name = txtName.Text;
            p.Number = txtNumber.Text;
            p.Cost = float.Parse(txtCost.Text);
            p.Price = float.Parse(txtPrice.Text);
            p.SSdate = DateTime.Parse(txtDate.Text);

            new ProductsDAL().InsertProduct(p);

            Response.Redirect("ProductsList.aspx");

            
        }
    }
}