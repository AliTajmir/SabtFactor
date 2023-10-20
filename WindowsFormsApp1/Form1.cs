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
        Operation<Products> op_Product;
        Operation<Order> op_Order;
        Operation<User> op_User;
        ContextDb db;
        int id;
        public Form1()
        {
            InitializeComponent();
            op_Product = new Operation<Products>();
            op_Order = new Operation<Order>();
            op_User = new Operation<User>();
            db = new ContextDb();
        }
        private void SetName_DataGridView()
        {
            dataGridView1.Columns[0].HeaderText = "ردیف";
            dataGridView1.Columns[1].HeaderText = "نام کالا";
            dataGridView1.Columns[2].HeaderText = "قیمت";
            dataGridView1.Columns[3].HeaderText = "تعداد";
           

        }
      

        private void btn_Sabt_order_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                try
                {
                    
                    int id = GetItemDataGridView();
                    var item = db.Products.Find(id);
                    if (comboUser.Items.Count > 0)
                    {
                        int id_combo = (int)comboUser.SelectedValue;
                        string Name_combo = comboUser.Text;
                        Order order = new Order();
                        order.Product_id = item.id;
                        
                        order.User_id = id_combo;
                        op_Order.AddData(order);
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
            //new Form2(op_Order,op_Product,op_User).ShowDialog();
            new Form2(db).ShowDialog();
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

            op_Product.AddData(products);
            Form1_Load(null, null);

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                Name = txtUser.Text,
            };
            op_User.AddData(user);
            Form1_Load(null, null);
        }

        private void  btnUpdate_Click(object sender, EventArgs e)
        {
           
          var item= db.Products.Find(id);
            item.Name = txtNameProduct.Text;
            item.Price =int.Parse( txtPrice.Text);
            item.Count = int.Parse(txtCount.Text);
            db.SaveChanges();
            Form1_Load(null, null);
        }
        public int GetItemDataGridView()
        {
            int id = int.Parse( dataGridView1.CurrentRow.Cells[0].Value.ToString());
            return  id;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {

            op_Product.delete(GetItemDataGridView());
            Form1_Load(null, null);
        }

        private  void btnDeleteUser_Click(object sender, EventArgs e)
        {
            op_User.delete((int)comboUser.SelectedValue);
            Form1_Load(null, null);

        }

        private async void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                var item = await op_Product.GetItem(GetItemDataGridView());
                txtNameProduct.Text = item.Name;
                txtPrice.Text = item.Price.ToString();
                txtCount.Text = item.Count.ToString();
                id = item.id;
            }
            catch(Exception er)
            {
                MessageBox.Show("an orrucced error:" + er.Message);
            }
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource =await  op_Product.GetList();
            comboUser.DataSource = await op_User.GetList();
            comboUser.DisplayMember = "Name";
            comboUser.ValueMember = "id";
            SetName_DataGridView();
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {

        }
    }
}
