namespace Ass2Database
{
    partial class frmNhapSoLuong
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMasanpham = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTensanpham = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNguoiban = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnHoantat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sản phẩm:";
            // 
            // txtMasanpham
            // 
            this.txtMasanpham.Location = new System.Drawing.Point(230, 33);
            this.txtMasanpham.Name = "txtMasanpham";
            this.txtMasanpham.ReadOnly = true;
            this.txtMasanpham.Size = new System.Drawing.Size(275, 30);
            this.txtMasanpham.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên sản phẩm:";
            // 
            // txtTensanpham
            // 
            this.txtTensanpham.Location = new System.Drawing.Point(230, 69);
            this.txtTensanpham.Name = "txtTensanpham";
            this.txtTensanpham.ReadOnly = true;
            this.txtTensanpham.Size = new System.Drawing.Size(275, 30);
            this.txtTensanpham.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Người bán:";
            // 
            // txtNguoiban
            // 
            this.txtNguoiban.Location = new System.Drawing.Point(230, 105);
            this.txtNguoiban.Name = "txtNguoiban";
            this.txtNguoiban.ReadOnly = true;
            this.txtNguoiban.Size = new System.Drawing.Size(275, 30);
            this.txtNguoiban.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nhập số lượng:";
            // 
            // txtSoluong
            // 
            this.txtSoluong.Location = new System.Drawing.Point(230, 141);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(275, 30);
            this.txtSoluong.TabIndex = 1;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(95, 202);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(132, 38);
            this.btnHuy.TabIndex = 2;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnHoantat
            // 
            this.btnHoantat.Location = new System.Drawing.Point(360, 202);
            this.btnHoantat.Name = "btnHoantat";
            this.btnHoantat.Size = new System.Drawing.Size(132, 38);
            this.btnHoantat.TabIndex = 2;
            this.btnHoantat.Text = "Hoàn tất";
            this.btnHoantat.UseVisualStyleBackColor = true;
            this.btnHoantat.Click += new System.EventHandler(this.btnHoantat_Click);
            // 
            // frmNhapSoLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 270);
            this.Controls.Add(this.btnHoantat);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.txtSoluong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNguoiban);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTensanpham);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMasanpham);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmNhapSoLuong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập số lượng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMasanpham;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTensanpham;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNguoiban;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnHoantat;
    }
}