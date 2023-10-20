using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        private readonly ContextDb db;
        public Form2(ContextDb _db)
        {
            InitializeComponent();
           
            db = _db;
        }


        private async void Form2_Load(object sender, EventArgs e)
        {
           List<OrderViewModel> orders =await GetListOrder();
            if (orders != null && orders.Any())
            {
                dataGridView1.DataSource =orders;
            }
            else
            {
                MessageBox.Show("دیتا یافت نشد");
            }
            SetName_DataGridView();
        }

        public async Task<List<OrderViewModel>> GetListOrder()
        {
            try
            {
                var orders = await db.Order
               .Include(o => o.Products).Include(o => o.User).Select(o => new OrderViewModel
               {
                   id = o.id,
                   NameKala = o.Products.Name,
                   count = o.Products.Count,
                   Price = o.Products.Price,
                   UserName = o.User.Name
               }).ToListAsync();




                return orders;
            }
            catch
            {
                return null;
            }
        }
        private void SetName_DataGridView()
        {
            dataGridView1.Columns[0].HeaderText = "شماره کالا";
            dataGridView1.Columns[1].HeaderText = "نام کالا";
            dataGridView1.Columns[2].HeaderText = "تعداد کالا";
            dataGridView1.Columns[3].HeaderText = "قیمت";
            dataGridView1.Columns[4].HeaderText = "نام کاربر";
        }

        
    }
}
