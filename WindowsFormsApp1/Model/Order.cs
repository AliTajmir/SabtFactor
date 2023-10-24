using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
  public  class Order
    {
        public Order(int _Count , int _Product_id, int _User_id)
        {
            this.User_id = _User_id;
            this.Count =_Count ;
            this.Product_id = _Product_id;
           
        }
        [Key]
        public int id { get; set; }
        [ForeignKey("Products")]
        public int Product_id { get; set; }
        [ForeignKey("User")]

        public int User_id { get; set; }
        public int Count { get; set; }

        public virtual Products Products { get; set; }
        public virtual User User { get; set; }
    }
}
