namespace WindowsFormsApp1
{
    partial class Frm_OrderUsers
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
            this.btn_Up_dg = new DevComponents.DotNetBar.ButtonX();
            this.dataGridViewX1 = new Stimulsoft.Controls.Win.DotNetBar.Controls.DataGridViewX();
            this.label1 = new System.Windows.Forms.Label();
            this.combo_Search_UserName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSumPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Up_dg
            // 
            this.btn_Up_dg.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Up_dg.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Up_dg.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Up_dg.Location = new System.Drawing.Point(769, 351);
            this.btn_Up_dg.Name = "btn_Up_dg";
            this.btn_Up_dg.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 10, 10, 2);
            this.btn_Up_dg.Size = new System.Drawing.Size(252, 74);
            this.btn_Up_dg.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Up_dg.TabIndex = 17;
            this.btn_Up_dg.Text = "باز سازی لیست";
            this.btn_Up_dg.Click += new System.EventHandler(this.btn_Up_dg_Click);
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
            this.dataGridViewX1.Location = new System.Drawing.Point(66, 12);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewX1.RowHeadersWidth = 51;
            this.dataGridViewX1.RowTemplate.Height = 24;
            this.dataGridViewX1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewX1.Size = new System.Drawing.Size(955, 316);
            this.dataGridViewX1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 354);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "نام کاربری:";
            // 
            // combo_Search_UserName
            // 
            this.combo_Search_UserName.FormattingEnabled = true;
            this.combo_Search_UserName.Location = new System.Drawing.Point(114, 351);
            this.combo_Search_UserName.Name = "combo_Search_UserName";
            this.combo_Search_UserName.Size = new System.Drawing.Size(159, 24);
            this.combo_Search_UserName.TabIndex = 12;
            this.combo_Search_UserName.SelectedIndexChanged += new System.EventHandler(this.combo_Search_UserName_SelectedIndexChanged);
            this.combo_Search_UserName.SelectedValueChanged += new System.EventHandler(this.combo_Search_UserName_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 408);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = ":جمع قیمت کل سفارش ها";
            // 
            // lblSumPrice
            // 
            this.lblSumPrice.AutoSize = true;
            this.lblSumPrice.Location = new System.Drawing.Point(279, 408);
            this.lblSumPrice.Name = "lblSumPrice";
            this.lblSumPrice.Size = new System.Drawing.Size(20, 17);
            this.lblSumPrice.TabIndex = 19;
            this.lblSumPrice.Text = "...";
            // 
            // Frm_OrderUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 493);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSumPrice);
            this.Controls.Add(this.btn_Up_dg);
            this.Controls.Add(this.dataGridViewX1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combo_Search_UserName);
            this.Name = "Frm_OrderUsers";
            this.Text = "Frm_OrserUsers";
            this.Load += new System.EventHandler(this.Frm_OrderUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btn_Up_dg;
        private Stimulsoft.Controls.Win.DotNetBar.Controls.DataGridViewX dataGridViewX1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_Search_UserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSumPrice;
    }
}