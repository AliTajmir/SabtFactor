using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
 public   class OrderViewModel
    {
        public int id { get; set; }
        public string NameKala { get; set; }
        public string UserName { get; set; }
        public int Price { get; set; }
        public int count { get; set; }

        public int Total { get { return this.Price * this.count; } }
    }
}
