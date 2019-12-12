namespace Ass2Database
{
    partial class frmCau3aAss
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
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.btnXong = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lvThongtin = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXong);
            this.panel1.Controls.Add(this.txtDiachi);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 109);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập địa chỉ:";
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(256, 24);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(334, 30);
            this.txtDiachi.TabIndex = 1;
            // 
            // btnXong
            // 
            this.btnXong.Location = new System.Drawing.Point(432, 61);
            this.btnXong.Name = "btnXong";
            this.btnXong.Size = new System.Drawing.Size(108, 32);
            this.btnXong.TabIndex = 2;
            this.btnXong.Text = "Xong";
            this.btnXong.UseVisualStyleBackColor = true;
            this.btnXong.Click += new System.EventHandler(this.btnXong_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lvThongtin);
            this.panel2.Location = new System.Drawing.Point(13, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(681, 322);
            this.panel2.TabIndex = 1;
            // 
            // lvThongtin
            // 
            this.lvThongtin.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvThongtin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvThongtin.FullRowSelect = true;
            this.lvThongtin.HideSelection = false;
            this.lvThongtin.Location = new System.Drawing.Point(0, 0);
            this.lvThongtin.Name = "lvThongtin";
            this.lvThongtin.Size = new System.Drawing.Size(681, 322);
            this.lvThongtin.TabIndex = 0;
            this.lvThongtin.UseCompatibleStateImageBehavior = false;
            this.lvThongtin.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Họ tên";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã đơn hàng";
            this.columnHeader2.Width = 175;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Trạng thái";
            this.columnHeader3.Width = 168;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tổng tiền";
            this.columnHeader4.Width = 156;
            // 
            // frmCau3aAss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 463);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmCau3aAss";
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
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lvThongtin;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}