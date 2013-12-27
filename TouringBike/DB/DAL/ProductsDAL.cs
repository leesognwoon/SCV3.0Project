using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using TouringBike.DB.Entity;

namespace TouringBike.DB.DAL
{
    public class ProductsDAL
    {
        const string connectionString = @"Data Source=.\SQLEXPRESS;" + "Initial Catalog=AdventureWorksLT2008;Integrated Security=SSPI";
        SqlConnection conn = new SqlConnection(connectionString);

        public void InsertProduct(Product p)
        { 
            conn.Open();

            string inserSql = "USP_INSERTPRODUCT";
            SqlCommand cmd = new SqlCommand(inserSql, conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter nameParam = new SqlParameter("@pname", System.Data.SqlDbType.NVarChar, 50);
            nameParam.Value = p.Name;
            cmd.Parameters.Add(nameParam);

            SqlParameter numberParam = new SqlParameter("@pnum", System.Data.SqlDbType.NVarChar, 25);
            numberParam.Value = p.Number;
            cmd.Parameters.Add(numberParam);

            SqlParameter scParam = new SqlParameter("@sc", System.Data.SqlDbType.Money);
            scParam.Value = p.Cost;
            cmd.Parameters.Add(scParam);

            SqlParameter lpParam = new SqlParameter("@lp", System.Data.SqlDbType.Money);
            lpParam.Value = p.Price;
            cmd.Parameters.Add(lpParam);

            SqlParameter dateParam = new SqlParameter("@ssdate", System.Data.SqlDbType.DateTime);
            dateParam.Value = p.SSdate;
            cmd.Parameters.Add(dateParam);

            cmd.ExecuteNonQuery();

            conn.Close();

        }

        public IList<Product> SelectProduct()
        {
            conn.Open();

            string selectSQL = "USP_SELECTPRODUCTS";
            SqlCommand cmd = new SqlCommand(selectSQL, conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            SqlDataReader rd = cmd.ExecuteReader();
            IList<Product> products = new List<Product>();

            while (rd.Read())
            { 
                Product p = new Product();
                p.Id = Convert.ToInt32(rd["ProductID"]);
                p.Name = rd["Name"].ToString();
                p.Number = rd["Name"].ToString();
                p.Cost = Convert.ToInt32(rd["StandardCost"]);
                p.Price = Convert.ToInt32(rd["ListPrice"]);
                p.SSdate = Convert.ToDateTime(rd["SellStartDate"]);

                products.Add(p);
            }

            conn.Close();

            return products;

        }

        public void DeleteProduct(Product p)
        {
            conn.Open();

            string deleteSQL = "USP_DELETEPRODUCT";
            SqlCommand cmd = new SqlCommand(deleteSQL, conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter pidParam = new SqlParameter("@pid", System.Data.SqlDbType.Int);
            pidParam.Value = p.Id;
            cmd.Parameters.Add(pidParam);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public Product SelectById(int id)
        {
            conn.Open();

            string selectSQL = "USP_SELECTBYID";
            SqlCommand cmd = new SqlCommand(selectSQL, conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter pidParam = new SqlParameter("@pid", System.Data.SqlDbType.Int);
            pidParam.Value = id.ToString();
            cmd.Parameters.Add(pidParam); 

            SqlDataReader rd = cmd.ExecuteReader();
            Product product = new Product();

            int cnt = 0;
            while (rd.Read())
            {
                product.Id = Convert.ToInt32(rd["ProductID"]);
                product.Name = rd["Name"].ToString();
                product.Number = rd["Name"].ToString();
                product.Cost = Convert.ToInt32(rd["StandardCost"]);
                product.Price = Convert.ToInt32(rd["ListPrice"]);
                product.SSdate = Convert.ToDateTime(rd["SellStartDate"]);

                if (cnt > 0)
                {
                    break;
                }
                cnt++;

            }

            conn.Close();

            return product;
        }

        public void UpdateProduct(Product p)
        {
            conn.Open();

            string updSQL = "USP_UPDPRODUCT";
            SqlCommand cmd = new SqlCommand(updSQL, conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter pidParam = new SqlParameter("@pid", System.Data.SqlDbType.Int);
            pidParam.Value = p.Id;
            cmd.Parameters.Add(pidParam);

            SqlParameter nameParam = new SqlParameter("@pname", System.Data.SqlDbType.NVarChar, 50);
            nameParam.Value = p.Name;
            cmd.Parameters.Add(nameParam);

            SqlParameter numberParam = new SqlParameter("@pnum", System.Data.SqlDbType.NVarChar, 25);
            numberParam.Value = p.Number;
            cmd.Parameters.Add(numberParam);

            SqlParameter scParam = new SqlParameter("@sc", System.Data.SqlDbType.Money);
            scParam.Value = p.Cost;
            cmd.Parameters.Add(scParam);

            SqlParameter lpParam = new SqlParameter("@lp", System.Data.SqlDbType.Money);
            lpParam.Value = p.Price;
            cmd.Parameters.Add(lpParam);

            SqlParameter dateParam = new SqlParameter("@ssdate", System.Data.SqlDbType.DateTime2);
            dateParam.Value = p.SSdate;
            cmd.Parameters.Add(dateParam);

            cmd.ExecuteNonQuery();

            conn.Close();
        }
    }
}