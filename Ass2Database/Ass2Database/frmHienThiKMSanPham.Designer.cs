namespace Ass2Database
{
    partial class frmHienThiKMSanPham
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
            this.btnXong = new System.Windows.Forms.Button();
            this.txtTensanpham = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lvKM = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXong);
            this.panel1.Controls.Add(this.txtTensanpham);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 108);
            this.panel1.TabIndex = 1;
            // 
            // btnXong
            // 
            this.btnXong.Location = new System.Drawing.Point(316, 50);
            this.btnXong.Name = "btnXong";
            this.btnXong.Size = new System.Drawing.Size(128, 39);
            this.btnXong.TabIndex = 2;
            this.btnXong.Text = "Xong";
            this.btnXong.UseVisualStyleBackColor = true;
            this.btnXong.Click += new System.EventHandler(this.btnXong_Click);
            // 
            // txtTensanpham
            // 
            this.txtTensanpham.Location = new System.Drawing.Point(233, 14);
            this.txtTensanpham.Name = "txtTensanpham";
            this.txtTensanpham.Size = new System.Drawing.Size(324, 20);
            this.txtTensanpham.TabIndex = 1;
            this.txtTensanpham.TextChanged += new System.EventHandler(this.txtSodonhang_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập tên sản phẩm:";
            // 
            // lvKM
            // 
            this.lvKM.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvKM.Location = new System.Drawing.Point(12, 138);
            this.lvKM.Name = "lvKM";
            this.lvKM.Size = new System.Drawing.Size(770, 300);
            this.lvKM.TabIndex = 2;
            this.lvKM.UseCompatibleStateImageBehavior = false;
            this.lvKM.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên sản phẩm";
            this.columnHeader1.Width = 146;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Xuất xứ";
            this.columnHeader2.Width = 81;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mã sản phẩm";
            this.columnHeader3.Width = 84;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thời gian bắt đầu";
            this.columnHeader4.Width = 113;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Thời gian kết thúc";
            this.columnHeader5.Width = 218;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Hình thức";
            this.columnHeader6.Width = 245;
            // 
            // frmHienThiKMSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvKM);
            this.Controls.Add(this.panel1);
            this.Name = "frmHienThiKMSanPham";
            this.Text = "frmHienThiKMSanPham";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXong;
        private System.Windows.Forms.TextBox txtTensanpham;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvKM;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}