using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
        public Frm_OrderUsers(ContextDb _db, Operation<User> _op_User)
        {
            InitializeComponent();
            db = _db;
            op_User = _op_User;

        }

        private async void Frm_OrderUsers_Load(object sender, EventArgs e)
        {
            dataGridViewX1.DataSource = await GetListOrder(null);
            SetName_DataGridView();
            try
            {

                combo_Search_UserName.DataSource = await op_User.GetList();
                combo_Search_UserName.DisplayMember = "Name";
                combo_Search_UserName.ValueMember = "id";
                

                var items= list.Select(x => x.CreateDate).Distinct().ToList();
                combo_Search_Date.DataSource = items;
                combo_Search_Date.DisplayMember = "CreateDate";
                combo_Search_Date.ValueMember = "id";
                

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
            dataGridViewX1.Columns[7].HeaderText = "تاریخ ایجاد سفارش";
            dataGridViewX1.Columns[8].HeaderText = "قیمت کل";
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
                  UserName = o.User.Name,
                  CreateDate = o.CreateDate

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
                        UserName = x.User.Name,
                        CreateDate = x.CreateDate
                    }).ToListAsync();


                }




                return list;
            }
            catch
            {
                return null;
            }
        }
        private  void btn_Up_dg_Click(object sender, EventArgs e)
        {
            Frm_OrderUsers_Load(null, null);
            new FrmOrders(null, null, null, null, null).SumPriceOrders(list);
        }

        private async void combo_Search_UserName_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int id = (int)combo_Search_UserName.SelectedValue;

                dataGridViewX1.DataSource = await GetListOrder(id);
                new FrmOrders(null, null, null, null, null).SumPriceOrders(list);


            }
            catch
            {

            }
        }

        private  void combo_Search_Date_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int id = (int)combo_Search_UserName.SelectedValue;
           
           
            dataGridViewX1.DataSource = list.Where(x => x.CreateDate == combo_Search_Date.Text).ToList();
          

        }
    }
}
