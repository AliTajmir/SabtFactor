using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
namespace WindowsFormsApp1
{
    public partial class Frm_OrderUsers : Form
    {
        List<OrderViewModel> list;
        Operation<User> op_User;
        ContextDb db;
        public Frm_OrderUsers(ContextDb _db,Operation<User> _op_User)
        {
            InitializeComponent();
            db = _db;
            op_User = _op_User;
        }

        private async void Frm_OrderUsers_Load(object sender, EventArgs e)
        {
            try
            {
                if (combo_Search_UserName.Items.Count == 0)
                {
                    combo_Search_UserName.DataSource = await op_User.GetList();
                    combo_Search_UserName.DisplayMember = "Name";
                    combo_Search_UserName.ValueMember = "id";
                }

                
                dataGridViewX1.DataSource = GetListOrder(null);

                SetName_DataGridView();

            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SetName_DataGridView()
        {
            dataGridViewX1.Columns[0].HeaderText = "شماره سفارش";
            dataGridViewX1.Columns[1].HeaderText = "نام کالا";
            dataGridViewX1.Columns[2].HeaderText = "نام کاربر";
            dataGridViewX1.Columns[3].HeaderText = "قیمت";
            dataGridViewX1.Columns[4].HeaderText = "تعداد کالا";
            dataGridViewX1.Columns[5].Visible = false;
            dataGridViewX1.Columns[6].Visible = false;
            dataGridViewX1.Columns[7].HeaderText = "قیمت کل";
        }
        public async Task<List<OrderViewModel>> GetListOrder(int? User_id)
        {
            //orderViewModels.Clear();
            try
            {
                if (User_id == null)
                {
                    list = await db.Order
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
                    list = await db.Order.Where(x => x.User_id == User_id.Value).Include(x => x.Products).Include(x => x.User).Select(x => new OrderViewModel()
                    {
                        id = x.id,
                        NameKala = x.Products.Name,
                        count = x.Count,
                        Price = x.Products.Price,
                        UserName = x.User.Name

                    }).ToListAsync();


                }




                return list;
            }
            catch
            {
                return null;
            }
        }
        private async void btn_Up_dg_Click(object sender, EventArgs e)
        {
            list = await GetListOrder(null);
            dataGridViewX1.DataSource = list;
            new FrmOrders(null, null, null, null).SumPriceOrders(list);
        }

        private async void combo_Search_UserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = (int)combo_Search_UserName.SelectedValue;
                
                dataGridViewX1.DataSource =await GetListOrder(id);
                new FrmOrders(null, null, null, null).SumPriceOrders(list);


            }
            catch
            {

            }
        }
    }
}
