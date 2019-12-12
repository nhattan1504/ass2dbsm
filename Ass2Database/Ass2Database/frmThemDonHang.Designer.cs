namespace Ass2Database
{
    partial class frmThemDonHang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaKhachHang = new System.Windows.Forms.TextBox();
            this.gbDSSanPham = new System.Windows.Forms.GroupBox();
            this.lvSanPham = new System.Windows.Forms.ListView();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnMuaHang = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.gbDSSanPham.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 67);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mua hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã khách hàng:";
            // 
            // txtMaKhachHang
            // 
            this.txtMaKhachHang.Location = new System.Drawing.Point(312, 97);
            this.txtMaKhachHang.Name = "txtMaKhachHang";
            this.txtMaKhachHang.Size = new System.Drawing.Size(378, 30);
            this.txtMaKhachHang.TabIndex = 2;
            // 
            // gbDSSanPham
            // 
            this.gbDSSanPham.Controls.Add(this.lvSanPham);
            this.gbDSSanPham.Location = new System.Drawing.Point(12, 150);
            this.gbDSSanPham.Name = "gbDSSanPham";
            this.gbDSSanPham.Size = new System.Drawing.Size(818, 317);
            this.gbDSSanPham.TabIndex = 3;
            this.gbDSSanPham.TabStop = false;
            this.gbDSSanPham.Text = "Danh sách sản phẩm:";
            // 
            // lvSanPham
            // 
            this.lvSanPham.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvSanPham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSanPham.FullRowSelect = true;
            this.lvSanPham.HideSelection = false;
            this.lvSanPham.Location = new System.Drawing.Point(3, 26);
            this.lvSanPham.Name = "lvSanPham";
            this.lvSanPham.Size = new System.Drawing.Size(812, 288);
            this.lvSanPham.TabIndex = 0;
            this.lvSanPham.UseCompatibleStateImageBehavior = false;
            this.lvSanPham.View = System.Windows.Forms.View.Details;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(167, 490);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(111, 39);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnMuaHang
            // 
            this.btnMuaHang.Location = new System.Drawing.Point(594, 490);
            this.btnMuaHang.Name = "btnMuaHang";
            this.btnMuaHang.Size = new System.Drawing.Size(111, 39);
            this.btnMuaHang.TabIndex = 4;
            this.btnMuaHang.Text = "Mua hàng";
            this.btnMuaHang.UseVisualStyleBackColor = true;
            this.btnMuaHang.Click += new System.EventHandler(this.btnMuaHang_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã sản phẩm";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên sản phẩm";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mã đối tác";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Giá niêm yết";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Số lượng trong kho";
            this.columnHeader5.Width = 200;
            // 
            // frmThemDonHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 541);
            this.Controls.Add(this.btnMuaHang);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.gbDSSanPham);
            this.Controls.Add(this.txtMaKhachHang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmThemDonHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm đơn hàng";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbDSSanPham.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaKhachHang;
        private System.Windows.Forms.GroupBox gbDSSanPham;
        private System.Windows.Forms.ListView lvSanPham;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnMuaHang;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}