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
        private readonly Operation<Order> op_order;
        private readonly Operation<User> op_User;
        private  List<OrderViewModel> orderViewModels;
        public Form2(ContextDb _db, Operation<Order> _op_order,Operation<User> _op_User)
        {
            InitializeComponent();
            op_order = _op_order;
            op_User = _op_User;
            db = _db;
        }


        private async void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                orderViewModels = await GetListOrder(null);
                combo_Search_UserName.DataSource = await op_User.GetList();
                combo_Search_UserName.DisplayMember = "Name";
                combo_Search_UserName.ValueMember = "id";
                if (orderViewModels != null && orderViewModels.Any())
                {
                    dataGridView1.DataSource = orderViewModels;
                }
                else
                {
                    MessageBox.Show("دیتا یافت نشد");
                }
                SetName_DataGridView();
            }
            catch(Exception er)
            {
                MessageBox.Show(er.Message,"error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        public async Task<List<OrderViewModel>> GetListOrder(int? User_id)
        {
           
            try
            {
                if (User_id ==null)
                {
                    orderViewModels = await db.Order
              .Include(o => o.Products).Include(o => o.User).Select(o => new OrderViewModel
              {
                  id = o.id,
                  NameKala = o.Products.Name,
                  count = o.Count,
                  Price = o.Products.Price,
                  UserName = o.User.Name
              }).ToListAsync();
                }
               else
                {
                    orderViewModels = await db.Order.Where(x => x.User_id == User_id.Value).Include(x => x.Products).Include(x => x.User).Select(x => new OrderViewModel()
                    {
                        id = x.id,
                        NameKala = x.Products.Name,
                        count = x.Count,
                        Price = x.Products.Price,
                        UserName = x.User.Name

                    }).ToListAsync();


                }

                


                return orderViewModels;
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
            dataGridView1.Columns[2].HeaderText = "نام کاربر";
            dataGridView1.Columns[3].HeaderText = "قیمت";
            dataGridView1.Columns[4].HeaderText = "تعداد کالا";
            dataGridView1.Columns[5].HeaderText = "قیمت کل";
        }
        private int GetIdDataGridView()
        {
            var id =int.Parse( dataGridView1.CurrentRow.Cells[0].Value.ToString());
            return  id;

        }
       
        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            op_order.delete(GetIdDataGridView());
            Form2_Load(null,null);
        }

        private async void combo_Search_UserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = (int)combo_Search_UserName.SelectedValue;
                orderViewModels = await GetListOrder(id);
                dataGridView1.DataSource = orderViewModels;



            }
            catch(Exception er)
            {
                MessageBox.Show(er.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private async void btn_Up_dg_Click(object sender, EventArgs e)
        {

            orderViewModels =await GetListOrder(null);
            dataGridView1.DataSource = orderViewModels;
        }

        private void btnChange_order_Click(object sender, EventArgs e)
        {
            Order item = db.Order.Find(GetIdDataGridView());
            item.Count =int.Parse( numericUpDown1.Value.ToString());
            db.SaveChanges();
            Form2_Load(null, null);
        }
    }
}
