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
    public partial class Frm_Page_Add_Update : Form
    {
        
        private int num;
        private int? id;
        private Operation<Products> op_Product;
        private FrmStartup Frm;
        public Frm_Page_Add_Update(int _Num,int? _id, Operation<Products> _op_Product,FrmStartup _frm)
        {
            InitializeComponent();
            
            num = _Num;
            id = _id;
            Frm = _frm;
            op_Product = _op_Product;
           
        }

        private async void Frm_Page_Add_Update_Load(object sender, EventArgs e)
        {
            if (id != null)
            {
                Products products = await op_Product.GetItem(id.Value);
                txtNameProduct.Text = products.Name;
                txtCount.Text = products.Count.ToString();
                txtPrice.Text = products.Price.ToString();
            }
           
        }

     

        private void btn_Cancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btn_Sabt_Click_1(object sender, EventArgs e)
        {
            if (num == 0)
            {
                Products products = new Products()
                {
                    Name = txtNameProduct.Text,
                    Price = int.Parse(txtPrice.Text),
                    Count = int.Parse(txtCount.Text),

                };

                var check = await op_Product.AddData(products);
                if (check == true)
                {
                    MessageBox.Show("کالا با موفقیت ثبت شد");

                    this.Close();
                    Frm.FrmStartup_Load(null, null);
                }
                else
                {
                    MessageBox.Show("مشکلی در ثبت کالا به وجود آمد");
                }



            }
            else
            {
                Products products = await op_Product.GetItem(id.Value);
                products.Name = txtNameProduct.Text;
                products.Price = int.Parse(txtPrice.Text);
                products.Count = int.Parse(txtCount.Text);

                bool check = op_Product.Up(products);
                if (check == true)
                {
                    MessageBox.Show("کالا با موفقیت آپدیت شد");
                    this.Close();
                    Frm.FrmStartup_Load(null, null);

                }
                else
                {
                    MessageBox.Show("مشکلی در آپدیت به وجود آمد");
                }

            }
        }
    }
}
