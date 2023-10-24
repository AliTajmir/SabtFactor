using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
  public   class Operation <T> where T:class
    {
        ContextDb db;
        public Operation()
        {
            db = new ContextDb();
        }
        public  void AddData(T item) 
        {
            db.Set<T>().Add(item);
            db.SaveChanges();
        }
        public async Task<List<T>> GetList() 
        {
            return await db.Set<T>().ToListAsync();
        }
        public async Task<T> GetItem(int id)
        {
            return await db.Set<T>().FindAsync(id);
            
        }
        public async Task<Exception>  delete(int id) 
        {
            try
            {
                var item = await GetItem(id);
                db.Set<T>().Remove(item);
                db.SaveChanges();
                return null;
            }
            catch(Exception er)
            {
                return er;
            }
        }
        public  bool Up(T item)
        {
            //try
            //{
                

                db.Entry(item).CurrentValues.SetValues(item);
               db.SaveChanges();
                return true;
            //}
            //catch
            //{
                
            //    return false;
            //}
        }
       
    }
}
