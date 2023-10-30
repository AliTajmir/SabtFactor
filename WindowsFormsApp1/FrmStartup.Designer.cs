namespace WindowsFormsApp1
{
    partial class FrmStartup
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboUser = new System.Windows.Forms.ComboBox();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Empty_txt = new DevComponents.DotNetBar.ButtonX();
            this.btnAddUser = new DevComponents.DotNetBar.ButtonX();
            this.btnDeleteUser = new DevComponents.DotNetBar.ButtonX();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_search = new DevComponents.DotNetBar.ButtonX();
            this.dataGridViewX1 = new Stimulsoft.Controls.Win.DotNetBar.Controls.DataGridViewX();
            this.dataGridViewX2 = new Stimulsoft.Controls.Win.DotNetBar.Controls.DataGridViewX();
            this.btn_ShowOrders = new DevComponents.DotNetBar.ButtonX();
            this.btn_Sabt_order = new DevComponents.DotNetBar.ButtonX();
            this.btnDelete_Pish_Factor = new DevComponents.DotNetBar.ButtonX();
            this.btnDelete = new DevComponents.DotNetBar.ButtonX();
            this.btnUpdate = new DevComponents.DotNetBar.ButtonX();
            this.btnSabt = new DevComponents.DotNetBar.ButtonX();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX2)).BeginInit();
            this.SuspendLayout();
            // 
            // comboUser
            // 
            this.comboUser.FormattingEnabled = true;
            this.comboUser.Location = new System.Drawing.Point(121, 38);
            this.comboUser.Name = "comboUser";
            this.comboUser.Size = new System.Drawing.Size(262, 24);
            this.comboUser.TabIndex = 2;
            this.comboUser.SelectedIndexChanged += new System.EventHandler(this.comboUser_SelectedIndexChanged);
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(6, 33);
            this.txtSearchName.Multiline = true;
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(171, 37);
            this.txtSearchName.TabIndex = 4;
            this.txtSearchName.TextChanged += new System.EventHandler(this.txtSearchName_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Empty_txt);
            this.groupBox1.Controls.Add(this.btnAddUser);
            this.groupBox1.Controls.Add(this.btnDeleteUser);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAdres);
            this.groupBox1.Controls.Add(this.txtPhoneNumber);
            this.groupBox1.Controls.Add(this.txtUser);
            this.groupBox1.Controls.Add(this.comboUser);
            this.groupBox1.Location = new System.Drawing.Point(5, 342);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(571, 321);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "قسمت کاربران";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_Empty_txt
            // 
            this.btn_Empty_txt.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Empty_txt.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Empty_txt.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Empty_txt.Location = new System.Drawing.Point(420, 176);
            this.btn_Empty_txt.Name = "btn_Empty_txt";
            this.btn_Empty_txt.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 10, 10, 2);
            this.btn_Empty_txt.Size = new System.Drawing.Size(145, 62);
            this.btn_Empty_txt.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Empty_txt.TabIndex = 10;
            this.btn_Empty_txt.Text = "خالی کردن ";
            this.btn_Empty_txt.Click += new System.EventHandler(this.btn_Empty_txt_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddUser.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddUser.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.Location = new System.Drawing.Point(420, 108);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 10, 10, 2);
            this.btnAddUser.Size = new System.Drawing.Size(145, 62);
            this.btnAddUser.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddUser.TabIndex = 10;
            this.btnAddUser.Text = "اضافه کردن کاربر";
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click_1);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDeleteUser.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDeleteUser.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteUser.Location = new System.Drawing.Point(420, 38);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 10, 10, 2);
            this.btnDeleteUser.Size = new System.Drawing.Size(145, 62);
            this.btnDeleteUser.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDeleteUser.TabIndex = 10;
            this.btnDeleteUser.Text = "حذف کاربر";
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 41);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(49, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "کاربران:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 93);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "نام کاربر:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 225);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(40, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "آدرس:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 155);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "شماره تماس:";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(120, 199);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(263, 116);
            this.txtAdres.TabIndex = 4;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(120, 145);
            this.txtPhoneNumber.Multiline = true;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(263, 37);
            this.txtPhoneNumber.TabIndex = 4;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(121, 86);
            this.txtUser.Multiline = true;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(262, 37);
            this.txtUser.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "نام کالا";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_search);
            this.groupBox2.Controls.Add(this.txtSearchName);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(598, 351);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(280, 173);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "جستجو";
            // 
            // btn_search
            // 
            this.btn_search.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_search.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_search.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(15, 89);
            this.btn_search.Name = "btn_search";
            this.btn_search.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 10, 10, 2);
            this.btn_search.Size = new System.Drawing.Size(252, 74);
            this.btn_search.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_search.TabIndex = 10;
            this.btn_search.Text = "جستجوی کالا";
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click_1);
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
            this.dataGridViewX1.Location = new System.Drawing.Point(17, 16);
            this.dataGridViewX1.Name = "dataGridViewX1";
            this.dataGridViewX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewX1.RowHeadersWidth = 51;
            this.dataGridViewX1.RowTemplate.Height = 24;
            this.dataGridViewX1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewX1.Size = new System.Drawing.Size(1140, 298);
            this.dataGridViewX1.TabIndex = 10;
            // 
            // dataGridViewX2
            // 
            this.dataGridViewX2.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridViewX2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewX2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewX2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dataGridViewX2.Location = new System.Drawing.Point(884, 435);
            this.dataGridViewX2.Name = "dataGridViewX2";
            this.dataGridViewX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridViewX2.RowHeadersWidth = 51;
            this.dataGridViewX2.RowTemplate.Height = 24;
            this.dataGridViewX2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewX2.Size = new System.Drawing.Size(273, 238);
            this.dataGridViewX2.TabIndex = 10;
            // 
            // btn_ShowOrders
            // 
            this.btn_ShowOrders.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_ShowOrders.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_ShowOrders.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ShowOrders.Location = new System.Drawing.Point(598, 530);
            this.btn_ShowOrders.Name = "btn_ShowOrders";
            this.btn_ShowOrders.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 10, 10, 2);
            this.btn_ShowOrders.Size = new System.Drawing.Size(147, 74);
            this.btn_ShowOrders.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_ShowOrders.TabIndex = 10;
            this.btn_ShowOrders.Text = "ثبت نهایی و رفتن به صفحه فاکتور";
            this.btn_ShowOrders.Click += new System.EventHandler(this.btn_ShowOrders_Click_1);
            // 
            // btn_Sabt_order
            // 
            this.btn_Sabt_order.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btn_Sabt_order.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btn_Sabt_order.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sabt_order.Location = new System.Drawing.Point(751, 530);
            this.btn_Sabt_order.Name = "btn_Sabt_order";
            this.btn_Sabt_order.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 10, 10, 2);
            this.btn_Sabt_order.Size = new System.Drawing.Size(127, 74);
            this.btn_Sabt_order.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btn_Sabt_order.TabIndex = 10;
            this.btn_Sabt_order.Text = "اضافه کردن پیش فاکتور";
            this.btn_Sabt_order.Click += new System.EventHandler(this.btn_Sabt_order_Click_1);
            // 
            // btnDelete_Pish_Factor
            // 
            this.btnDelete_Pish_Factor.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelete_Pish_Factor.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDelete_Pish_Factor.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete_Pish_Factor.Location = new System.Drawing.Point(598, 610);
            this.btnDelete_Pish_Factor.Name = "btnDelete_Pish_Factor";
            this.btnDelete_Pish_Factor.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 10, 10, 2);
            this.btnDelete_Pish_Factor.Size = new System.Drawing.Size(280, 53);
            this.btnDelete_Pish_Factor.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDelete_Pish_Factor.TabIndex = 10;
            this.btnDelete_Pish_Factor.Text = "حذف پیش فاکتور";
            this.btnDelete_Pish_Factor.Click += new System.EventHandler(this.btnDelete_Pish_Factor_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDelete.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDelete.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(884, 355);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 10, 10, 2);
            this.btnDelete.Size = new System.Drawing.Size(69, 74);
            this.btnDelete.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "حذف";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnUpdate.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnUpdate.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(978, 355);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 10, 10, 2);
            this.btnUpdate.Size = new System.Drawing.Size(69, 74);
            this.btnUpdate.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "ویرایش";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click_2);
            // 
            // btnSabt
            // 
            this.btnSabt.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSabt.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSabt.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSabt.Location = new System.Drawing.Point(1071, 355);
            this.btnSabt.Name = "btnSabt";
            this.btnSabt.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2, 10, 10, 2);
            this.btnSabt.Size = new System.Drawing.Size(66, 74);
            this.btnSabt.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSabt.TabIndex = 10;
            this.btnSabt.Text = "ثبت کالا";
            this.btnSabt.Click += new System.EventHandler(this.btnSabt_Click_1);
            // 
            // FrmStartup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1169, 675);
            this.Controls.Add(this.btnDelete_Pish_Factor);
            this.Controls.Add(this.btn_Sabt_order);
            this.Controls.Add(this.btnSabt);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btn_ShowOrders);
            this.Controls.Add(this.dataGridViewX2);
            this.Controls.Add(this.dataGridViewX1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmStartup";
            
            this.Load += new System.EventHandler(this.FrmStartup_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboUser;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Stimulsoft.Controls.Win.DotNetBar.Controls.DataGridViewX dataGridViewX2;
        private DevComponents.DotNetBar.ButtonX btnDeleteUser;
        private DevComponents.DotNetBar.ButtonX btnAddUser;
        private DevComponents.DotNetBar.ButtonX btn_search;
        private DevComponents.DotNetBar.ButtonX btn_ShowOrders;
        private DevComponents.DotNetBar.ButtonX btn_Sabt_order;
        private DevComponents.DotNetBar.ButtonX btnDelete_Pish_Factor;
        private DevComponents.DotNetBar.ButtonX btnDelete;
        private DevComponents.DotNetBar.ButtonX btnUpdate;
        private DevComponents.DotNetBar.ButtonX btnSabt;
        private DevComponents.DotNetBar.ButtonX btn_Empty_txt;
        private Stimulsoft.Controls.Win.DotNetBar.Controls.DataGridViewX dataGridViewX1;
    }
}

