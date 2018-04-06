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
    public partial class ThongTinSachPL : Form
    {
        public ThongTinSachPL()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void ThongTinSachPL_Load(object sender, EventArgs e)
        {

        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemBanSaoPL them = new ThemBanSaoPL();
            them.Show();
        }
    }
}
