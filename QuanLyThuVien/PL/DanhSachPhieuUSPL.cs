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
    public partial class DanhSachPhieuUSPL : UserControl
    {
        public event EventHandler ShowChinhSua;
        #region Property
        public TextBox TxtMaPhieuTim
        {
            get { return txtNoiDungTim; }
            set { txtNoiDungTim = value; }
        }
        public DataGridView DgvDSPhieuMuon
        {
            get { return dgvDSPhieuMuon; }
            set { dgvDSPhieuMuon = value; }
        }
        #endregion
        public DanhSachPhieuUSPL()
        {
            InitializeComponent();
        }

        private void dgvDSPhieuMuon_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(dgvDSPhieuMuon.PointToScreen(e.Location));
            }
        }

        private void danhdaudatraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void chỉnhSửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ShowChinhSua!=null)
            {
                this.ShowChinhSua(this, e);
               
            }
        }

        private void xemThôngTinChiTiếtToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }
    }
}
