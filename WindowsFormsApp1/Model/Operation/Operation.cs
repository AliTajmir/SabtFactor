using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
  public   class Operation
    {
        ContextDb db;
        public Operation()
        {
            db = new ContextDb();
        }
        public  void AddData<T>(T item) where T:class
        {
            db.Set<T>().Add(item);
            db.SaveChanges();
        }
        public List<T> GetList<T>() where T:class
        {
            return db.Set<T>().ToList();
        }
    }
}
