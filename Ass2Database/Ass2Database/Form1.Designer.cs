namespace Ass2Database
{
    partial class frmMainInterface
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
            this.gbChucNang = new System.Windows.Forms.GroupBox();
            this.lvChucNang = new System.Windows.Forms.ListView();
            this.txtTenChucNang = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtNguoiThucHien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnChon = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thương Mại Điện Tử";
            // 
            // gbChucNang
            // 
            this.gbChucNang.Controls.Add(this.lvChucNang);
            this.gbChucNang.Location = new System.Drawing.Point(12, 87);
            this.gbChucNang.Name = "gbChucNang";
            this.gbChucNang.Size = new System.Drawing.Size(693, 291);
            this.gbChucNang.TabIndex = 1;
            this.gbChucNang.TabStop = false;
            this.gbChucNang.Text = "Chức năng: ";
            // 
            // lvChucNang
            // 
            this.lvChucNang.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.txtTenChucNang,
            this.txtNguoiThucHien});
            this.lvChucNang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvChucNang.FullRowSelect = true;
            this.lvChucNang.HideSelection = false;
            this.lvChucNang.Location = new System.Drawing.Point(3, 32);
            this.lvChucNang.Name = "lvChucNang";
            this.lvChucNang.Size = new System.Drawing.Size(687, 256);
            this.lvChucNang.TabIndex = 0;
            this.lvChucNang.UseCompatibleStateImageBehavior = false;
            this.lvChucNang.View = System.Windows.Forms.View.Details;
            this.lvChucNang.SelectedIndexChanged += new System.EventHandler(this.lvChucNang_SelectedIndexChanged);
            // 
            // txtTenChucNang
            // 
            this.txtTenChucNang.Text = "Tên chức năng";
            this.txtTenChucNang.Width = 522;
            // 
            // txtNguoiThucHien
            // 
            this.txtNguoiThucHien.Text = "Người thực hiện";
            this.txtNguoiThucHien.Width = 200;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(108, 394);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(149, 37);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(433, 394);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(149, 37);
            this.btnChon.TabIndex = 2;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ass2Database.Properties.Resources.LogoBK;
            this.pictureBox1.Location = new System.Drawing.Point(31, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmMainInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 462);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.gbChucNang);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmMainInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giao diện chính";
            this.gbChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbChucNang;
        private System.Windows.Forms.ListView lvChucNang;
        private System.Windows.Forms.ColumnHeader txtTenChucNang;
        private System.Windows.Forms.ColumnHeader txtNguoiThucHien;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

