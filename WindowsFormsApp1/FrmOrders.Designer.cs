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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.combo_Search_UserName = new System.Windows.Forms.ComboBox();
            this.btn_Up_dg = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnChange_Count_order = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1081, 341);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.Location = new System.Drawing.Point(888, 359);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(199, 82);
            this.btnDeleteOrder.TabIndex = 1;
            this.btnDeleteOrder.Text = "حذف سفارش";
            this.btnDeleteOrder.UseVisualStyleBackColor = true;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // combo_Search_UserName
            // 
            this.combo_Search_UserName.FormattingEnabled = true;
            this.combo_Search_UserName.Location = new System.Drawing.Point(419, 368);
            this.combo_Search_UserName.Name = "combo_Search_UserName";
            this.combo_Search_UserName.Size = new System.Drawing.Size(159, 24);
            this.combo_Search_UserName.TabIndex = 2;
            this.combo_Search_UserName.SelectedIndexChanged += new System.EventHandler(this.combo_Search_UserName_SelectedIndexChanged);
            // 
            // btn_Up_dg
            // 
            this.btn_Up_dg.Location = new System.Drawing.Point(888, 447);
            this.btn_Up_dg.Name = "btn_Up_dg";
            this.btn_Up_dg.Size = new System.Drawing.Size(199, 68);
            this.btn_Up_dg.TabIndex = 1;
            this.btn_Up_dg.Text = "باز سازی لیست";
            this.btn_Up_dg.UseVisualStyleBackColor = true;
            this.btn_Up_dg.Click += new System.EventHandler(this.btn_Up_dg_Click);
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
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnChange_Count_order);
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
            this.label3.Location = new System.Drawing.Point(6, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "قیمت:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(46, 88);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(20, 17);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "...";
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
            // btnChange_Count_order
            // 
            this.btnChange_Count_order.Location = new System.Drawing.Point(153, 72);
            this.btnChange_Count_order.Name = "btnChange_Count_order";
            this.btnChange_Count_order.Size = new System.Drawing.Size(199, 68);
            this.btnChange_Count_order.TabIndex = 1;
            this.btnChange_Count_order.Text = "تغییر تعداد سفارش";
            this.btnChange_Count_order.UseVisualStyleBackColor = true;
            this.btnChange_Count_order.Click += new System.EventHandler(this.btnChange_Count_order_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(600, 371);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "نام کاربری:";
            // 
            // FrmOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1093, 527);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.combo_Search_UserName);
            this.Controls.Add(this.btn_Up_dg);
            this.Controls.Add(this.btnDeleteOrder);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmOrders";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FrmOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.ComboBox combo_Search_UserName;
        private System.Windows.Forms.Button btn_Up_dg;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChange_Count_order;
    }
}