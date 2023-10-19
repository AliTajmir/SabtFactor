using System.Data.Entity;

namespace WindowsFormsApp1
{
    public  class ContextDb:DbContext
    {
        //public Context():base("DbFactor")
        //{

        //}
        public DbSet<Order> Order { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<User> User { get; set; }
    }
}
