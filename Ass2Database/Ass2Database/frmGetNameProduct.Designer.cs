namespace Ass2Database
{
    partial class frmGetNameProduct
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
            this.txtMadoitac = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXong = new System.Windows.Forms.Button();
            this.lvSanpham = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXong);
            this.panel1.Controls.Add(this.txtMadoitac);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 97);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập mã đối tác:";
            // 
            // txtMadoitac
            // 
            this.txtMadoitac.Location = new System.Drawing.Point(235, 17);
            this.txtMadoitac.Name = "txtMadoitac";
            this.txtMadoitac.Size = new System.Drawing.Size(366, 30);
            this.txtMadoitac.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lvSanpham);
            this.panel2.Location = new System.Drawing.Point(13, 133);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(624, 279);
            this.panel2.TabIndex = 1;
            // 
            // btnXong
            // 
            this.btnXong.Location = new System.Drawing.Point(440, 54);
            this.btnXong.Name = "btnXong";
            this.btnXong.Size = new System.Drawing.Size(123, 40);
            this.btnXong.TabIndex = 2;
            this.btnXong.Text = "Xong";
            this.btnXong.UseVisualStyleBackColor = true;
            this.btnXong.Click += new System.EventHandler(this.btnXong_Click);
            // 
            // lvSanpham
            // 
            this.lvSanpham.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvSanpham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSanpham.FullRowSelect = true;
            this.lvSanpham.HideSelection = false;
            this.lvSanpham.Location = new System.Drawing.Point(0, 0);
            this.lvSanpham.Name = "lvSanpham";
            this.lvSanpham.Size = new System.Drawing.Size(624, 279);
            this.lvSanpham.TabIndex = 0;
            this.lvSanpham.UseCompatibleStateImageBehavior = false;
            this.lvSanpham.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã đối tác";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã đơn hàng";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên sản phẩm";
            this.columnHeader3.Width = 200;
            // 
            // frmGetNameProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 424);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmGetNameProduct";
            this.Text = "Tìm thông tin sản phẩm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXong;
        private System.Windows.Forms.TextBox txtMadoitac;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lvSanpham;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}