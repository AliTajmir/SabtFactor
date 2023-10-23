using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
   public class User
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        
        public string Adres { get; set; }

        public virtual IEnumerable<Order> Orders { get; set; }

    }
}
