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
    public partial class TimKiemPhieu : UserControl
    {
        public event EventHandler ShowChinhSua;
        #region Property
        public TextBox TxtMaPhieuMuon
        {
            get { return txtMaPhieuMuon; }
            set { txtMaPhieuMuon = value; }
        }
        public TextBox TxtMaDocGia
        {
            get { return txtMaDocGia; }
            set { txtMaDocGia = value; }
        }
        public TextBox TxtMaThuThu
        {
            get { return txtMaThuThu; }
            set { txtMaThuThu = value; }
        }
        public DateTimePicker DtpNgayMuon
        {
            get { return dtpNgayMuon; }
            set { dtpNgayMuon = value; }
        }
        public DateTimePicker DtpNgayHetHan
        {
            get { return dtpNgayHetHan; }
            set { dtpNgayHetHan = value; }
        }
        public RadioButton RbtnDaTra
        {
            get { return rbtnDaTra; }
            set { rbtnDaTra = value; }
        }
        public RadioButton RbtnChuaTra
        {
            get { return rbtnChuaTra; }
            set { rbtnChuaTra = value; }
        }
        #endregion
        public TimKiemPhieu()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void dgvDSPhieu_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                contextMenuStrip1.Show(dgvDSPhieu.PointToScreen(e.Location));
        }

        private void xemThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinPhieuPL phieu = new ThongTinPhieuPL();
            phieu.Show();
        }

        private void đánhDấuĐãTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void chỉnhSửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ShowChinhSua != null)
                this.ShowChinhSua(this, e);
        }
    }
}
