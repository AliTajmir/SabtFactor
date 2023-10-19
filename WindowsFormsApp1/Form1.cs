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
    public partial class Form1 : Form
    {
        List<Products> Products;
        List<Order> orders;
        List<User> user;
        public Form1()
        {
            InitializeComponent();
            Products = new List<Products>()
        {
            new Products(){id=1,Name="کفش",Count=2,Price=23000},
            new Products(){id=2,Name="شلوار",Count=3,Price=120000},
            new Products(){id=3,Name="کیف",Count=1,Price=50000},
            new Products(){id=4,Name="لباس",Count=4,Price=65000},
            new Products(){id=5,Name="کت",Count=8,Price=1500000},
            new Products(){id=6,Name="کروات",Count=20,Price=36000},
            new Products(){id=7,Name="کلاه",Count=3,Price=50000},
            new Products(){id=8,Name="روسری",Count=5,Price=300000},
            new Products(){id=9,Name="شال",Count=10,Price=56000},


        };
            user = new List<User>()
            {
                new User(){id=1,Name="Ali"},
                new User(){id=2,Name="Reza"},
                new User(){id=3,Name="Mohammad"},
                new User(){id=4,Name="neda"},
            };
            orders = new List<Order>();
        }
        private void SetName_DataGridView()
        {
            dataGridView1.Columns[0].HeaderText = "ردیف";
            dataGridView1.Columns[1].HeaderText = "نام کالا";
            dataGridView1.Columns[2].HeaderText = "قیمت";
            dataGridView1.Columns[3].HeaderText = "تعداد";
           

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Get_Information.GetList(Products);
            comboUser.DataSource = user;
            comboUser.DisplayMember = "Name";
            comboUser.ValueMember = "id";
            SetName_DataGridView();

        }

        private void btn_Sabt_order_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                try
                {
                    int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    var item = Products.Find(i => i.id == id);
                    int id_combo = (int)comboUser.SelectedValue;
                    string Name_combo = comboUser.Text;
                    Order order = new Order(Name_combo, item.Name, item.id, id_combo, item.Price);
                    orders.Add(order);
                    var message = item != null ? MessageBox.Show("یک کالا اضافه شد") : MessageBox.Show("به مشکل خورد");
                    dataGridView1.SelectedRows[0].DefaultCellStyle.BackColor = Color.Yellow;
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message.ToString());
                }
            }


        }

        private void btn_ShowOrders_Click(object sender, EventArgs e)
        {
            new Form2(orders).ShowDialog();
        }

        private void comboUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboUser_SelectedValueChanged(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.White;
            }
            
            
        }
    }
}
