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
    public partial class FrmStartup : Form
    {        
        Operation<Products> op_Product;
        Operation<Order> op_Order;
        Operation<User> op_User;
        ContextDb db;
        List<OrderViewModel> list;
        int id_combo;
        public FrmStartup()
        {
            InitializeComponent();
            op_Product = new Operation<Products>();
            op_Order = new Operation<Order>();
            op_User = new Operation<User>();
            db = new ContextDb();
            list = new List<OrderViewModel>();
            
        }
        private void SetName_DataGridView()
        {
            dataGridViewX1.Columns[0].HeaderText = "ردیف";
            dataGridViewX1.Columns[1].HeaderText = "نام کالا";
            dataGridViewX1.Columns[2].HeaderText = "قیمت";
            dataGridViewX1.Columns[3].HeaderText = "تعداد";
            try
            {
                dataGridViewX2.Columns[0].HeaderText = "ردیف";
                dataGridViewX2.Columns[1].HeaderText = "نام کالا";
                dataGridViewX2.Columns[2].HeaderText = "نام کاربر";
                dataGridViewX2.Columns[0].Width = 35;
                dataGridViewX2.Columns[1].Width = 75;
                dataGridViewX2.Columns[2].Width = 80;
                dataGridViewX2.Columns[3].Visible = false;
                dataGridViewX2.Columns[4].Visible = false;
                dataGridViewX2.Columns[5].Visible = false;


            }
            catch
            {

            }

        }
      

        private void btn_Sabt_order_Click(object sender, EventArgs e)
        {
           


        }

        private void btn_ShowOrders_Click(object sender, EventArgs e)
        {
           
        }

        private async void comboUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridViewX1.Rows)
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                }
                User item = await op_User.GetItem((int)comboUser.SelectedValue);

                txtUser.Text = item.Name;
                txtPhoneNumber.Text = item.PhoneNumber;
                txtAdres.Text = item.Adres;
            }
            catch
            {

            }
        }

       

        private void btnSabt_Click(object sender, EventArgs e)
        {
          

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
         
        }

        private void  btnUpdate_Click(object sender, EventArgs e)
        {
         
         
        }
        public int GetIdGridView()
        {
            int id = int.Parse(dataGridViewX1.CurrentRow.Cells[0].Value.ToString());
            return  id;
        }
       

     

       
        private async void FormLoad()
        {
            try
            {

                dataGridViewX1.DataSource = await op_Product.GetList();
                comboUser.DataSource = await op_User.GetList();
                comboUser.DisplayMember = "Name";
                comboUser.ValueMember = "id";
                SetName_DataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {

        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            if (txtSearchName.Text == "")
            {
                FormLoad();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void FrmStartup_Load(object sender, EventArgs e)
        {
            FormLoad();
        }

        private void btnDelete_Pish_Factor_Click(object sender, EventArgs e)
        {
           
        }

        private async void btnDeleteUser_Click_1(object sender, EventArgs e)
        {
            await op_User.delete((int)comboUser.SelectedValue);
            FormLoad();
        }

        private async  void btnAddUser_Click_1(object sender, EventArgs e)
        {
           var checkNameExists= db.User.Any(x => x.Name == txtUser.Text);
            if (checkNameExists == false)
            {


                User user = new User()
                {
                    Name = txtUser.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    Adres = txtAdres.Text
                };
                var check = await op_User.AddData(user);
                if (check == true)
                {
                    MessageBox.Show("کاربر ثبت گردید");
                    FrmStartup_Load(null, null);

                }
                else
                {
                    MessageBox.Show("مشکلی در ثبت کاربر به وجود آمد");

                }
            }
            else
            {
                MessageBox.Show("این کاربر قبلا به ثبت رسیده است");
                Empty_txt();
            }

        }

        private void btn_search_Click_1(object sender, EventArgs e)
        {
            var list = db.Products.Where(x => x.Name.Contains(txtSearchName.Text));
            if (list != null && list.Any())
                dataGridViewX1.DataSource = list.ToList();
            else
            {
                MessageBox.Show("نتیجه ای یافت نشد");
            }
        }

        private void btn_ShowOrders_Click_1(object sender, EventArgs e)
        {
            try
            {
                foreach (var item in list)
                {
                    Order order = new Order(item.count, item.id, id_combo);

                    op_Order.AddData(order);
                }
                MessageBox.Show("ثبت نهایی انجام شد ");
                list.Clear();
                dataGridViewX2.DataSource = list;
                //new Form2(op_Order,op_Product,op_User).ShowDialog();
                new FrmOrders(db, op_Order, op_User).ShowDialog();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btn_Sabt_order_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewX1.SelectedCells.Count > 0)
            {
                try
                {

                    int id = GetIdGridView();
                    var item = db.Products.Find(id);
                    var check_NameKala_Exists = list.Any(x => x.NameKala == item.Name);
                    if (check_NameKala_Exists == false)
                    {
                        if (comboUser.Items.Count > 0)
                        {
                            id_combo = (int)comboUser.SelectedValue;

                            OrderViewModel orderViewModel = new OrderViewModel()
                            {
                                id = item.id,
                                NameKala = item.Name,
                                count = 1,
                                Price = item.Price,
                                UserName = comboUser.Text


                            };


                            list.Add(orderViewModel);

                            dataGridViewX2.DataSource = list.ToList();
                            SetName_DataGridView();
                            var message = item != null ? MessageBox.Show("یک کالا اضافه شد") : MessageBox.Show("به مشکل خورد");
                            dataGridViewX1.SelectedRows[0].DefaultCellStyle.BackColor = Color.Yellow;

                        }
                        else
                        {
                            MessageBox.Show("کمبو کاربران خالی است لطفا با یوزر اضافه کنید");
                        }
                    }
                    else
                    {
                        MessageBox.Show("این کالا قبلا در لیست پیش فاکتور ثبت شده است");
                    }
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message.ToString());
                }
                
            }
        }

        private void btnDelete_Pish_Factor_Click_1(object sender, EventArgs e)
        {
            try
            {
                var id = int.Parse(dataGridViewX2.CurrentRow.Cells[0].Value.ToString());
                var item = list.Find(x => x.id == id);
                list.Remove(item);
                dataGridViewX2.DataSource = list;
            }
            catch
            {

            }
        }

        private async void btnDelete_Click_1(object sender, EventArgs e)
        {
            await op_Product.delete(GetIdGridView());
            FormLoad();
        }

        private void btnUpdate_Click_2(object sender, EventArgs e)
        {
            new Frm_Page_Add_Update(1, GetIdGridView(), op_Product, this).ShowDialog();
        }

        private void btnSabt_Click_1(object sender, EventArgs e)
        {
            new Frm_Page_Add_Update(0, null, op_Product, this).ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void Empty_txt()
        {
            txtAdres.Text = "";
            txtPhoneNumber.Text = "";
            txtUser.Text = "";
        }
        private void btn_Empty_txt_Click(object sender, EventArgs e)
        {
            Empty_txt();
        }
    }
}
