using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThuVien.PL;

namespace QuanLyThuVien
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnSach_Click(object sender, EventArgs e)
        {
            FormState.PreviousForm = this;
            this.Hide();
            SachPL FormSach = new SachPL();
            FormSach.Show();
        }

        private void btnThanhVien_Click(object sender, EventArgs e)
        {
            FormState.PreviousForm = this;
            this.Hide();
            ThanhVienPL FormTV = new ThanhVienPL();
            FormTV.Show();
        }

        private void btnMuonTra_Click(object sender, EventArgs e)
        {
            FormState.PreviousForm = this;
            this.Hide();
            MuonTraSachPL FormMuonTra = new MuonTraSachPL();
            FormMuonTra.Show();
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
    }
}
