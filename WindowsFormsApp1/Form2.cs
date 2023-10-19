using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        Operation op;
        public Form2(Operation _op)
        {
            InitializeComponent();
            op = _op;

        }


        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from o in op.GetList<Order>()
                                       join p in op.GetList<Products>()
              on o.Product_id equals p.id
                                       join u in op.GetList<User>() on o.User_id equals u.id
                                       select new
                                       {
                                           id = o.id,
                                           Name = p.Name,
                                           Count = p.Count,
                                           Price = p.Price,
                                           NameUser = u.Name


                                       }).ToList();

            SetName_DataGridView();


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
