using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThuVien.DAL;

namespace QuanLyThuVien.BLL
{
    class ThuThuBLL
    {
        private ThuThuDAL thuThuDAL = new ThuThuDAL();

        public void HienThiDataGridView(DataGridView dgvListThuThu)
        {
            dgvListThuThu.DataSource = thuThuDAL.LayDSthuThu();
        }

        public void HienThiComboBox(ComboBox cbThuThu)
        {
            cbThuThu.DataSource = thuThuDAL.LayDSthuThu();
            cbThuThu.DisplayMember = "TenThuThu";
            cbThuThu.ValueMember = "MaThuThu";
        }

        public void TKthuThu(TextBox txtMaThuThu, TextBox txtTenThuThu, DateTimePicker dpNgaySinh, RadioButton rbGioiTinh, TextBox txtSDT, TextBox txtCMND, TextBox txtDiaChi, DataGridView dgvListThuThu)
        {
            ThuThu thuThu = new ThuThu();
            thuThu.MaThuThu = txtMaThuThu.Text;
            thuThu.TenThuThu = txtTenThuThu.Text;
            thuThu.NgaySinh = dpNgaySinh.Value.Date;
            thuThu.GioiTinh = rbGioiTinh.Text;
            thuThu.SoDienThoai = txtSDT.Text;
            thuThu.SoCMND = txtCMND.Text;
            thuThu.DiaChi = txtDiaChi.Text;
            dgvListThuThu.DataSource = thuThuDAL.TimKiemThuThu(thuThu);
        }

        public bool ThemThuThu(TextBox txtMaThuThu, TextBox txtTenThuThu, DateTimePicker dpNgaySinh, RadioButton rbGioiTinh, TextBox txtSDT, TextBox txtCMND, TextBox txtDiaChi)
        {
            ThuThu thuThu = new ThuThu();
            thuThu.MaThuThu = txtMaThuThu.Text;
            thuThu.TenThuThu = txtTenThuThu.Text;
            thuThu.NgaySinh = dpNgaySinh.Value.Date;
            thuThu.GioiTinh = rbGioiTinh.Text;
            thuThu.SoDienThoai = txtSDT.Text;
            thuThu.SoCMND = txtCMND.Text;
            thuThu.DiaChi = txtDiaChi.Text;
            thuThuDAL.ThemThuThu(thuThu);
            return true;
        }

        public bool CapNhatThuThu(TextBox txtMaThuThu, TextBox txtTenThuThu, DateTimePicker dpNgaySinh, RadioButton rbGioiTinh, TextBox txtSDT, TextBox txtCMND, TextBox txtDiaChi)
        {
            ThuThu thuThu = new ThuThu();
            thuThu.MaThuThu = txtMaThuThu.Text;
            thuThu.TenThuThu = txtTenThuThu.Text;
            thuThu.NgaySinh = dpNgaySinh.Value.Date;
            thuThu.GioiTinh = rbGioiTinh.Text;
            thuThu.SoDienThoai = txtSDT.Text;
            thuThu.SoCMND = txtCMND.Text;
            thuThu.DiaChi = txtDiaChi.Text;
            thuThuDAL.ThemThuThu(thuThu);
            return true;
        }

        public bool XoaThuThu(DataGridViewRow dgvrThuThu)
        {
            string maThuthu = dgvrThuThu.Cells[0].ToString();
            thuThuDAL.XoaThuThu(maThuthu);
            return true;
        }
    }
}
