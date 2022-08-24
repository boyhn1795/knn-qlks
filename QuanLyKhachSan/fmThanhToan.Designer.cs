
namespace QuanLyKhachSan
{
    partial class fmThanhToan
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
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LuoiCTTT = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.bt_tinhtien = new System.Windows.Forms.Button();
            this.lb_tong = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_songayo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_p = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_tkht = new System.Windows.Forms.Button();
            this.bt_tkmp = new System.Windows.Forms.Button();
            this.cb_mp = new System.Windows.Forms.ComboBox();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.LuoiCTTT)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "thanhtien";
            this.Column7.HeaderText = "Thành Tiền";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "maphong";
            this.Column5.HeaderText = "Mã Phòng";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ngayden";
            this.Column4.HeaderText = "Ngày Đến";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "cmt";
            this.Column3.HeaderText = "Chứng Minh Thư";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "hoten";
            this.Column2.HeaderText = "Họ Và Tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "makh";
            this.Column1.HeaderText = "Mã Khách Hàng";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // LuoiCTTT
            // 
            this.LuoiCTTT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LuoiCTTT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.LuoiCTTT.Location = new System.Drawing.Point(6, 19);
            this.LuoiCTTT.Name = "LuoiCTTT";
            this.LuoiCTTT.RowHeadersWidth = 51;
            this.LuoiCTTT.Size = new System.Drawing.Size(634, 169);
            this.LuoiCTTT.TabIndex = 0;
            this.LuoiCTTT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LuoiCTTT_CellClick);
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "songayo";
            this.Column6.HeaderText = "Số Ngày Ở";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LuoiCTTT);
            this.groupBox3.Location = new System.Drawing.Point(12, 224);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(640, 194);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi Tiết Khách Hàng Thanh Toán";
            // 
            // bt_thoat
            // 
            this.bt_thoat.Location = new System.Drawing.Point(482, 48);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(75, 23);
            this.bt_thoat.TabIndex = 3;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = true;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // bt_tinhtien
            // 
            this.bt_tinhtien.Location = new System.Drawing.Point(482, 19);
            this.bt_tinhtien.Name = "bt_tinhtien";
            this.bt_tinhtien.Size = new System.Drawing.Size(75, 23);
            this.bt_tinhtien.TabIndex = 3;
            this.bt_tinhtien.Text = "Tính tiền";
            this.bt_tinhtien.UseVisualStyleBackColor = true;
            this.bt_tinhtien.Click += new System.EventHandler(this.bt_tinhtien_Click);
            // 
            // lb_tong
            // 
            this.lb_tong.AutoSize = true;
            this.lb_tong.Location = new System.Drawing.Point(281, 71);
            this.lb_tong.Name = "lb_tong";
            this.lb_tong.Size = new System.Drawing.Size(35, 13);
            this.lb_tong.TabIndex = 0;
            this.lb_tong.Text = "label1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tổng tiền khách hàng phải thanh toán là:";
            // 
            // lb_songayo
            // 
            this.lb_songayo.AutoSize = true;
            this.lb_songayo.Location = new System.Drawing.Point(281, 48);
            this.lb_songayo.Name = "lb_songayo";
            this.lb_songayo.Size = new System.Drawing.Size(35, 13);
            this.lb_songayo.TabIndex = 0;
            this.lb_songayo.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Phòng khách hàng ở:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số ngày khách ở:";
            // 
            // lb_p
            // 
            this.lb_p.AutoSize = true;
            this.lb_p.Location = new System.Drawing.Point(281, 24);
            this.lb_p.Name = "lb_p";
            this.lb_p.Size = new System.Drawing.Size(35, 13);
            this.lb_p.TabIndex = 0;
            this.lb_p.Text = "label1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_thoat);
            this.groupBox2.Controls.Add(this.bt_tinhtien);
            this.groupBox2.Controls.Add(this.lb_tong);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lb_songayo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lb_p);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(640, 100);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thanh Toán";
            // 
            // bt_tkht
            // 
            this.bt_tkht.Location = new System.Drawing.Point(385, 56);
            this.bt_tkht.Name = "bt_tkht";
            this.bt_tkht.Size = new System.Drawing.Size(180, 23);
            this.bt_tkht.TabIndex = 3;
            this.bt_tkht.Text = "Tìm Kiếm Theo Họ Tên";
            this.bt_tkht.UseVisualStyleBackColor = true;
            this.bt_tkht.Click += new System.EventHandler(this.bt_tkht_Click);
            // 
            // bt_tkmp
            // 
            this.bt_tkmp.Location = new System.Drawing.Point(385, 27);
            this.bt_tkmp.Name = "bt_tkmp";
            this.bt_tkmp.Size = new System.Drawing.Size(180, 23);
            this.bt_tkmp.TabIndex = 3;
            this.bt_tkmp.Text = "Tìm Kiếm Theo Mã Phòng";
            this.bt_tkmp.UseVisualStyleBackColor = true;
            this.bt_tkmp.Click += new System.EventHandler(this.bt_tkmp_Click);
            // 
            // cb_mp
            // 
            this.cb_mp.FormattingEnabled = true;
            this.cb_mp.Location = new System.Drawing.Point(155, 27);
            this.cb_mp.Name = "cb_mp";
            this.cb_mp.Size = new System.Drawing.Size(121, 21);
            this.cb_mp.TabIndex = 2;
            // 
            // txt_hoten
            // 
            this.txt_hoten.Location = new System.Drawing.Point(155, 51);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(121, 20);
            this.txt_hoten.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ Tên Khách Hàng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Phòng:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_tkht);
            this.groupBox1.Controls.Add(this.bt_tkmp);
            this.groupBox1.Controls.Add(this.cb_mp);
            this.groupBox1.Controls.Add(this.txt_hoten);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(640, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm Nhanh";
            // 
            // fmThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "fmThanhToan";
            this.Text = "fmThanhToan";
            this.Load += new System.EventHandler(this.fmThanhToan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LuoiCTTT)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView LuoiCTTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.Button bt_tinhtien;
        private System.Windows.Forms.Label lb_tong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_songayo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_p;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_tkht;
        private System.Windows.Forms.Button bt_tkmp;
        private System.Windows.Forms.ComboBox cb_mp;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}