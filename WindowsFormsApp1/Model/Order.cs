using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
  public  class Order
    {
        public Order(string _User_name,string _Product_name,int _Product_id,int _User_id,int _Price)
        {
            this.User_id = _User_id;
            this.User_name = _User_name;
            this.Product_id = _Product_id;
            this.Product_name = _Product_name;
            this.Price = _Price;
        }
        public int Product_id { get; set; }

        public int User_id { get; set; }

        public string Product_name { get; set; }
        public string User_name { get; set; }
        public int Price { get; set; }
    }
}
