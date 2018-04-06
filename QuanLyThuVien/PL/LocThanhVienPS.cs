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
    public partial class LocThanhVienPS : UserControl
    {
        public event EventHandler ShowChinhSua;
        public LocThanhVienPS()
        {
            InitializeComponent();
        }

        private void cậpNhậtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ShowChinhSua != null)
                this.ShowChinhSua(this, e);
        }

        private void xemthoongtinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinTV tv = new ThongTinTV();
            tv.Show();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                contextMenuStrip1.Show(dgvDSTV.PointToScreen(e.Location));
        }
    }
}
