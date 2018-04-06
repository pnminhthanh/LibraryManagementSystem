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
    public partial class ChinhSuaSachUSPL : UserControl
    {
        #region Property
        # region ViTri
        public TextBox TxtMaKe
        {
            get { return txtMaKe; }
            set { txtMaKe = value; }
        }
        public TextBox TxtChuDe
        {
            get { return txtChuDe; }
            set { txtChuDe = value; }
        }
        public DataGridView DgvDSKe
        {
            get { return dgvDSKeSach; }
            set { dgvDSKeSach = value; }
        }
        #endregion
        #region Sach
        public TextBox TxtMaSach
        {
            get { return txtMaSach; }
            set { txtMaSach = value; }
        }
        public TextBox TxtTenSach
        {
            get { return txtTenSach; }
            set { txtTenSach = value; }
        }
        public TextBox TxtNhaXuatBan
        {
            get { return txtNamXuatBan; }
            set { txtNamXuatBan = value; }
        }
        public TextBox TxtGiaTien
        {
            get { return txtGiaTien; }
            set { txtGiaTien = value; }
        }
        public TextBox TxtNamXuatBan
        {
            get { return txtNamXuatBan; }
            set { txtNamXuatBan = value; }
        }
        public TextBox TxtSoBanSao
        {
            get { return txtSoBanSao; }
            set { txtSoBanSao = value; }
        }
        public ComboBox CbTacGia
        {
            get { return cbTacGia; }
            set { cbTacGia = value; }
        }
        public ComboBox CbTheLoai
        {
            get { return cbTheLoai1; }
            set { cbTheLoai1 = value; }
        }       
        public RichTextBox RtxtNoiDung
        {
            get { return rtxtNoiDung; }
            set { rtxtNoiDung = value; }
        }
        public PictureBox PbBiaSach
        {
            get { return pbBiaSach; }
            set { pbBiaSach = value; }
        }
        #endregion
        #region Tac Gia
        public TextBox TxtMaTacGia
        {
            get { return txtMaTacGia; }
            set { txtMaTacGia = value; }
        }
        public TextBox TxtTenTacGia
        {
            get { return txtTenTacGia; }
            set { txtTenTacGia = value; }
        }
        public TextBox TxtNamSinh
        {
            get { return txtNamSinh; }
            set { txtNamSinh = value; }
        }
        public RadioButton RbtnNam
        {
            get { return rbtnNam; }
            set { rbtnNam = value; }
        }
        public RadioButton RbtnNu
        {
            get { return rbtnNu; }
            set { rbtnNam = value; }
        }
        public DataGridView DgvDSTacGia
        {
            get { return dgvDSTacGia; }
            set { dgvDSTacGia = value; }
        }
        #endregion
        #region The Loai Sach
        public TextBox TxtMaTheLoai
        {
            get { return txtMaChuDe; }
            set { txtMaChuDe = value; }
        }
        public TextBox TxtTenChuDe
        {
            get { return txtTenChuDe; }
            set { txtTenChuDe = value; }
        }
        public DataGridView DgvDSTheLoai
        {
            get { return dgvDSTheLoai; }
            set { dgvDSTheLoai = value; }
        }
        #endregion
        #endregion
        public ChinhSuaSachUSPL()
        {
            InitializeComponent();
        }
        #region TabSach
        private void btnThem_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region TabViTri

        #endregion

        private void btnThemKe_Click(object sender, EventArgs e)
        {

        }

        private void btnSuaKe_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaKe_Click(object sender, EventArgs e)
        {

        }
    }
}
