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
        public DateTimePicker dtpNamSinh
        {
            get { return dtpNgaySinhTG; }
            set { dtpNgaySinhTG = value; }
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
            get { return txtTenTheLoai; }
            set { txtTenTheLoai = value; }
        }
        public DataGridView DgvDSTheLoai
        {
            get { return dgvDSTheLoai; }
            set { dgvDSTheLoai = value; }
        }
        #endregion
        #endregion

        DataGridViewRow row;
        SachBLL sachBLL = new SachBLL();
        KeSachBLL keSachBLL = new KeSachBLL();
        TacGiaBLL tacGiaBLL = new TacGiaBLL();
        TheLoaiBLL theLoaiBLL = new TheLoaiBLL();
        BanSaoBLL banSaoBLL = new BanSaoBLL();

        public ChinhSuaSachUSPL()
        {
            InitializeComponent();
        }

        #region TabSach
        
        private void tabPageSach_Enter(object sender, EventArgs e)
        {
            keSachBLL.HienThiComboBox(cbMaKe);
            tacGiaBLL.HienThiComboBox(cbTacGia);
            theLoaiBLL.HienThiComboBox(cbTheLoai1);
            theLoaiBLL.HienThiComboBox(cbTheLoai2);
            theLoaiBLL.HienThiComboBox(cbTheLoai3);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KtraDuLieu.CheckMa(txtMaSach.Text))
            {
                MessageBox.Show("Mã sách không hợp lệ!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (!KtraDuLieu.CheckTien(TxtGiaTien.Text))
                {
                    MessageBox.Show("Giá tiền không hợp lệ!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (!KtraDuLieu.CheckNam(txtNamXuatBan.Text))
                    {
                        MessageBox.Show("Năm xuất bản không hợp lệ!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (!KtraDuLieu.CheckMa(txtSoBanSao.Text))
                        {
                            MessageBox.Show("Số bản sao không hợp lệ!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            List<ComboBox> listCbTheLoai = new List<ComboBox> { cbTheLoai1, cbTheLoai2, cbTheLoai3 };
                            if ((banSaoBLL.ThemBanSao(txtMaSach, txtMaSach)) && (sachBLL.ThemSachMoi(txtMaSach, txtTenSach, txtNhaXuatBan, txtGiaTien, txtNamXuatBan, cbTacGia, listCbTheLoai, rtxtNoiDung, openFileDialog1)))
                            {
                                MessageBox.Show("Thêm bản sao thành công");
                            }
                            else MessageBox.Show("Thao tác thất bại! Mời nhập lại.");
                        }
                    }
                }                
            }
        }
        
        private void btnTaoBanSao_Click(object sender, EventArgs e)
        {
            if (!KtraDuLieu.CheckMa(txtMaSach.Text))
            {
                MessageBox.Show("Mã sách không hợp lệ!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (!KtraDuLieu.CheckMa(txtSoBanSao.Text))
                {
                    MessageBox.Show("Số bản sao không hợp lệ!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (banSaoBLL.ThemBanSao(txtMaSach, txtSoBanSao))
                    {
                        MessageBox.Show("Thêm bản sao thành công");
                    }
                    else MessageBox.Show("Thao tác thất bại! Mời nhập lại.");
                }                
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!KtraDuLieu.CheckMa(txtMaSach.Text))
            {
                MessageBox.Show("Mã sách không hợp lệ!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (!KtraDuLieu.CheckTien(TxtGiaTien.Text))
                {
                    MessageBox.Show("Giá tiền không hợp lệ!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (!KtraDuLieu.CheckNam(txtNamXuatBan.Text))
                    {
                        MessageBox.Show("Năm xuất bản không hợp lệ!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (!KtraDuLieu.CheckMa(txtSoBanSao.Text))
                        {
                            MessageBox.Show("Số bản sao không hợp lệ!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            List<ComboBox> listCbTheLoai = new List<ComboBox> { cbTheLoai1 };
                            if ((sachBLL.SuaThongTinSach(txtMaSach, txtTenSach, txtNhaXuatBan, txtGiaTien, txtNamXuatBan, cbTacGia, listCbTheLoai, rtxtNoiDung, openFileDialog1)))
                            {
                                MessageBox.Show("Thêm bản sao thành công");
                            }
                            else MessageBox.Show("Thao tác thất bại! Mời nhập lại.");
                        }
                    }
                }
            }
        }
        
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult confirm = new DialogResult();
            confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                if (sachBLL.XoaSach(txtMaSach))
                {
                    MessageBox.Show("Xóa sách thành công");
                }
                else MessageBox.Show("Thao tác thất bại! Mời thao tác lại.");
            }
        }
        
        private void btnTimAnh_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fulllocimage = openFileDialog1.FileName;
                pbBiaSach.ImageLocation = fulllocimage;
            }
        }
        #endregion

        #region TabViTri
        private void btnThemKe_Click(object sender, EventArgs e)
        {
            if (!KtraDuLieu.CheckMa(txtMaKe.Text))
            {
                MessageBox.Show("Mã kệ sách không hợp lệ!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (keSachBLL.ThemKeMoi(txtMaKe, txtChuDe))
                {
                    MessageBox.Show("Thêm kệ thành công");
                    UpdateDGVKeSach();
                }
                else MessageBox.Show("Thao tác thất bại! Mời nhập lại.");
            }
        }

        private void btnSuaKe_Click(object sender, EventArgs e)
        {
            if (KtraDuLieu.CheckMa(txtMaKe.Text))
            {
                MessageBox.Show("Mã kệ sách không hợp lệ!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (keSachBLL.SuaThongTinSach(txtMaKe, txtChuDe))
                    MessageBox.Show("Sửa kệ sách thành công");
                else MessageBox.Show("Thao tác thất bại! Mời nhập lại.");
            }
            UpdateDGVKeSach();
        }

        private void btnXoaKe_Click(object sender, EventArgs e)
        {
            DialogResult confirm = new DialogResult();
            confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                if (keSachBLL.XoaKeSach(txtMaKe))
                {
                    MessageBox.Show("Xóa kệ sách thành công");
                    UpdateDGVKeSach();
                }
                else MessageBox.Show("Thao tác thất bại! Mời thao tác lại.");
            }            
        }

        private void UpdateDGVKeSach()
        {
            dgvDSKeSach.DataSource = null;
            keSachBLL.HienThiDataGridView(dgvDSKeSach);
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            UpdateDGVKeSach();
        }

        private void dgvDSKeSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = dgvDSKeSach.Rows[e.RowIndex];
            keSachBLL.HienThiKeSach(txtMaKe, TxtTenChuDe, row);
        }

        #endregion

        #region TabTacGia
        private void UpdateDGVTacGia()
        {
            dgvDSTacGia.DataSource = null;
            tacGiaBLL.HienThiDataGridView(dgvDSTacGia);
        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            UpdateDGVTacGia();
        }

        private void btnThemTG_Click(object sender, EventArgs e)
        {
            if (!KtraDuLieu.CheckMa(txtMaTacGia.Text))
            {
                MessageBox.Show("Mã sách không hợp lệ!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (!KtraDuLieu.CheckNgay(dtpNgaySinhTG.Value))
                {
                    MessageBox.Show("Ngày sinh không hợp lệ!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (rbtnNam.Checked || rbtnNu.Checked)
                    {
                        MessageBox.Show("Giới tính không hợp lệ!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {                        
                        if (tacGiaBLL.ThemTacGia(txtMaTacGia, txtTenTacGia, dtpNgaySinhTG, rbtnNam, rbtnNu))
                        {
                            MessageBox.Show("Thêm tác giả thành công");
                            UpdateDGVTacGia();
                        }
                        else MessageBox.Show("Thao tác thất bại! Mời nhập lại.");
                    }
                }
            }
        }

        private void btnSuaTG_Click(object sender, EventArgs e)
        {
            if (!KtraDuLieu.CheckMa(txtMaTacGia.Text))
            {
                MessageBox.Show("Mã sách không hợp lệ!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (!KtraDuLieu.CheckNgay(dtpNgaySinhTG.Value))
                {
                    MessageBox.Show("Ngày sinh không hợp lệ!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (rbtnNam.Checked || rbtnNu.Checked)
                    {
                        MessageBox.Show("Giới tính không hợp lệ!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (tacGiaBLL.CapNhatTacGia(txtMaTacGia, txtTenTacGia, dtpNgaySinhTG, rbtnNam, rbtnNu))
                        {
                            MessageBox.Show("Sửa tác giả thành công");
                            UpdateDGVTacGia();
                        }
                        else MessageBox.Show("Thao tác thất bại! Mời nhập lại.");
                    }
                }
            }
        }

        private void btnXoaTG_Click(object sender, EventArgs e)
        {
            DialogResult confirm = new DialogResult();
            confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                if (tacGiaBLL.XoaTacGia(TxtMaTacGia))
                {
                    MessageBox.Show("Xóa tác giả thành công");
                    UpdateDGVTacGia();
                }
                else MessageBox.Show("Thao tác thất bại! Mời thao tác lại.");
            }
        }

        private void dgvDSTacGia_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = dgvDSTacGia.Rows[e.RowIndex];
            tacGiaBLL.HienThiTacGia(txtMaTacGia, txtTenTacGia, dtpNgaySinhTG, rbtnNam, rbtnNu, row);
        }

        #endregion

        #region TabTheLoai
        private void tabPage4_Enter(object sender, EventArgs e)
        {
            UpdateDGVTheLoai();
        }

        public void UpdateDGVTheLoai()
        {
            DgvDSTheLoai.DataSource = null;
            theLoaiBLL.HienThiDataGridView(DgvDSTheLoai);
        }

        private void btnThemTL_Click(object sender, EventArgs e)
        {
            if (!KtraDuLieu.CheckMa(txtMaChuDe.Text))
            {
                MessageBox.Show("Mã thể loại không hợp lệ!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (theLoaiBLL.ThemTheLoai(txtMaChuDe, txtTenTheLoai))
                {
                    MessageBox.Show("Thêm thể loại thành công");
                    UpdateDGVTheLoai();
                }
                else MessageBox.Show("Thao tác thất bại! Mời nhập lại.");
            }
        }

        private void btnSuaTL_Click(object sender, EventArgs e)
        {
            if (KtraDuLieu.CheckMa(txtMaChuDe.Text))
            {
                MessageBox.Show("Mã thể loại không hợp lệ!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (theLoaiBLL.SuaThongTin(txtMaChuDe, txtTenTheLoai))
                    MessageBox.Show("Sửa thể loại thành công");
                else MessageBox.Show("Thao tác thất bại! Mời nhập lại.");
            }
            UpdateDGVKeSach();
        }

        private void btnXoaTL_Click(object sender, EventArgs e)
        {
            DialogResult confirm = new DialogResult();
            confirm = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                if (theLoaiBLL.XoaTheLoai(txtMaChuDe))
                {
                    MessageBox.Show("Xóa thể loại thành công");
                    UpdateDGVTheLoai();
                }
                else MessageBox.Show("Thao tác thất bại! Mời thao tác lại.");
            }
        }

        private void dgvDSTheLoai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = DgvDSTheLoai.Rows[e.RowIndex];
            theLoaiBLL.LayTLTheoMa(txtMaChuDe, txtTenTheLoai, row);
        }
        #endregion

    }
}
