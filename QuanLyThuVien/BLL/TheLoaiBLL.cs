using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThuVien.DAL;

namespace QuanLyThuVien.BLL
{
    class TheLoaiBLL
    {
        private TheLoaiDAL TheLoaiDAL = new TheLoaiDAL();

        public void HienThiDataGridView(DataGridView dgvListTheLoai)
        {
            List<TheLoai> listTheLoai = TheLoaiDAL.LayDSTheLoai();
            for (int i = 0; i < listTheLoai.Count; i++)
            {
                dgvListTheLoai.Rows[i].Cells[0].Value = (i + 1).ToString();
                dgvListTheLoai.Rows[i].Cells[1].Value = listTheLoai[i].MaTheLoai;
                dgvListTheLoai.Rows[i].Cells[2].Value = listTheLoai[i].TenTheLoai;
            }
        }

        public void HienThiComboBox(ComboBox cbTheLoai)
        {
            cbTheLoai.DataSource = TheLoaiDAL.LayDSTheLoai();
            cbTheLoai.DisplayMember = "TenTheLoai";
            cbTheLoai.ValueMember = "MaTheLoai";
        }

        public bool ThemtheLoai(TextBox txtMaTheLoai, TextBox txtTenTheLoai)
        {
            TheLoai theLoai = new TheLoai();
            theLoai.MaTheLoai = txtMaTheLoai.Text;
            theLoai.TenTheLoai = txtTenTheLoai.Text;
            TheLoaiDAL.ThemTheLoai(theLoai);
            return true;
        }

        public bool SuaThongTin(TextBox txtMatheLoai, TextBox txtTenTheLoai)
        {
            TheLoai theLoai = new TheLoai();
            theLoai.MaTheLoai = txtMatheLoai.Text;
            theLoai.TenTheLoai = txtTenTheLoai.Text;
            TheLoaiDAL.CapNhatTheLoai(theLoai);
            return true;
        }

        public bool XoaKeSach(DataGridViewRow dgvrKeSach)
        {
            string maKeSach = dgvrKeSach.Cells[1].ToString();
            TheLoaiDAL.XoaKeSach(maKeSach);
            return true;
        }
    }
}
