namespace WindowsFormsApp1
{
    partial class FrmOrders
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSumPrice = new System.Windows.Forms.Label();
            this.btnChange_Count_order = new DevComponents.DotNetBar.ButtonX();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewX1 = new Stimulsoft.Controls.Win.DotNetBar.Controls.DataGridViewX();
            this.btn_Print = new DevComponents.DotNetBar.ButtonX();
            this.btnDeleteOrder = new DevComponents.DotNetBar.ButtonX();
            this.btn_Go_to_Page_OrderUsers = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(6, 31);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblSumPrice);
            this.groupBox1.Controls.Add(this.btnChange_Count_order);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Location = new System.Drawing.Point(6, 359);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 162);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 117);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = ":جمع قیمت کل سفارش ها";
            // 
            // lblSumPrice
            // 
            this.lblSumPrice.AutoSize = true;
            this.lblSumPrice.Location = new System.Drawing.Point(169, 117);
            this.lblSumPrice.Name = "lblSumPrice";
            this.lblSumPrice.Size = new System.Drawing.Size(20, 17);
            this.lblSumPrice.TabIndex = 5;
            this.lblSumPrice.Text = "...";
            // 
            // btnChange_Count_order
            // 
            this.btnChange_Count_order.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnChange_Count_order.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnChange_Count_order.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange_Count_order.Location = new System.Drawing.Point(265, 82);
            this.btnChange_Count_order.Name = "btnChange_Count_order";
            this.btnChange_Count_order.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 10, 10, 2);
            this.btnChange_Count_order.Size = new System.Drawing.Size(127, 68);
            this.btnChange_Count_order.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnChange_Count_order.TabIndex = 11;
            this.btnChange_Count_order.Text = "تغییر تعداد سفارش";
            this.btnChange_Count_order.Click += new System.EventHandler(this.btnChange_Count_order_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "تعداد کالای سفارش داده شده";
            // 
            // dataGridViewX1
            // 
            this.dataGridViewX1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridViewX1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewX1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX1.Location = new System.Drawing.Point(6, 12);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewX1.RowHeadersWidth = 51;
            this.dataGridViewX1.RowTemplate.Height = 24;
            this.dataGridViewX1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewX1.Size = new System.Drawing.Size(1081, 316);
            this.dataGridViewX1.TabIndex = 7;
            // 
            // btn_Print
            // 
            this.btn_Print.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Print.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Print.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Print.Location = new System.Drawing.Point(410, 338);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 10, 10, 2);
            this.btn_Print.Size = new System.Drawing.Size(419, 74);
            this.btn_Print.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Print.TabIndex = 11;
            this.btn_Print.Text = "ثبت نهایی و چاپ";
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDeleteOrder.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDeleteOrder.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteOrder.Location = new System.Drawing.Point(835, 338);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 10, 10, 2);
            this.btnDeleteOrder.Size = new System.Drawing.Size(252, 74);
            this.btnDeleteOrder.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDeleteOrder.TabIndex = 11;
            this.btnDeleteOrder.Text = "حذف سفارش";
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click_1);
            // 
            // btn_Go_to_Page_OrderUsers
            // 
            this.btn_Go_to_Page_OrderUsers.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Go_to_Page_OrderUsers.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Go_to_Page_OrderUsers.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Go_to_Page_OrderUsers.Location = new System.Drawing.Point(410, 435);
            this.btn_Go_to_Page_OrderUsers.Name = "btn_Go_to_Page_OrderUsers";
            this.btn_Go_to_Page_OrderUsers.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 10, 10, 2);
            this.btn_Go_to_Page_OrderUsers.Size = new System.Drawing.Size(677, 74);
            this.btn_Go_to_Page_OrderUsers.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Go_to_Page_OrderUsers.TabIndex = 11;
            this.btn_Go_to_Page_OrderUsers.Text = "رفتن به صفحه سفارشات مشتری ها";
            this.btn_Go_to_Page_OrderUsers.Click += new System.EventHandler(this.btn_Go_to_Page_OrderUsers_Click);
            // 
            // FrmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1093, 527);
            this.Controls.Add(this.btnDeleteOrder);
            this.Controls.Add(this.btn_Go_to_Page_OrderUsers);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.dataGridViewX1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmOrders";
            this.Text = "Form2";
            
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmOrders_FormClosed);
            this.Load += new System.EventHandler(this.FrmOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSumPrice;
        private System.Windows.Forms.Label label2;
        
        private Stimulsoft.Controls.Win.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private DevComponents.DotNetBar.ButtonX btn_Print;
        private DevComponents.DotNetBar.ButtonX btnChange_Count_order;
        private DevComponents.DotNetBar.ButtonX btnDeleteOrder;
        private DevComponents.DotNetBar.ButtonX btn_Go_to_Page_OrderUsers;
    }
}