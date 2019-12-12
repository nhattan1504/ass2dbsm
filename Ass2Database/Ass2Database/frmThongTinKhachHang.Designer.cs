namespace Ass2Database
{
    partial class frmThongTinKhachHang
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
            this.txtSodonhang = new System.Windows.Forms.TextBox();
            this.btnXong = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lvInfo = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXong);
            this.panel1.Controls.Add(this.txtSodonhang);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(770, 108);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số đơn hàng:";
            // 
            // txtSodonhang
            // 
            this.txtSodonhang.Location = new System.Drawing.Point(308, 17);
            this.txtSodonhang.Name = "txtSodonhang";
            this.txtSodonhang.Size = new System.Drawing.Size(324, 30);
            this.txtSodonhang.TabIndex = 1;
            // 
            // btnXong
            // 
            this.btnXong.Location = new System.Drawing.Point(471, 53);
            this.btnXong.Name = "btnXong";
            this.btnXong.Size = new System.Drawing.Size(128, 39);
            this.btnXong.TabIndex = 2;
            this.btnXong.Text = "Xong";
            this.btnXong.UseVisualStyleBackColor = true;
            this.btnXong.Click += new System.EventHandler(this.btnXong_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lvInfo);
            this.panel2.Location = new System.Drawing.Point(13, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(770, 289);
            this.panel2.TabIndex = 1;
            // 
            // lvInfo
            // 
            this.lvInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvInfo.FullRowSelect = true;
            this.lvInfo.HideSelection = false;
            this.lvInfo.Location = new System.Drawing.Point(0, 0);
            this.lvInfo.Name = "lvInfo";
            this.lvInfo.Size = new System.Drawing.Size(770, 289);
            this.lvInfo.TabIndex = 0;
            this.lvInfo.UseCompatibleStateImageBehavior = false;
            this.lvInfo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã khách hàng";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ tên";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số điện thoại";
            this.columnHeader3.Width = 130;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Địa chỉ";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Số đơn hàng";
            this.columnHeader5.Width = 150;
            // 
            // frmThongTinKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 427);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmThongTinKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin khách hàng";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXong;
        private System.Windows.Forms.TextBox txtSodonhang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lvInfo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}