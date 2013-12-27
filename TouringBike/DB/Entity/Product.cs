using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TouringBike.DB.Entity
{
    public class Product
    {
        private int id;
        private string name;
        private string number;
        private float cost;
        private float price;
        private DateTime ssdate;

        public int Id
        {
            get { return id; }
            set { id = value;} 
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Number
        {
            get { return number; }
            set { number = value; }
        }

        public float Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        public float Price
        {
            get { return price; }
            set { price = value; }
        }

        public DateTime SSdate
        {
            get { return ssdate; }
            set { ssdate = value; }
        }



    }
}