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
        List<Order> orders;
        public Form2(List<Order> _orders)
        {
            InitializeComponent();
            orders = _orders;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = orders;
            SetName_DataGridView();


        }
        private void SetName_DataGridView()
        {
            dataGridView1.Columns[0].HeaderText = "شماره کالا";
            dataGridView1.Columns[1].HeaderText = "شماره کاربر";
            dataGridView1.Columns[2].HeaderText = "نام کالا";
            dataGridView1.Columns[3].HeaderText = "نام کاربر";
            dataGridView1.Columns[4].HeaderText = "قیمت";
        }
    }
}
