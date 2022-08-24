using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class fmKhachHang : Form
    {
        public fmKhachHang()
        {
            InitializeComponent();
        }
        QLKSEntities db = new QLKSEntities();
        void DuaKH_Luoi()
        {
            LuoiCTKH.AutoGenerateColumns = false;
            LuoiCTKH.DataSource = db.KhachHangs.ToList();


        }
        // Hienthi combo max phong
        void TraMP()
        {
            cb_maptk.DataSource = db.Phongs.ToList();
            cb_maptk.ValueMember = "Maphong";
            cb_maptk.DisplayMember = "Maphong";
            cb_maptk.Text = "";
        }
        void DuaCBTT()
        {
            var q = (from s in db.Phongs
                     select new { s.Tinhtrang }).Distinct();

            cb_ttptk.DataSource = q.ToList();

            cb_ttptk.ValueMember = "Tinhtrang";
            cb_ttptk.DisplayMember = "Tinhtrang";
            cb_ttptk.Text = "";
        }
        void TraMPtrong()
        {
            var q = from s in db.Phongs
                    where s.Tinhtrang == "Trống"
                    select new { Maphong = s.Maphong };
            cb_mp.DataSource = q.ToList();
            cb_mp.ValueMember = "Maphong";
            cb_mp.DisplayMember = "Maphong";
            cb_mp.Text = "";
        }
        void Xoatext()
        {
            txt_makh.ResetText();
            txt_hoten.ResetText();
            txt_cmt.ResetText();
            cb_mp.ResetText();

        }
        private void fmKhachHang_Load(object sender, EventArgs e)
        {
            DuaKH_Luoi();
            TraMP();
            DuaCBTT();
            TraMPtrong();
        }

        private void bt_xemtt_Click(object sender, EventArgs e)
        {
            var q = from s in db.Phongs
                    where s.Tinhtrang.Contains(cb_ttptk.Text)
                    select new
                    {
                        Maphong = s.Maphong,
                        Sogiuong = s.Sogiuong,
                        Dongia = s.Dongia,
                        Tinhtrang = s.Tinhtrang
                    };
            LuoiCTP.DataSource = q.ToList();
        }

        private void bt_xemmp_Click(object sender, EventArgs e)
        {
            var q = from s in db.Phongs
                    where s.Maphong.Contains(cb_maptk.Text)

                    select new
                    {
                        Maphong = s.Maphong,
                        Sogiuong = s.Sogiuong,
                        Dongia = s.Dongia,
                        Tinhtrang = s.Tinhtrang
                    };
            LuoiCTP.DataSource = q.ToList();
        }

        private void txt_cmnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            { e.Handled = true; }
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            KhachHang kh = new KhachHang();
            kh.MaKH = txt_makh.Text;
            kh.Hoten = txt_hoten.Text;
            kh.SoCMT = txt_cmt.Text;
            kh.Maphong = cb_mp.Text;
            kh.Ngayden = DateTime.Today;
            db.KhachHangs.Add(kh);
            db.SaveChanges();

            DuaKH_Luoi();
            // Cap nhạt lại tình trạng cho Phòng đã thuê trong bảng phòng
            Phong p = db.Phongs.Find(cb_mp.Text);
            p.Tinhtrang = "Có khách";
            db.SaveChanges();
            // Cập nhật lại cb mã phòng - bỏ những phòng da có nguoi thue ra 
            TraMPtrong();
            Xoatext();
        }

        private void LuoiCTKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_makh.Text = LuoiCTKH.CurrentRow.Cells[0].Value.ToString();
            txt_hoten.Text = LuoiCTKH.CurrentRow.Cells[1].Value.ToString();
            txt_cmt.Text = LuoiCTKH.CurrentRow.Cells[2].Value.ToString();
            cb_mp.Text = LuoiCTKH.CurrentRow.Cells[4].Value.ToString();
            cb_mp.Enabled = false;
            txt_makh.Enabled = false;
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            try
            {
                // tìm khách hàng cần sửa theo mã khách hàng và ngày đến
                var q = from s in db.KhachHangs
                        where s.MaKH == txt_makh.Text && s.Maphong == cb_mp.Text
                        select s;
                KhachHang kh = q.FirstOrDefault();
                kh.Hoten = txt_hoten.Text;
                kh.SoCMT = txt_cmt.Text;
                db.SaveChanges();
                DuaKH_Luoi();
                txt_makh.Enabled = true;
                cb_mp.Enabled = true;
                Xoatext();
            }
            catch { MessageBox.Show("lỗi sửa"); }
        }

        private void Xoá_Click(object sender, EventArgs e)
        {
            // tìm khách hàng cần xoá
            try
            {
                var q = from s in db.KhachHangs
                        where s.MaKH == txt_makh.Text && s.Maphong == cb_mp.Text
                        select s;
                KhachHang kh = q.FirstOrDefault();
                db.KhachHangs.Remove(kh);
                db.SaveChanges();
                DuaKH_Luoi();
                // Cập nhật lại phòng là trống
                Phong p = db.Phongs.Find(cb_mp.Text);
                p.Tinhtrang = "Trống";
                db.SaveChanges();
                TraMPtrong();
                txt_makh.Enabled = true;
                cb_mp.Enabled = true;
                Xoatext();
            }
            catch { MessageBox.Show("Lỗi xoá"); }
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Người dùng có chắc chắn muốn thoát không", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void LuoiCTKH_SelectionChanged(object sender, EventArgs e)
        {
            //txt_makh.Text = LuoiCTKH.CurrentRow.Cells[0].Value.ToString();
            //txt_hoten.Text = LuoiCTKH.CurrentRow.Cells[1].Value.ToString();
            //txt_cmnd.Text = LuoiCTKH.CurrentRow.Cells[2].Value.ToString();
            //cb_mp.Text = LuoiCTKH.CurrentRow.Cells[4].Value.ToString();
            //cb_mp.Enabled = false;
            //txt_makh.Enabled = false;
        }
    }
}
