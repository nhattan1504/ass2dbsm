namespace Ass2Database
{
    partial class frmThemDoiTacSanPham
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHoantat = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lvSanpham = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnThemsanpham = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.dtpNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMasokinhdoanh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTencuahang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMadoitac = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSodienthoai = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 52);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập thông tin đối tác";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtSodienthoai);
            this.panel2.Controls.Add(this.btnHoantat);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnThemsanpham);
            this.panel2.Controls.Add(this.btnDong);
            this.panel2.Controls.Add(this.dtpNgaysinh);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtDiachi);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtMasokinhdoanh);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtHoten);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtTencuahang);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtMadoitac);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(837, 611);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnHoantat
            // 
            this.btnHoantat.Location = new System.Drawing.Point(562, 563);
            this.btnHoantat.Name = "btnHoantat";
            this.btnHoantat.Size = new System.Drawing.Size(118, 36);
            this.btnHoantat.TabIndex = 10;
            this.btnHoantat.Text = "Hoàn tất";
            this.btnHoantat.UseVisualStyleBackColor = true;
            this.btnHoantat.Click += new System.EventHandler(this.btnHoantat_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lvSanpham);
            this.panel3.Location = new System.Drawing.Point(6, 368);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(831, 189);
            this.panel3.TabIndex = 9;
            // 
            // lvSanpham
            // 
            this.lvSanpham.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvSanpham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSanpham.FullRowSelect = true;
            this.lvSanpham.HideSelection = false;
            this.lvSanpham.Location = new System.Drawing.Point(0, 0);
            this.lvSanpham.Name = "lvSanpham";
            this.lvSanpham.Size = new System.Drawing.Size(831, 189);
            this.lvSanpham.TabIndex = 0;
            this.lvSanpham.UseCompatibleStateImageBehavior = false;
            this.lvSanpham.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã sản phẩm";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên sản phẩm";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Xuất xứ";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Giá niêm yết";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Loại sản phẩm";
            this.columnHeader5.Width = 200;
            // 
            // btnThemsanpham
            // 
            this.btnThemsanpham.Location = new System.Drawing.Point(332, 326);
            this.btnThemsanpham.Name = "btnThemsanpham";
            this.btnThemsanpham.Size = new System.Drawing.Size(176, 36);
            this.btnThemsanpham.TabIndex = 8;
            this.btnThemsanpham.Text = "Thêm sản phẩm";
            this.btnThemsanpham.UseVisualStyleBackColor = true;
            this.btnThemsanpham.Click += new System.EventHandler(this.btnThemsanpham_Click);
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(169, 563);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(120, 36);
            this.btnDong.TabIndex = 9;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // dtpNgaysinh
            // 
            this.dtpNgaysinh.Location = new System.Drawing.Point(292, 132);
            this.dtpNgaysinh.Name = "dtpNgaysinh";
            this.dtpNgaysinh.Size = new System.Drawing.Size(424, 30);
            this.dtpNgaysinh.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(116, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ngày sinh:";
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(292, 290);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(424, 30);
            this.txtDiachi.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(116, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Địa chỉ:";
            // 
            // txtMasokinhdoanh
            // 
            this.txtMasokinhdoanh.Location = new System.Drawing.Point(292, 254);
            this.txtMasokinhdoanh.Name = "txtMasokinhdoanh";
            this.txtMasokinhdoanh.Size = new System.Drawing.Size(424, 30);
            this.txtMasokinhdoanh.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(116, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã số kinh doanh:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(292, 172);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(424, 30);
            this.txtEmail.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email:";
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(292, 91);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(424, 30);
            this.txtHoten.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Họ tên: ";
            // 
            // txtTencuahang
            // 
            this.txtTencuahang.Location = new System.Drawing.Point(292, 55);
            this.txtTencuahang.Name = "txtTencuahang";
            this.txtTencuahang.Size = new System.Drawing.Size(424, 30);
            this.txtTencuahang.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên cửa hàng";
            // 
            // txtMadoitac
            // 
            this.txtMadoitac.Location = new System.Drawing.Point(292, 19);
            this.txtMadoitac.Name = "txtMadoitac";
            this.txtMadoitac.Size = new System.Drawing.Size(424, 30);
            this.txtMadoitac.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã đối tác: ";
            // 
            // txtSodienthoai
            // 
            this.txtSodienthoai.Location = new System.Drawing.Point(292, 212);
            this.txtSodienthoai.Name = "txtSodienthoai";
            this.txtSodienthoai.Size = new System.Drawing.Size(424, 30);
            this.txtSodienthoai.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(116, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(132, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Số điện thoại:";
            // 
            // frmThemDoiTacSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 675);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmThemDoiTacSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm đối tác, sản phâm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnThemsanpham;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.DateTimePicker dtpNgaysinh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMasokinhdoanh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTencuahang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMadoitac;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnHoantat;
        private System.Windows.Forms.ListView lvSanpham;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox txtSodienthoai;
        private System.Windows.Forms.Label label9;
    }
}