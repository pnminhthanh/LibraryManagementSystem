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
    public partial class SachPL : Form
    {       
        public SachPL()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            danhSachUSPL1.ShowChinhSua += new EventHandler(btnChinhSua_Click);
        }
        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnDanhSach.Height;
            SidePanel.Top = btnDanhSach.Top;
            danhSachUSPL1.BringToFront();
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnChinhSua.Height;
            SidePanel.Top = btnChinhSua.Top;
            chinhSuaSachUSPL1.BringToFront();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            SidePanel.Height = btnTimKiem.Height;
            SidePanel.Top = btnTimKiem.Top;
            timKiemSachPL1.BringToFront();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormState.PreviousForm.Show();          
        }

        private void btnThunho_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát ra không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
            else { };
        }
    }
}
