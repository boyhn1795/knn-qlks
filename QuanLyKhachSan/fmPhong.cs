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
    public partial class fmPhong : Form
    {
        public fmPhong()
        {
            InitializeComponent();
        }
        QLKSEntities db = new QLKSEntities();
        void duaDL_luoi()
        {
            LuoiPhong.AutoGenerateColumns = false;
            LuoiPhong.DataSource = db.Phongs.ToList();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            duaDL_luoi();

        }
        // vieets ham kiem tra du lieu
        Boolean kiemtraDL()
        {
            if ((txt_mp.Text == "") || (txt_sg.Text == "") || (txt_dg.Text == "") || (cb_tt.Text == "")) return false;
            return true;
        }
        private void fmPhong_Load(object sender, EventArgs e)
        {
            duaDL_luoi();
        }
        void xoatext()
        {
            txt_mp.Text = "";txt_sg.Text = "";txt_dg.Text = "";cb_tt.Text = "";
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            // thuc hien them 1 phong vao bang Phong
            if (kiemtraDL() == false) MessageBox.Show("Bạn Chưa Nhập Đủ Dữ Liệu");
            else
            {
                Phong kt = db.Phongs.Find(txt_mp.Text);
                if (kt != null)
                {
                    MessageBox.Show("Trùng Mã Phòng");
                    txt_mp.Focus();
                }
                else
                {
                    Phong p = new Phong();
                    p.Maphong = txt_mp.Text;
                    p.Sogiuong=int.Parse(txt_sg.Text);
                    p.Dongia = int.Parse(txt_dg.Text);
                    p.Tinhtrang = cb_tt.Text;
                    db.Phongs.Add(p);
                    db.SaveChanges();// Luu vao database                                  
                    duaDL_luoi();
                }

            }
        }

        private void LuoiPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = LuoiPhong.CurrentRow.Index;
            txt_mp.Text = LuoiPhong.Rows[i].Cells[0].Value.ToString();
            txt_sg.Text = LuoiPhong.Rows[i].Cells[1].Value.ToString();
            txt_dg.Text = LuoiPhong.Rows[i].Cells[2].Value.ToString();
            cb_tt.Text = LuoiPhong.Rows[i].Cells[3].Value.ToString();
            txt_mp.Enabled = false;
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            try
            {
                Phong p = db.Phongs.Find(txt_mp.Text);
                p.Sogiuong = int.Parse(txt_sg.Text);
                p.Dongia = int.Parse(txt_dg.Text);
                p.Tinhtrang = cb_tt.Text;
                db.SaveChanges();
                duaDL_luoi();
            }

            catch (Exception)
            { MessageBox.Show("sai kiểu dữ liệu, lỗi k sưả được"); }
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            try
            {

                Phong p = db.Phongs.Find(txt_mp.Text);
                db.Phongs.Remove(p);
                db.SaveChanges();
                duaDL_luoi();

            }
            catch (Exception)
            { MessageBox.Show("Loi xoa"); }
        }

        private void bt_thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Người dùng có chắc chắn muốn thoát không", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    } 
}
