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

        public void HienThiDataGridView(DataGridView dgvListTacGia)
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

        public void HienThiComboBox(ComboBox cbTacGia)
        {
            cbTacGia.DataSource = tacGiaDAL.LayDSTacGia();
            cbTacGia.DisplayMember = "TenTacGia";
            cbTacGia.ValueMember = "MaTacGia";
        }

        public void TKTacGia(TextBox txtMaTacGia, TextBox txtTenTacGia, DateTimePicker dpNgaySinh, RadioButton rbNam, RadioButton rbNu, DataGridView dgvListTacGia)
        {
            TacGia tacGia = new TacGia();
            tacGia.MaTacGia = txtMaTacGia.Text;
            tacGia.TenTacGia = txtTenTacGia.Text;
            tacGia.NgaySinh = dpNgaySinh.Value.Date;
            if (rbNam.Checked)
                tacGia.GioiTinh = rbNam.Text;
            else tacGia.GioiTinh = rbNu.Text;
            dgvListTacGia.DataSource = tacGiaDAL.TimKiemTacGia(tacGia);
        }

        public bool ThemTacGia(TextBox txtMaTacGia, TextBox txtTenTacGia, DateTimePicker dpNgaySinh, RadioButton rbNam, RadioButton rbNu)
        {
            TacGia tacGia = new TacGia();
            tacGia.MaTacGia = txtMaTacGia.Text;
            tacGia.TenTacGia = txtTenTacGia.Text;
            tacGia.NgaySinh = dpNgaySinh.Value.Date;
            if (rbNam.Checked)
                tacGia.GioiTinh = rbNam.Text;
            else tacGia.GioiTinh = rbNu.Text;
            tacGiaDAL.ThemTacGia(tacGia);
            return true;
        }

        public bool CapNhatTacGia(TextBox txtMaTacGia, TextBox txtTenTacGia, DateTimePicker dpNgaySinh, RadioButton rbNam, RadioButton rbNu)
        {
            TacGia tacGia = new TacGia();
            tacGia.MaTacGia = txtMaTacGia.Text;
            tacGia.MaTacGia = txtMaTacGia.Text;
            tacGia.NgaySinh = dpNgaySinh.Value.Date;
            if (rbNam.Checked)
                tacGia.GioiTinh = rbNam.Text;
            else tacGia.GioiTinh = rbNu.Text;
            tacGiaDAL.CapNhatTacGia(tacGia);
            return true;
        }

        public bool XoaTacGia(TextBox txtMaTacGia)
        {
            tacGiaDAL.XoaTacGia(txtMaTacGia.Text);
            return true;
        }

        public void HienThiTacGia(TextBox txtMaTacGia, TextBox txtTenTacGia, DateTimePicker dpNgaySinh, RadioButton rbNam, RadioButton rbNu, DataGridViewRow dgvrTacGia)
        {
            TacGia tacGia = tacGiaDAL.LayTGTheoMa(dgvrTacGia.Cells[1].Value.ToString());
            txtMaTacGia.Text = tacGia.MaTacGia;
            txtTenTacGia.Text = tacGia.TenTacGia;
            dpNgaySinh.Value = tacGia.NgaySinh.Value;
            if (tacGia.GioiTinh == "Nam")
                rbNam.Checked = true;
            else rbNu.Checked = false;
        }
    }
}
