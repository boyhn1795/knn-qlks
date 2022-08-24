
namespace QuanLyKhachSan
{
    partial class fmKhachHang
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
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.txt_cmt = new System.Windows.Forms.TextBox();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.txt_makh = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_mp = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.Xoá = new System.Windows.Forms.Button();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LuoiCTP = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_xemmp = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LuoiCTKH = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_maptk = new System.Windows.Forms.ComboBox();
            this.bt_xemtt = new System.Windows.Forms.Button();
            this.cb_ttptk = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LuoiCTP)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LuoiCTKH)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_sua
            // 
            this.bt_sua.Location = new System.Drawing.Point(182, 89);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(75, 23);
            this.bt_sua.TabIndex = 3;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(79, 89);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(75, 23);
            this.bt_them.TabIndex = 3;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // txt_cmt
            // 
            this.txt_cmt.Location = new System.Drawing.Point(398, 19);
            this.txt_cmt.Name = "txt_cmt";
            this.txt_cmt.Size = new System.Drawing.Size(120, 20);
            this.txt_cmt.TabIndex = 2;
            this.txt_cmt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cmnd_KeyPress);
            // 
            // txt_hoten
            // 
            this.txt_hoten.Location = new System.Drawing.Point(124, 52);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(120, 20);
            this.txt_hoten.TabIndex = 2;
            // 
            // txt_makh
            // 
            this.txt_makh.Location = new System.Drawing.Point(124, 26);
            this.txt_makh.Name = "txt_makh";
            this.txt_makh.Size = new System.Drawing.Size(120, 20);
            this.txt_makh.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(333, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã Phòng:";
            // 
            // cb_mp
            // 
            this.cb_mp.FormattingEnabled = true;
            this.cb_mp.Location = new System.Drawing.Point(398, 56);
            this.cb_mp.Name = "cb_mp";
            this.cb_mp.Size = new System.Drawing.Size(121, 21);
            this.cb_mp.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(333, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Số CMND:";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "maphong";
            this.Column8.HeaderText = "Mã Phòng";
            this.Column8.Name = "Column8";
            // 
            // bt_thoat
            // 
            this.bt_thoat.Location = new System.Drawing.Point(386, 89);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(75, 23);
            this.bt_thoat.TabIndex = 3;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = true;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // Xoá
            // 
            this.Xoá.Location = new System.Drawing.Point(273, 89);
            this.Xoá.Name = "Xoá";
            this.Xoá.Size = new System.Drawing.Size(75, 23);
            this.Xoá.TabIndex = 3;
            this.Xoá.Text = "Xoá";
            this.Xoá.UseVisualStyleBackColor = true;
            this.Xoá.Click += new System.EventHandler(this.Xoá_Click);
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "songayo";
            this.Column9.HeaderText = "Số Ngày Ở";
            this.Column9.Name = "Column9";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Họ Tên:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.bt_thoat);
            this.groupBox4.Controls.Add(this.Xoá);
            this.groupBox4.Controls.Add(this.bt_sua);
            this.groupBox4.Controls.Add(this.bt_them);
            this.groupBox4.Controls.Add(this.txt_cmt);
            this.groupBox4.Controls.Add(this.txt_hoten);
            this.groupBox4.Controls.Add(this.txt_makh);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.cb_mp);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(83, 255);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(550, 126);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông Tin Khách Thuê Phòng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã Khách Hàng:";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "ngayden";
            this.Column7.HeaderText = "Ngày Đến";
            this.Column7.Name = "Column7";
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "thanhtien";
            this.Column10.HeaderText = "Thành Tiền";
            this.Column10.Name = "Column10";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "cmt";
            this.Column6.HeaderText = "Số Chứng Minh Thư";
            this.Column6.Name = "Column6";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LuoiCTP);
            this.groupBox2.Location = new System.Drawing.Point(119, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(462, 131);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi Tiết Phòng";
            // 
            // LuoiCTP
            // 
            this.LuoiCTP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LuoiCTP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.LuoiCTP.Location = new System.Drawing.Point(6, 19);
            this.LuoiCTP.Name = "LuoiCTP";
            this.LuoiCTP.Size = new System.Drawing.Size(447, 106);
            this.LuoiCTP.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "maphong";
            this.Column1.HeaderText = "Mã Phòng";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "sogiuong";
            this.Column2.HeaderText = "Số Giường";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "dongia";
            this.Column3.HeaderText = "Đơn Giá";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "tinhtrang";
            this.Column4.HeaderText = "Tình Trạng";
            this.Column4.Name = "Column4";
            // 
            // bt_xemmp
            // 
            this.bt_xemmp.Location = new System.Drawing.Point(409, 63);
            this.bt_xemmp.Name = "bt_xemmp";
            this.bt_xemmp.Size = new System.Drawing.Size(180, 23);
            this.bt_xemmp.TabIndex = 2;
            this.bt_xemmp.Text = "Xem Theo Mã Phòng";
            this.bt_xemmp.UseVisualStyleBackColor = true;
            this.bt_xemmp.Click += new System.EventHandler(this.bt_xemmp_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LuoiCTKH);
            this.groupBox3.Location = new System.Drawing.Point(12, 387);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(755, 229);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi Tiết Khách Hàng";
            // 
            // LuoiCTKH
            // 
            this.LuoiCTKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LuoiCTKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column11,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.LuoiCTKH.Location = new System.Drawing.Point(6, 19);
            this.LuoiCTKH.Name = "LuoiCTKH";
            this.LuoiCTKH.Size = new System.Drawing.Size(741, 204);
            this.LuoiCTKH.TabIndex = 0;
            this.LuoiCTKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LuoiCTKH_CellClick);
            this.LuoiCTKH.SelectionChanged += new System.EventHandler(this.LuoiCTKH_SelectionChanged);
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "makh";
            this.Column5.HeaderText = "Mã Khách Hàng";
            this.Column5.Name = "Column5";
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "hoten";
            this.Column11.HeaderText = "Họ Và Tên";
            this.Column11.Name = "Column11";
            // 
            // cb_maptk
            // 
            this.cb_maptk.FormattingEnabled = true;
            this.cb_maptk.Location = new System.Drawing.Point(156, 63);
            this.cb_maptk.Name = "cb_maptk";
            this.cb_maptk.Size = new System.Drawing.Size(121, 21);
            this.cb_maptk.TabIndex = 1;
            // 
            // bt_xemtt
            // 
            this.bt_xemtt.Location = new System.Drawing.Point(409, 28);
            this.bt_xemtt.Name = "bt_xemtt";
            this.bt_xemtt.Size = new System.Drawing.Size(180, 23);
            this.bt_xemtt.TabIndex = 2;
            this.bt_xemtt.Text = "Xem Theo Tình Trạng";
            this.bt_xemtt.UseVisualStyleBackColor = true;
            this.bt_xemtt.Click += new System.EventHandler(this.bt_xemtt_Click);
            // 
            // cb_ttptk
            // 
            this.cb_ttptk.FormattingEnabled = true;
            this.cb_ttptk.Items.AddRange(new object[] {
            "có khách",
            "trống"});
            this.cb_ttptk.Location = new System.Drawing.Point(156, 28);
            this.cb_ttptk.Name = "cb_ttptk";
            this.cb_ttptk.Size = new System.Drawing.Size(121, 21);
            this.cb_ttptk.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Phòng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tình Trạng Phòng:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_xemmp);
            this.groupBox1.Controls.Add(this.cb_maptk);
            this.groupBox1.Controls.Add(this.bt_xemtt);
            this.groupBox1.Controls.Add(this.cb_ttptk);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(755, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Phòng";
            // 
            // fmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 616);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "fmKhachHang";
            this.Text = "fmKhachHang";
            this.Load += new System.EventHandler(this.fmKhachHang_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LuoiCTP)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LuoiCTKH)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.TextBox txt_cmt;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.TextBox txt_makh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_mp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.Button Xoá;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView LuoiCTP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button bt_xemmp;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView LuoiCTKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.ComboBox cb_maptk;
        private System.Windows.Forms.Button bt_xemtt;
        private System.Windows.Forms.ComboBox cb_ttptk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}