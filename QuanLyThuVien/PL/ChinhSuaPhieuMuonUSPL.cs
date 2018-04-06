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
        public TextBox TxtMaThuThu
        {
            get { return txtMaThuThu; }
            set { txtMaThuThu = value; }
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
        public ChinhSuaPhieuMuonUSPL()
        {
            InitializeComponent();
        }        
    }
}
