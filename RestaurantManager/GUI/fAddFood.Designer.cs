﻿namespace RestaurantManager.GUI
{
    partial class fAddFood
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
            this.cbDanhMuc = new System.Windows.Forms.ComboBox();
            this.dgvThucDon = new System.Windows.Forms.DataGridView();
            this.clTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTenMon = new System.Windows.Forms.TextBox();
            this.numSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lable = new System.Windows.Forms.Label();
            this.lbBan = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // cbDanhMuc
            // 
            this.cbDanhMuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDanhMuc.FormattingEnabled = true;
            this.cbDanhMuc.Location = new System.Drawing.Point(35, 58);
            this.cbDanhMuc.Margin = new System.Windows.Forms.Padding(4);
            this.cbDanhMuc.Name = "cbDanhMuc";
            this.cbDanhMuc.Size = new System.Drawing.Size(162, 28);
            this.cbDanhMuc.TabIndex = 1;
            this.cbDanhMuc.SelectedIndexChanged += new System.EventHandler(this.cbDanhMuc_SelectedIndexChanged);
            // 
            // dgvThucDon
            // 
            this.dgvThucDon.AllowUserToAddRows = false;
            this.dgvThucDon.BackgroundColor = System.Drawing.Color.White;
            this.dgvThucDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThucDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clTen,
            this.clDonGia,
            this.clDonVi});
            this.dgvThucDon.GridColor = System.Drawing.Color.Black;
            this.dgvThucDon.Location = new System.Drawing.Point(35, 91);
            this.dgvThucDon.Margin = new System.Windows.Forms.Padding(4);
            this.dgvThucDon.Name = "dgvThucDon";
            this.dgvThucDon.ReadOnly = true;
            this.dgvThucDon.RowHeadersVisible = false;
            this.dgvThucDon.RowHeadersWidth = 62;
            this.dgvThucDon.Size = new System.Drawing.Size(393, 336);
            this.dgvThucDon.TabIndex = 2;
            // 
            // clTen
            // 
            this.clTen.DataPropertyName = "TenMonAn";
            this.clTen.HeaderText = "Tên";
            this.clTen.MinimumWidth = 8;
            this.clTen.Name = "clTen";
            this.clTen.ReadOnly = true;
            this.clTen.Width = 190;
            // 
            // clDonGia
            // 
            this.clDonGia.DataPropertyName = "DonGia";
            this.clDonGia.HeaderText = "Đơn giá";
            this.clDonGia.MinimumWidth = 8;
            this.clDonGia.Name = "clDonGia";
            this.clDonGia.ReadOnly = true;
            this.clDonGia.Width = 85;
            // 
            // clDonVi
            // 
            this.clDonVi.DataPropertyName = "DonVi";
            this.clDonVi.HeaderText = "Đơn vị";
            this.clDonVi.MinimumWidth = 8;
            this.clDonVi.Name = "clDonVi";
            this.clDonVi.ReadOnly = true;
            this.clDonVi.Width = 80;
            // 
            // txtTenMon
            // 
            this.txtTenMon.BackColor = System.Drawing.Color.White;
            this.txtTenMon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenMon.Location = new System.Drawing.Point(144, 436);
            this.txtTenMon.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenMon.Name = "txtTenMon";
            this.txtTenMon.ReadOnly = true;
            this.txtTenMon.Size = new System.Drawing.Size(192, 30);
            this.txtTenMon.TabIndex = 3;
            // 
            // numSoLuong
            // 
            this.numSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numSoLuong.Location = new System.Drawing.Point(144, 513);
            this.numSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.numSoLuong.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoLuong.Name = "numSoLuong";
            this.numSoLuong.Size = new System.Drawing.Size(54, 30);
            this.numSoLuong.TabIndex = 4;
            this.numSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.BackgroundImage = global::RestaurantManager.Properties.Resources.c386847a;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(369, 481);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(59, 57);
            this.btnThem.TabIndex = 5;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tên:";
            // 
            // txtGia
            // 
            this.txtGia.BackColor = System.Drawing.Color.White;
            this.txtGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(144, 474);
            this.txtGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtGia.Name = "txtGia";
            this.txtGia.ReadOnly = true;
            this.txtGia.Size = new System.Drawing.Size(110, 30);
            this.txtGia.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 479);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Giá:";
            // 
            // lable
            // 
            this.lable.AutoSize = true;
            this.lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable.Location = new System.Drawing.Point(100, 20);
            this.lable.Name = "lable";
            this.lable.Size = new System.Drawing.Size(57, 25);
            this.lable.TabIndex = 7;
            this.lable.Text = "Bàn:";
            // 
            // lbBan
            // 
            this.lbBan.BackColor = System.Drawing.Color.White;
            this.lbBan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBan.ForeColor = System.Drawing.Color.Red;
            this.lbBan.Location = new System.Drawing.Point(163, 10);
            this.lbBan.Name = "lbBan";
            this.lbBan.Size = new System.Drawing.Size(151, 35);
            this.lbBan.TabIndex = 7;
            this.lbBan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(305, 58);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(123, 26);
            this.txtTimKiem.TabIndex = 8;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tìm kiếm:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 513);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Số lượng:";
            // 
            // fAddFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(470, 561);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.lbBan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.numSoLuong);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtTenMon);
            this.Controls.Add(this.dgvThucDon);
            this.Controls.Add(this.cbDanhMuc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "fAddFood";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm món";
            this.Load += new System.EventHandler(this.AddFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThucDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDanhMuc;
        private System.Windows.Forms.DataGridView dgvThucDon;
        private System.Windows.Forms.TextBox txtTenMon;
        private System.Windows.Forms.NumericUpDown numSoLuong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lable;
        private System.Windows.Forms.Label lbBan;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDonVi;
        private System.Windows.Forms.Label label4;
    }
}