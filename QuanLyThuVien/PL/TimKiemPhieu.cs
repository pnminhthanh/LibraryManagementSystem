using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThuVien.BLL;
using QuanLyThuVien.Components;

namespace QuanLyThuVien.PL
{
    public partial class TimKiemPhieu : UserControl
    {
        public event EventHandler ShowChinhSua;
        public delegate void XuatPhieuEventHandler(object sender, EventArgs e, PhieuMuonSach phieu);
        public event XuatPhieuEventHandler XuatPhieu;
        PhieuMuonBLL phieuMuonBLL = new PhieuMuonBLL();
        int index = 1;

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
            if (!KtraDuLieu.CheckMa(txtMaPhieuMuon.Text))
                MessageBox.Show("Chỉ nhập số vào ô!", "Mã phiếu mượn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (!KtraDuLieu.CheckMa(txtMaDocGia.Text))
                MessageBox.Show("Chỉ nhập số vào ô!", "Mã độc giả", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (rbtnChuaTra.Checked) 
                    phieuMuonBLL.TKPhieuMuon(txtMaPhieuMuon, txtMaDocGia, dtpNgayMuon, Convert.ToDateTime(01 / 01 / 01), dtpNgayHetHan, dgvDSPhieu);
                else
                {
                    //ko biết viết
                }
            }
        }

        private void dgvDSPhieu_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            index = dgvDSPhieu.CurrentCell.RowIndex;
            if (e.Button == MouseButtons.Right)
                contextMenuStrip1.Show(dgvDSPhieu.PointToScreen(e.Location));
        }

        private void xemThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinPhieuPL phieu = new ThongTinPhieuPL(phieuMuonBLL.LayPhieuMuonDGV(dgvDSPhieu.Rows[index]));
            phieu.Show();
        }

        private void chỉnhSửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ShowChinhSua != null)
            {
                XuatPhieu(this, e, phieuMuonBLL.LayPhieuMuonDGV(dgvDSPhieu.Rows[index]));
                this.ShowChinhSua(this, e);
            }
        }

        private void dgvDSPhieu_CurrentCellChanged(object sender, EventArgs e)
        {

        }
    }
}
