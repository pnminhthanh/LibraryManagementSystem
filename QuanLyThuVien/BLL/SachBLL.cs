using System.Collections.Generic;
using QuanLyThuVien.DAL;
using System.Windows.Forms;
using System;
using System.IO;

namespace QuanLyThuVien.BLL
{
    class SachBLL
    {
        private SachDAL sachDAL = new SachDAL();

        public void HienThiDSSach(DataGridView  dgvListSach)
        {
            List<Sach> listSach = sachDAL.LayDSSach();
            for (int i = 0; i < listSach.Count; i++)
            {
                dgvListSach.Rows[i].Cells[0].Value = (i + 1).ToString();
                dgvListSach.Rows[i].Cells[1].Value = listSach[i].MaSach;
                dgvListSach.Rows[i].Cells[2].Value = listSach[i].TenSach;
                dgvListSach.Rows[i].Cells[3].Value = listSach[i].TacGia.TenTacGia;
                dgvListSach.Rows[i].Cells[4].Value = listSach[i].NamXuatBan;
                dgvListSach.Rows[i].Cells[5].Value = listSach[i].NhaXuatBan;
                dgvListSach.Rows[i].Cells[5].Value = String.Format("{0:#,#}", listSach[i].GiaTien);
            }
        }

        public void HienThiDSSachTheoTacGia(DataGridView dgvListSach, TextBox txtMaTacGia)
        {
            dgvListSach.DataSource = sachDAL.LayDSSachTheoTacGia(txtMaTacGia.Text);
        }

        public void HienThiDSSachTheoTheLoai(DataGridView dgvListSach, List<int> listMaTL)
        {
            dgvListSach.DataSource = sachDAL.LayDSSachTheoTheLoai(listMaTL);
        }

        public bool ThemSachMoi(TextBox txtMaSach, TextBox txtTenSach, TextBox txtNXB, TextBox txtGia, TextBox txtNamXB, ComboBox cbTacGia, List<ComboBox> listCbTheLoai, TextBox txtTomTat, OpenFileDialog ofdBiaSach)
        {
            Sach sach = new Sach();
            sach.MaSach = txtMaSach.Text;
            sach.TenSach = txtTenSach.Text;
            sach.NhaXuatBan = txtNXB.Text;
            sach.GiaTien = Convert.ToInt16(txtGia.Text);
            int namXB = Convert.ToInt16(txtNamXB.Text);
            if (namXB <= 0 || namXB >= DateTime.Now.Year)
            {
                return false;
            }
            sach.NamXuatBan = namXB;
            sach.MaTacGia = cbTacGia.ValueMember;
            foreach (var item in listCbTheLoai)
            {
                TheLoai theLoai = new TheLoai();
                theLoai.MaTheLoai = item.ValueMember;
                sach.TheLoais.Add(theLoai);
            }
            sach.TomTatNoiDung = txtTomTat.Text;
            if (ofdBiaSach.FileName != "openFileDialog1")
            {
                string fileName = ofdBiaSach.FileName;
                string location = Path.Combine("..\\pic", Path.GetFileName(fileName));
                File.Copy(fileName, location, true);
            }
            sachDAL.ThemSach(sach);
            return true;
        }

        public bool SuaThongTinSach(TextBox txtMaSach, TextBox txtTenSach, TextBox txtNXB, TextBox txtGia, TextBox txtNamXB, ComboBox cbTacGia, List<ComboBox> listCbTheLoai, TextBox txtTomTat, OpenFileDialog ofdBiaSach)
        {
            Sach sach = new Sach();
            sach.MaSach = txtMaSach.Text;
            sach.TenSach = txtTenSach.Text;
            sach.NhaXuatBan = txtNXB.Text;
            sach.GiaTien = Convert.ToInt16(txtGia.Text);
            int namXB = Convert.ToInt16(txtNamXB.Text);
            if (namXB <= 0 || namXB >= DateTime.Now.Year)
            {
                return false;
            }
            sach.NamXuatBan = namXB;
            sach.MaTacGia = cbTacGia.ValueMember;
            foreach (var item in sach.TheLoais)
            {
                int i = 0;
                item.MaTheLoai = listCbTheLoai[i].ValueMember;
            }
            sach.TomTatNoiDung = txtTomTat.Text;
            if (ofdBiaSach.FileName != "openFileDialog1")
            {
                string fileName = ofdBiaSach.FileName;
                string location = Path.Combine("..\\pic", Path.GetFileName(fileName));
                File.Copy(fileName, location, true);
            }
            sachDAL.CapNhatSach(sach);
            return true;
        }

        public bool XoaSach(DataGridViewRow dgvrSach)
        {
            string maSach = dgvrSach.Cells[0].ToString();
            sachDAL.XoaSach(maSach);
            return true;
        }
    }
}
