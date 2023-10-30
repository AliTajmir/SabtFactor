
using Grpc.Core;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Stripe;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading.Tasks;
using System.Windows.Forms;
using Document = System.Reflection.Metadata.Document;

namespace WindowsFormsApp1
{
    public  partial class FrmOrders : Form
    {
        private  ContextDb db;
        private  Operation<Order> op_order;
        private  Operation<User> op_User;
        private  List<OrderViewModel> orderViewModels;
        private FrmStartup frmStartup;
        public FrmOrders(ContextDb _db, Operation<Order> _op_order,Operation<User> _op_User,List<OrderViewModel> _orderViewModels,FrmStartup _frmStartup)
        {
            InitializeComponent();
            op_order = _op_order;
            op_User = _op_User;
            db = _db;
            orderViewModels = _orderViewModels;
            frmStartup = _frmStartup;
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
            dataGridViewX1.Columns[7].Visible = false;
            dataGridViewX1.Columns[8].HeaderText = "قیمت کل";
        }
        private int GetIdDataGridView()
        {
            int id =int.Parse(dataGridViewX1.CurrentRow.Cells[0].Value.ToString());
            return  id;

        }
       
      

       

      

     public  void SumPriceOrders( List<OrderViewModel> orderViewModels)
        {
            var Sum = orderViewModels.Sum(x => x.Total).ToString();
            lblSumPrice.Text= Sum;
        }

       

        private  void FrmOrders_Load(object sender, EventArgs e)
        {
            dataGridViewX1.DataSource = orderViewModels.ToList();
            SetName_DataGridView();
        }

     

        private  void btnChange_Count_order_Click_1(object sender, EventArgs e)
        {
            var id = GetIdDataGridView();
            var item = db.Products.Find(id);
            if (item.Count >= numericUpDown1.Value)
            {
                var item2 = orderViewModels.Find(x => x.id == id);

                item2.count = int.Parse( numericUpDown1.Value.ToString());
                
            }
            else
            {
                MessageBox.Show("عدد بزرگتر از تعداد کالا است");
            }

            SumPriceOrders(orderViewModels);
            FrmOrders_Load(null, null);
           
        }

        private  void btnDeleteOrder_Click_1(object sender, EventArgs e)
        {
            var item = orderViewModels.Find(x => x.id == GetIdDataGridView());
            
            var check =  orderViewModels.Remove(item);
            if (check != true)
                MessageBox.Show("رکوردی برای حذف وجود ندارد");
            else
                MessageBox.Show("یک رکورد حذف گردید");


            FrmOrders_Load(null, null);
        }

       
        private async void Subtract_From_Count_Product()
        {
foreach(var item in orderViewModels)
            {
                Order order = new Order()
                {
                    Count=item.count,
                    Product_id=item.Kala_Id,
                    User_id=item.User_Id,
                    CreateDate=DateTime.Now.ToShamsi()
                };
                await op_order.AddData(order);
               var i=await db.Products.FindAsync(item.id);
                i.Count -= item.count;
                db.SaveChanges();
            }
        }
        private void btn_Print_Click(object sender, EventArgs e)
        {
            Subtract_From_Count_Product();
            orderViewModels.ToPdf();

                  

                

              
        }


    

        private void btn_Go_to_Page_OrderUsers_Click(object sender, EventArgs e)
        {
            new Frm_OrderUsers(db, op_User).ShowDialog();
        }

        private  void FrmOrders_FormClosed(object sender, FormClosedEventArgs e)
        {
           frmStartup.FormLoad();
            

        }

       
    }
    
}
