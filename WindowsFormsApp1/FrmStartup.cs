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

                    int id = GetIdGridView();
                    var item = db.Products.Find(id);
                    if (comboUser.Items.Count > 0)
                    {
                         id_combo = (int)comboUser.SelectedValue;

                        OrderViewModel orderViewModel = new OrderViewModel() { 
                        id=item.id,
                        NameKala=item.Name,
                        count=1,
                        Price=item.Price,
                        UserName=comboUser.Text
                        
                        
                        };

                      
                        list.Add(orderViewModel);
                        
                        dataGridView2.DataSource = list.ToList();
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
            try
            {
                foreach (var item in list)
                {
                    Order order = new Order(item.count,item.id, id_combo);
                   
                    op_Order.AddData(order);
                }
                MessageBox.Show("ثبت نهایی انجام شد ");

                //new Form2(op_Order,op_Product,op_User).ShowDialog();
                new FrmOrders(db,op_Order,op_User).ShowDialog();
            }
            catch(Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private async void comboUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
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
            new Frm_Page_Add_Update(0,null, op_Product,this).ShowDialog();

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                Name = txtUser.Text,
                PhoneNumber=txtPhoneNumber.Text,
                Adres=txtAdres.Text
            };
            op_User.AddData(user);
            FrmStartup_Load(null, null);
        }

        private void  btnUpdate_Click(object sender, EventArgs e)
        {
            new Frm_Page_Add_Update(1, GetIdGridView(), op_Product,this).ShowDialog();
         
        }
        public int GetIdGridView()
        {
            int id = int.Parse( dataGridView1.CurrentRow.Cells[0].Value.ToString());
            return  id;
        }
        private async void btnDelete_Click(object sender, EventArgs e)
        {

           await op_Product.delete(GetIdGridView());
            FormLoad();
        }

        private async  void btnDeleteUser_Click(object sender, EventArgs e)
        {
           await op_User.delete((int)comboUser.SelectedValue);
            FormLoad();

        }

       
        private async void FormLoad()
        {
            try
            {
                dataGridView1.DataSource = await op_Product.GetList();
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

        private void btn_search_Click(object sender, EventArgs e)
        {
          var list=  db.Products.Where(x => x.Name.Contains(txtSearchName.Text));
            if(list!=null&&list.Any())
            dataGridView1.DataSource = list.ToList();
            else
            {
                MessageBox.Show("نتیجه ای یافت نشد");
            }
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
    }
}
