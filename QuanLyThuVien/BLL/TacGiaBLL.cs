using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThuVien.DAL;

namespace QuanLyThuVien.BLL
{
    class TacGiaBLL
    {
        private TacGiaDAL tacGiaDAL = new TacGiaDAL();

        public void HienThiDSTacGia(DataGridView dgvListTacGia)
        {
            List<TacGia> listTacGia = tacGiaDAL.LayDSTacGia();
            for (int i = 0; i < listTacGia.Count; i++)
            {
                dgvListTacGia.Rows[i].Cells[0].Value = (i + 1).ToString();
                dgvListTacGia.Rows[i].Cells[1].Value = listTacGia[i].MaTacGia;
                dgvListTacGia.Rows[i].Cells[2].Value = listTacGia[i].TenTacGia;
                dgvListTacGia.Rows[i].Cells[3].Value = listTacGia[i].GioiTinh;
                dgvListTacGia.Rows[i].Cells[4].Value = listTacGia[i].NgaySinh.ToString();
            }
        }

        public void TKTacGia(TextBox txtMaTacGia, TextBox txtTenTacGia, DateTimePicker dpNgaySinh, RadioButton rbGioiTinh, DataGridView dgvListTacGia)
        {
            TacGia tacGia = new TacGia();
            tacGia.MaTacGia = txtMaTacGia.Text;
            tacGia.TenTacGia = txtTenTacGia.Text;
            tacGia.NgaySinh = dpNgaySinh.Value.Date;
            tacGia.GioiTinh = rbGioiTinh.Text;
            dgvListTacGia.DataSource = tacGiaDAL.TimKiemTacGia(tacGia);
        }

        public bool ThemTacGia(TextBox txtMaTacGia, TextBox txtTenTacGia, DateTimePicker dpNgaySinh, RadioButton rbGioiTinh)
        {
            TacGia tacGia = new TacGia();
            tacGia.MaTacGia = txtMaTacGia.Text;
            tacGia.TenTacGia = txtTenTacGia.Text;
            tacGia.NgaySinh = dpNgaySinh.Value.Date;
            tacGia.GioiTinh = rbGioiTinh.Text;
            tacGiaDAL.ThemTacGia(tacGia);
            return true;
        }

        public bool CapNhatDocGia(TextBox txtMaTacGia, TextBox txtTenTacGia, DateTimePicker dpNgaySinh, RadioButton rbGioiTinh)
        {
            TacGia tacGia = new TacGia();
            tacGia.MaTacGia = txtMaTacGia.Text;
            tacGia.MaTacGia = txtMaTacGia.Text;
            tacGia.NgaySinh = dpNgaySinh.Value.Date;
            tacGia.GioiTinh = rbGioiTinh.Text;
            tacGiaDAL.CapNhatTacGia(tacGia);
            return true;
        }

        public bool XoaTacGia(DataGridViewRow dgvrTacGia)
        {
            string maTacGia = dgvrTacGia.Cells[0].ToString();
            tacGiaDAL.XoaTacGia(maTacGia);
            return true;
        }
    }
}
