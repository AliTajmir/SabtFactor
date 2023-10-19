namespace WindowsFormsApp1
{
    partial class Form1
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
            this.btn_Sabt_order = new System.Windows.Forms.Button();
            this.comboUser = new System.Windows.Forms.ComboBox();
            this.btn_ShowOrders = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(937, 330);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_Sabt_order
            // 
            this.btn_Sabt_order.Location = new System.Drawing.Point(724, 360);
            this.btn_Sabt_order.Name = "btn_Sabt_order";
            this.btn_Sabt_order.Size = new System.Drawing.Size(176, 74);
            this.btn_Sabt_order.TabIndex = 1;
            this.btn_Sabt_order.Text = "اضافه کردن به سبد خرید";
            this.btn_Sabt_order.UseVisualStyleBackColor = true;
            this.btn_Sabt_order.Click += new System.EventHandler(this.btn_Sabt_order_Click);
            // 
            // comboUser
            // 
            this.comboUser.FormattingEnabled = true;
            this.comboUser.Location = new System.Drawing.Point(5, 342);
            this.comboUser.Name = "comboUser";
            this.comboUser.Size = new System.Drawing.Size(181, 24);
            this.comboUser.TabIndex = 2;
            this.comboUser.SelectedIndexChanged += new System.EventHandler(this.comboUser_SelectedIndexChanged);
            this.comboUser.SelectedValueChanged += new System.EventHandler(this.comboUser_SelectedValueChanged);
            // 
            // btn_ShowOrders
            // 
            this.btn_ShowOrders.Location = new System.Drawing.Point(508, 360);
            this.btn_ShowOrders.Name = "btn_ShowOrders";
            this.btn_ShowOrders.Size = new System.Drawing.Size(176, 74);
            this.btn_ShowOrders.TabIndex = 3;
            this.btn_ShowOrders.Text = "نمایش سفارشات";
            this.btn_ShowOrders.UseVisualStyleBackColor = true;
            this.btn_ShowOrders.Click += new System.EventHandler(this.btn_ShowOrders_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(948, 522);
            this.Controls.Add(this.btn_ShowOrders);
            this.Controls.Add(this.comboUser);
            this.Controls.Add(this.btn_Sabt_order);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Sabt_order;
        private System.Windows.Forms.ComboBox comboUser;
        private System.Windows.Forms.Button btn_ShowOrders;
    }
}

