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
    public partial class MuonTraSachPL : Form
    {
        public MuonTraSachPL()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            timKiemPhieu1.ShowChinhSua += new EventHandler(btnTao_Click);
            timKiemPhieu1.XuatPhieu += HienThiPhieuCanSua;
        }

        private void HienThiPhieuCanSua(object sender, EventArgs e, PhieuMuonSach phieu)
        {
            chinhSuaPhieuMuonUSPL1.LoadThongTin(phieu);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát ra không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
            else { };
        }

        private void btnThunho_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            FormState.PreviousForm.Show();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            SidePanel.Top = btnTao.Top;
            chinhSuaPhieuMuonUSPL1.BringToFront();
        }

        private void btnTimPhieu_Click(object sender, EventArgs e)
        {
            SidePanel.Top = btnTimPhieu.Top;
            timKiemPhieu1.BringToFront();
        }
    }
}

