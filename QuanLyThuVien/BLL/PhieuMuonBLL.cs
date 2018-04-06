using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThuVien.DAL;

namespace QuanLyThuVien.BLL
{
    class PhieuMuonBLL
    {
        private PhieuMuonDAL phieuMuonDAL = new PhieuMuonDAL();

        public void HienThiDSPhieuMuon(DataGridView dgvListPhieuMuon)
        {
            dgvListPhieuMuon.DataSource = phieuMuonDAL.LayDSPhieuMuon();
        }
        
        public void HienThiTienCoc(DataGridView dgvBanSao, TextBox txtTienCoc)
        {
            double tienCoc = 0;
            for (int i = 0; i < dgvBanSao.RowCount; i++)
            {
                int giaTien = Convert.ToInt16(dgvBanSao.Rows[i].Cells[3].ToString());
                tienCoc = +giaTien * 0.6;
            }
            txtTienCoc.Text = tienCoc.ToString();
        }

        public void TKPhieuMuon(TextBox txtMaPhieuMuon, TextBox txtMaNguoiMuon, ComboBox cbThuThu, DateTimePicker dpNgayMuon, DateTimePicker dpNgayTra, DateTimePicker dpHanTra, DataGridView dgvListPhieuMuon)
        {
            PhieuMuonSach phieuMuon = new PhieuMuonSach();
            phieuMuon.MaPhieuMuon = txtMaPhieuMuon.Text;
            phieuMuon.MaNguoiMuon = txtMaNguoiMuon.Text;
            phieuMuon.MaThuThu = cbThuThu.ValueMember;
            phieuMuon.NgayMuonSach = dpNgayMuon.Value.Date;
            phieuMuon.NgayTraSach = dpNgayTra.Value.Date;
            phieuMuon.HanTraSach = dpHanTra.Value.Date;
            dgvListPhieuMuon.DataSource = phieuMuonDAL.TimKiemPhieuMuon(phieuMuon);
        }

        public bool ThemPhieuMuon(TextBox txtMaPhieuMuon, TextBox txtMaNguoiMuon, ComboBox cbThuThu, DataGridView dgvListBanSao, TextBox txtTienCoc)
        {
            PhieuMuonSach phieuMuon = new PhieuMuonSach();
            phieuMuon.MaPhieuMuon = txtMaPhieuMuon.Text;
            phieuMuon.MaNguoiMuon = txtMaNguoiMuon.Text;
            phieuMuon.MaThuThu = cbThuThu.ValueMember;
            phieuMuon.NgayMuonSach = DateTime.Now.Date;
            phieuMuon.HanTraSach = phieuMuon.NgayMuonSach.AddDays(20).Date;
            for (int i = 0; i < dgvListBanSao.RowCount; i++)
            {
                BanSao banSao = new BanSao();
                banSao.MaBanSao = dgvListBanSao.Rows[i].Cells[0].ToString();

                phieuMuon.BanSaos.Add(banSao);
            }
            phieuMuon.TienDatCoc = Math.Round(Convert.ToDecimal(txtTienCoc.Text), 0);
            phieuMuonDAL.ThemPhieuMuon(phieuMuon);
            return true;
        }

        public bool CapNhatPhieuMuon(TextBox txtMaPhieuMuon, TextBox txtMaNguoiMuon, ComboBox cbThuThu, DateTimePicker dpNgayMuon, DateTimePicker dpNgayTra, DateTimePicker dpHanTra, DataGridView dgvListPhieuMuon)
        {
            PhieuMuonSach phieuMuon = new PhieuMuonSach();
            phieuMuon.MaPhieuMuon = txtMaPhieuMuon.Text;
            phieuMuon.MaNguoiMuon = txtMaNguoiMuon.Text;
            phieuMuon.MaThuThu = cbThuThu.ValueMember;
            phieuMuon.NgayMuonSach = dpNgayMuon.Value.Date;
            phieuMuon.NgayTraSach = dpNgayTra.Value.Date;
            phieuMuon.HanTraSach = dpHanTra.Value.Date;
            phieuMuonDAL.CapNhatPhieuMuon(phieuMuon);
            return true;
        }

        public bool XoaPhieuMuon(DataGridViewRow dgvrPhieuMuon)
        {
            string maPhieuMuon = dgvrPhieuMuon.Cells[0].ToString();
            phieuMuonDAL.XoaPhieuMuon(maPhieuMuon);
            return true;
        }
    }
}
