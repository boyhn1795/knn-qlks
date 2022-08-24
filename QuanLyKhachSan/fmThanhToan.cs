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
    public partial class fmThanhToan : Form
    {
        public fmThanhToan()
        {
            InitializeComponent();
        }
        QLKSEntities db = new QLKSEntities();
        void TraMP()
        {
            var q = from s in db.Phongs
                    where s.Tinhtrang == "có khách"
                    select s;
            cb_mp.DataSource = q.ToList();
            cb_mp.ValueMember = "Maphong";
            cb_mp.Text = "";

        }
        private void fmThanhToan_Load(object sender, EventArgs e)
        {
            TraMP();
        }
        // Tìm kiêm theo mã phòng trong bảng khách hàng 
        private void bt_tkmp_Click(object sender, EventArgs e)
        {
            // tìm thông tin phòng cần tìm kiếm
            try
            {
                var q = from s in db.KhachHangs
                        where s.Maphong.Contains(cb_mp.Text) && s.Songayo == null
                        select new
                        {
                            MaKH = s.MaKH,
                            Hoten = s.Hoten,
                            CMT = s.SoCMT,
                            Ngayden = s.Ngayden,
                            MaPhong = s.Maphong,
                            Songayo = s.Songayo,
                            Thanhtien = s.Thanhtien

                        };
                LuoiCTTT.DataSource = q.ToList();
                // txtHoten.Text = q.FirstOrDefault().Hoten.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi thao tác");
            }
        }
        // tìm theo họ tên của những khách hàng chưa thanh toán nhé
        private void bt_tkht_Click(object sender, EventArgs e)
        {
            
            try
            {
                var q = from s in db.KhachHangs
                        where s.Hoten.Contains(txt_hoten.Text) && s.Songayo == null
                        select new
                        {
                            MaKH = s.MaKH,
                            Hoten = s.Hoten,
                            CMT = s.SoCMT,
                            Ngayden = s.Ngayden,
                            MaPhong = s.Maphong,
                            Songayo = s.Songayo,
                            Thanhtien = s.Thanhtien
                        };
                LuoiCTTT.DataSource = q.ToList();
            }
            catch (Exception)
            { MessageBox.Show("Lỗi thao tác"); }
        }
        int i = 0;

        private void LuoiCTTT_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // chọn phòng cần thanh toán, thông tin về phòng được đưa lên combo
            i = LuoiCTTT.CurrentRow.Index;
        }

        private void bt_tinhtien_Click(object sender, EventArgs e)
        {
            lb_p.Text = LuoiCTTT.Rows[i].Cells[4].Value.ToString();
            DateTime ngayden = DateTime.Parse(LuoiCTTT.Rows[i].Cells[3].Value.ToString());
            String makh = LuoiCTTT.Rows[i].Cells[0].Value.ToString();
            // lấy đơn  giá khi biết mã phòng
            Phong p = db.Phongs.Find(lb_p.Text);
            double dongia = (double)p.Dongia;
            // tìm đên khách hàng có makh, ngayden, maphong để cập nhật số ngày. 
            double songay = DateTime.Today.Subtract(ngayden).TotalDays + 1;
            lb_songayo.Text = songay.ToString("F0");
            int songayo = int.Parse(lb_songayo.Text);
            double tongtien = dongia * songayo;
            lb_tong.Text = tongtien.ToString("F0");
            // Cập nhật số ngày ở, thành tiền cho khách hàng cần thanh toán
            var q = from s in db.KhachHangs
                    where s.MaKH == makh && s.Maphong == lb_p.Text
                    select s;
            KhachHang kh = q.FirstOrDefault();
            kh.Songayo = songayo;
            kh.Thanhtien = (Int32)tongtien;
            db.SaveChanges();
            // cập nhật lại tình trạng phòng là trống 
            p.Tinhtrang = "trống";
            db.SaveChanges();
            // cập nhật lại trên lưới về khách hàng vừa thanh toán 
            var k = from s in db.KhachHangs
                    where s.MaKH == makh && s.Maphong == lb_p.Text
                    select new
                    {
                        MaKH = s.MaKH,
                        Hoten = s.Hoten,
                        CMT = s.SoCMT,
                        Ngayden = s.Ngayden,
                        MaPhong = s.Maphong,
                        Songayo = s.Songayo,
                        Thanhtien = s.Thanhtien

                    };

            LuoiCTTT.DataSource = k.ToList();
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Người dùng có chắc chắn muốn thoát không","Thông Báo",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                this.Close();
            }    
        }
    }
}
