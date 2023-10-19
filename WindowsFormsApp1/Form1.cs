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
        Operation operation;
        ContextDb db;
        public Form1()
        {
            InitializeComponent();
             operation = new Operation();
            db = new ContextDb();
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
            dataGridView1.DataSource =operation.GetList<Products>() ;
            comboUser.DataSource = operation.GetList<User>();
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
                    var item = db.Products.Find(id);
                    if (comboUser.Items.Count > 0)
                    {
                        int id_combo = (int)comboUser.SelectedValue;
                        string Name_combo = comboUser.Text;
                        Order order = new Order();
                        order.Product_id = item.id;
                        order.User_id = id_combo;
                        operation.AddData<Order>(order);
                        var message = item != null ? MessageBox.Show("یک کالا اضافه شد") : MessageBox.Show("به مشکل خورد");
                        dataGridView1.SelectedRows[0].DefaultCellStyle.BackColor = Color.Yellow;

                    }
                    else
                    {
                        MessageBox.Show("کمبو کاربران خالی است لطفا با یوزر اضافه کنید");
                    }
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message.ToString());
                }
            }


        }

        private void btn_ShowOrders_Click(object sender, EventArgs e)
        {
            new Form2(operation).ShowDialog();
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

        private void btnSabt_Click(object sender, EventArgs e)
        {
            Products products = new Products()
            {
                Name = txtNameProduct.Text,
                Price = int.Parse(txtPrice.Text),
                Count = int.Parse(txtCount.Text),

            };
            
            operation.AddData<Products>(products);
            Form1_Load(null, null);

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                Name = txtUser.Text,
            };
            operation.AddData<User>(user);
            Form1_Load(null, null);
        }
    }
}
