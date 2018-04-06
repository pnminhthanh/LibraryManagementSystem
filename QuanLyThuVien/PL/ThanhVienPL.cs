using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.PL
{
    public partial class ThanhVienPL : Form
    {
        public ThanhVienPL()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            dsThanhVienUSPL1.ShowChinhSua += new EventHandler(btnChinhSua_Click);
            locThanhVienPS1.ShowChinhSua += new EventHandler(btnChinhSua_Click);
        }

        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            SidePanel.Top = btnDanhSach.Top;
            dsThanhVienUSPL1.BringToFront();
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            SidePanel.Top = btnChinhSua.Top;
            chinhSuaThanhVienUSPL1.BringToFront();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            SidePanel.Top = btnTimKiem.Top;
            locThanhVienPS1.BringToFront();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát ra không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
            else { };
        }

        private void btnThuNho_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormState.PreviousForm.Show();
        }
    }
}
