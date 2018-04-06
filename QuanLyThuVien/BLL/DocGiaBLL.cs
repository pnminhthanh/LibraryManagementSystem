using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThuVien.DAL;

namespace QuanLyThuVien.BLL
{
    class DocGiaBLL
    {
        private DocGiaDAL docGiaDAL = new DocGiaDAL();

        public void HienThiDSDocGia(DataGridView dgvListDocGia)
        {
            List<DocGia> listDocGia = docGiaDAL.LayDSDocGia();
            for (int i = 0; i < listDocGia.Count; i++)
            {
                dgvListDocGia.Rows[i].Cells[0].Value = (i + 1).ToString();
                dgvListDocGia.Rows[i].Cells[1].Value = listDocGia[i].MaDocGia;
                dgvListDocGia.Rows[i].Cells[2].Value = listDocGia[i].TenDocGia.ToString();
                dgvListDocGia.Rows[i].Cells[3].Value = listDocGia[i].GioiTinh.ToString();
                dgvListDocGia.Rows[i].Cells[4].Value = listDocGia[i].NgaySinh.ToString();                
                dgvListDocGia.Rows[i].Cells[5].Value = listDocGia[i].SoDienThoai;
            }
        }

        public void TKDocGia(TextBox txtMaDocGia, TextBox txtTenDocGia, DateTimePicker dpNgaySinh, RadioButton rbGioiTinh, TextBox txtSDT, TextBox txtCMND, TextBox txtDiaChi, DateTimePicker dpBatDau, DateTimePicker dpKetThuc, DataGridView dgvListDocGia)
        {
            DocGia docGia = new DocGia();
            docGia.MaDocGia = txtMaDocGia.Text;
            docGia.TenDocGia = txtTenDocGia.Text;
            docGia.NgaySinh = dpNgaySinh.Value.Date;
            docGia.GioiTinh = rbGioiTinh.Text;
            docGia.SoDienThoai = txtSDT.Text;
            docGia.SoCMND = txtCMND.Text;
            docGia.DiaChi = txtDiaChi.Text;
            docGia.NgayBatDau = dpBatDau.Value.Date;
            docGia.NgayKetThuc = dpKetThuc.Value.Date;
            dgvListDocGia.DataSource = docGiaDAL.TimKiemDocGia(docGia);
        }

        public bool ThemDocGia(TextBox txtMaDocGia, TextBox txtTenDocGia, DateTimePicker dpNgaySinh, RadioButton rbGioiTinh, TextBox txtSDT, TextBox txtCMND, TextBox txtDiaChi)
        {
            DocGia docGia = new DocGia();
            docGia.MaDocGia = txtMaDocGia.Text;
            docGia.TenDocGia = txtTenDocGia.Text;
            docGia.NgaySinh = dpNgaySinh.Value.Date;
            docGia.GioiTinh = rbGioiTinh.Text;
            docGia.SoDienThoai = txtSDT.Text;
            docGia.SoCMND = txtCMND.Text;
            docGia.DiaChi = txtDiaChi.Text;
            docGia.NgayBatDau = DateTime.Now.Date;
            docGia.NgayKetThuc = docGia.NgayBatDau.AddYears(1).Date;
            docGiaDAL.ThemDocGia(docGia);
            return true;
        }

        public bool CapNhatDocGia(TextBox txtMaDocGia, TextBox txtTenDocGia, DateTimePicker dpNgaySinh, RadioButton rbGioiTinh, TextBox txtSDT, TextBox txtCMND, TextBox txtDiaChi, DateTimePicker dpBatDau)
        {
            DocGia docGia = new DocGia();
            docGia.MaDocGia = txtMaDocGia.Text;
            docGia.TenDocGia = txtTenDocGia.Text;
            docGia.NgaySinh = dpNgaySinh.Value.Date;
            docGia.GioiTinh = rbGioiTinh.Text;
            docGia.SoDienThoai = txtSDT.Text;
            docGia.SoCMND = txtCMND.Text;
            docGia.DiaChi = txtDiaChi.Text;
            docGia.NgayBatDau = dpBatDau.Value.Date;
            docGia.NgayKetThuc = docGia.NgayBatDau.AddYears(1).Date;
            docGiaDAL.CapNhatDocGia(docGia);
            return true;
        }

        public bool XoaDocGia(DataGridViewRow dgvrDocGia)
        {
            string maDocGia = dgvrDocGia.Cells[0].ToString();
            docGiaDAL.XoaDocGia(maDocGia);
            return true;
        }
    }
}
