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
    public partial class ChinhSuaPhieuMuonUSPL : UserControl
    {
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
        public ComboBox CboMaThuThu
        {
            get { return cboThuThu; }
            set { cboThuThu = value; }
        }
        public TextBox TxtMaBanSao
        {
            get { return txtMaBanSao; }
            set { txtMaBanSao = value; }
        }
        public TextBox TxtTongTienCoc
        {
            get { return txtTienCoc; }
            set { txtTienCoc = value; }
        }
        public ComboBox CbSoNgayMuon
        {
            get { return cbSoNgayMuon; }
            set { cbSoNgayMuon = value; }
        }
        public DateTimePicker DtpNgayMuon
        {
            get { return dtpNgayMuon; }
            set { dtpNgayMuon = value; }
        }
        public DateTimePicker DtpNgayhetHan
        {
            get { return dtpNgayHetHan; }
            set { dtpNgayHetHan = value; }
        }
        public DataGridView DgvDSMuon
        {
            get { return dgvDSMuon; }
            set { dgvDSMuon = value; }
        }
        #endregion
        PhieuMuonBLL phieuMuonBLL = new PhieuMuonBLL();
        ThuThuBLL thuThuBLL = new ThuThuBLL();
        BanSaoBLL banSaoBLL = new BanSaoBLL();

        public ChinhSuaPhieuMuonUSPL()
        {
            InitializeComponent();
            AddValueToCboBox();
        }
        public void AddValueToCboBox()
        {
            Dictionary<string, int> source = new Dictionary<string, int>();
            source.Add("20 ngày", 20);
            cbSoNgayMuon.DataSource = new BindingSource(source, null);
            cbSoNgayMuon.DisplayMember = "Key";
            cbSoNgayMuon.ValueMember = "value";
            //thuThuBLL.HienThiComboBox(cboThuThu);
        }
        private void btnTaoPhieu_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMaPhieuMuon.Text)) 
            {
                if (!KtraDuLieu.CheckMa(txtMaPhieuMuon.Text))
                    MessageBox.Show("Chỉ nhập số vào ô!", "Mã phiếu mượn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Mã phiếu không được trống", "Mã phiếu mượn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if(!string.IsNullOrEmpty(txtMaDocGia.Text))
            {
                if (!KtraDuLieu.CheckMa(txtMaDocGia.Text))
                    MessageBox.Show("Chỉ nhập số vào ô!", "Mã độc giả", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Mã độc giả không được trống", "Mã độc giả", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (string.IsNullOrEmpty(cboThuThu.Text))
                MessageBox.Show("Vui lòng chọn thủ thư", "Thủ thư", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (dgvDSMuon.DataSource == null)
                MessageBox.Show("Danh sách mượn không được rỗng!", "Danh sách mượn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                phieuMuonBLL.HienThiTienCoc(dgvDSMuon, txtTienCoc);
                if (phieuMuonBLL.ThemPhieuMuon(txtMaPhieuMuon, txtMaDocGia, cboThuThu, dgvDSMuon, txtTienCoc))
                {
                    MessageBox.Show("Tạo phiểu thành công!");
                }
                else
                {
                    MessageBox.Show("Tạo phiếu không thành công, vui lòng nhập lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.ResetText();
                }
            }
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnThemBS_Click(object sender, EventArgs e)
        {
            if (txtMaBanSao.Text != null && !string.IsNullOrEmpty(txtMaBanSao.Text))
            {
                if (KtraDuLieu.CheckMa(txtMaBanSao.Text))
                {
                    if (!banSaoBLL.HienThiDGVTrongPhieuMuon(dgvDSMuon, txtMaBanSao))
                        MessageBox.Show("Không tìm thấy bản sao!");
                    else { };
                }
                else
                {
                    MessageBox.Show("Chỉ nhập số vào ô!", "Mã bản sao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("Xin hãy nhập mã bản sao!", "Mã bản sao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvDSMuon_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void cbSoNgayMuon_SelectedValueChanged(object sender, EventArgs e)
        {
            dtpNgayMuon.Value = DateTime.Now;
            dtpNgayHetHan.Value = dtpNgayMuon.Value.AddDays(20).Date;
        }
    }
}
