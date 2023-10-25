using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmOrders : Form
    {
        private readonly ContextDb db;
        private Operation<Order> op_order;
        private readonly Operation<User> op_User;
        private  List<OrderViewModel> orderViewModels;
        public FrmOrders(ContextDb _db, Operation<Order> _op_order,Operation<User> _op_User)
        {
            InitializeComponent();
            op_order = _op_order;
            op_User = _op_User;
            db = _db;
        }


      

        public async Task<List<OrderViewModel>> GetListOrder(int? User_id)
        {
            //orderViewModels.Clear();
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
            dataGridViewX1.Columns[0].HeaderText = "شماره سفارش";
            dataGridViewX1.Columns[1].HeaderText = "نام کالا";
            dataGridViewX1.Columns[2].HeaderText = "نام کاربر";
            dataGridViewX1.Columns[3].HeaderText = "قیمت";
            dataGridViewX1.Columns[4].HeaderText = "تعداد کالا";
            dataGridViewX1.Columns[5].HeaderText = "قیمت کل";
        }
        private int GetIdDataGridView()
        {
            int id =int.Parse(dataGridViewX1.CurrentRow.Cells[0].Value.ToString());
            return  id;

        }
       
      

        private async void combo_Search_UserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = (int)combo_Search_UserName.SelectedValue;
                orderViewModels = await GetListOrder(id);
                dataGridViewX1.DataSource = orderViewModels.ToList();



            }
            catch
            {
                
            }
            
        }

      

     

       

        private async void FrmOrders_Load(object sender, EventArgs e)
        {
            try
            {
                if (combo_Search_UserName.Items.Count == 0)
                {
                    combo_Search_UserName.DataSource = await op_User.GetList();
                    combo_Search_UserName.DisplayMember = "Name";
                    combo_Search_UserName.ValueMember = "id";
                }
                orderViewModels = await GetListOrder(null);

                dataGridViewX1.DataSource = orderViewModels;
                SetName_DataGridView();

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     

        private async void btnChange_Count_order_Click_1(object sender, EventArgs e)
        {
            Order item =await op_order.GetItem(GetIdDataGridView());
            item.Count = int.Parse(numericUpDown1.Value.ToString());
            var check = op_order.Up(item);
            FrmOrders_Load(null, null);
        }

        private async void btnDeleteOrder_Click_1(object sender, EventArgs e)
        {
            var check = await op_order.delete(GetIdDataGridView());
            if (check != null)
                MessageBox.Show(check.Message);
            else
                MessageBox.Show("یک رکورد حذف گردید");


            FrmOrders_Load(null, null);
        }

        private async void btn_Up_dg_Click_1(object sender, EventArgs e)
        {
            orderViewModels = await GetListOrder(null);
            dataGridViewX1.DataSource = orderViewModels;
        }

      

      
    }
}
