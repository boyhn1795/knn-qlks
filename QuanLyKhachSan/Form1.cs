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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        QLKSEntities db = new QLKSEntities();
        private void quảnLýPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmPhong a = new fmPhong();
            a.ShowDialog();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmKhachHang a = new fmKhachHang();
            a.ShowDialog();
        }

        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmThanhToan a = new fmThanhToan();
            a.ShowDialog();
        }
    }
}
