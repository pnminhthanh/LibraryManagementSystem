using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.PL
{
    public partial class DSThanhVienUSPL : UserControl
    {
        public event EventHandler ShowChinhSua;
        public DSThanhVienUSPL()
        {
            InitializeComponent();
        }

        private void chỉnhSửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ShowChinhSua != null)
                this.ShowChinhSua(this, e);
        }

        private void xemthôngtinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinTVPL tv = new ThongTinTVPL();
            tv.Show();
        }

        private void dgvDSThanhVien_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                contextMenuStrip1.Show(dgvDSThanhVien.PointToScreen(e.Location));
        }
    }
}
