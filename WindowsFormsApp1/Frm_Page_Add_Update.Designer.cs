namespace WindowsFormsApp1
{
    partial class Frm_Page_Add_Update
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.txtNameProduct = new System.Windows.Forms.TextBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Sabt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(413, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "تغداد";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(413, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "قیمت";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(413, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "نام کالا";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(214, 158);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(171, 37);
            this.txtPrice.TabIndex = 7;
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(214, 231);
            this.txtCount.Multiline = true;
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(171, 37);
            this.txtCount.TabIndex = 8;
            // 
            // txtNameProduct
            // 
            this.txtNameProduct.Location = new System.Drawing.Point(214, 85);
            this.txtNameProduct.Multiline = true;
            this.txtNameProduct.Name = "txtNameProduct";
            this.txtNameProduct.Size = new System.Drawing.Size(171, 37);
            this.txtNameProduct.TabIndex = 9;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(340, 318);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(102, 68);
            this.btn_Cancel.TabIndex = 13;
            this.btn_Cancel.Text = "انصراف";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Sabt
            // 
            this.btn_Sabt.Location = new System.Drawing.Point(214, 318);
            this.btn_Sabt.Name = "btn_Sabt";
            this.btn_Sabt.Size = new System.Drawing.Size(102, 68);
            this.btn_Sabt.TabIndex = 13;
            this.btn_Sabt.Text = "ثبت";
            this.btn_Sabt.UseVisualStyleBackColor = true;
            this.btn_Sabt.Click += new System.EventHandler(this.btn_Sabt_Click);
            // 
            // Frm_Page_Add_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 450);
            this.Controls.Add(this.btn_Sabt);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.txtNameProduct);
            this.Name = "Frm_Page_Add_Update";
            this.Text = "Frm_Page_Add_Update";
            this.Load += new System.EventHandler(this.Frm_Page_Add_Update_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.TextBox txtNameProduct;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Sabt;
    }
}