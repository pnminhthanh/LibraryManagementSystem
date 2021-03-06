﻿using System;
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
            List<PhieuMuonSach> listPhieuMuon = phieuMuonDAL.LayDSPhieuMuon();
            for (int i = 0; i < listPhieuMuon.Count; i++)
            {
                dgvListPhieuMuon.Rows[i].Cells[0].Value = (i + 1).ToString();
                dgvListPhieuMuon.Rows[i].Cells[1].Value = listPhieuMuon[i].MaPhieuMuon;
                dgvListPhieuMuon.Rows[i].Cells[2].Value = listPhieuMuon[i].DocGia.TenDocGia;
                dgvListPhieuMuon.Rows[i].Cells[3].Value = listPhieuMuon[i].NgayMuonSach;
                dgvListPhieuMuon.Rows[i].Cells[4].Value = listPhieuMuon[i].HanTraSach;
                if (listPhieuMuon[i].NgayTraSach != DateTime.MinValue)
                {
                    dgvListPhieuMuon.Rows[i].Cells[5].Selected = true;
                }                
            }
        }
        
        public void HienThiTienCoc(DataGridView dgvBanSao, TextBox txtTienCoc)
        {
            double tienCoc = 0;
            for (int i = 0; i < dgvBanSao.RowCount; i++)
            {
                int giaTien = Convert.ToInt16(dgvBanSao.Rows[i].Cells[3].ToString());
                tienCoc = +giaTien * 0.6;
            }
            txtTienCoc.Text = String.Format("{0:#,#}", tienCoc);
        }

        public PhieuMuonSach LayPhieuMuonDGV(DataGridViewRow row)
        {
            PhieuMuonSach item = new PhieuMuonSach();
            if (row.Cells[1].Value != null)
            {
                item.MaNguoiMuon = row.Cells[0].Value.ToString();
            }
            else return item;
            item.MaNguoiMuon = "none";
            item.NgayMuonSach = Convert.ToDateTime(01 / 01 / 01);
            item.HanTraSach = Convert.ToDateTime(01 / 01 / 01);
            return phieuMuonDAL.TimKiemPhieuMuon(item)[0];
        }

        public bool TraPhieuMuon(DataGridViewRow row)
        {
            PhieuMuonSach item = LayPhieuMuonDGV(row);
            item.HanTraSach = DateTime.Now.Date;
            phieuMuonDAL.CapNhatPhieuMuon(item);
            return true;
        }

        public void TKPhieuMuon(TextBox txtMaPhieuMuon, TextBox txtMaNguoiMuon, DateTimePicker dpNgayMuon, DateTime ngayTra , DateTimePicker dpHanTra, DataGridView dgvListPhieuMuon)
        {
            PhieuMuonSach phieuMuon = new PhieuMuonSach();
            phieuMuon.MaPhieuMuon = txtMaPhieuMuon.Text;
            phieuMuon.MaNguoiMuon = txtMaNguoiMuon.Text;
            phieuMuon.NgayMuonSach = dpNgayMuon.Value.Date;
            phieuMuon.NgayTraSach = ngayTra;
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
            decimal tienCoc = decimal.Parse(txtTienCoc.Text, System.Globalization.NumberStyles.AllowThousands);
            phieuMuon.TienDatCoc = Math.Round(Convert.ToDecimal(txtTienCoc.Text), 0);
            phieuMuonDAL.ThemPhieuMuon(phieuMuon);
            return true;
        }

        public bool CapNhatPhieuMuon(TextBox txtMaPhieuMuon, TextBox txtMaNguoiMuon, ComboBox cbThuThu, DateTimePicker dpNgayMuon, DateTimePicker dpNgayTra, DateTimePicker dpHanTra, DataGridView dgvListBanSao,TextBox txtTienCoc)
        {
            PhieuMuonSach phieuMuon = new PhieuMuonSach();
            phieuMuon.MaPhieuMuon = txtMaPhieuMuon.Text;
            phieuMuon.MaNguoiMuon = txtMaNguoiMuon.Text;
            phieuMuon.MaThuThu = cbThuThu.ValueMember;
            phieuMuon.NgayMuonSach = dpNgayMuon.Value.Date;
            phieuMuon.NgayTraSach = dpNgayTra.Value.Date;
            phieuMuon.HanTraSach = dpHanTra.Value.Date;
            for (int i = 0; i < dgvListBanSao.RowCount; i++)
            {
                BanSao banSao = new BanSao();
                banSao.MaBanSao = dgvListBanSao.Rows[i].Cells[0].ToString();
                phieuMuon.BanSaos.Add(banSao);
            }
            decimal tienCoc = decimal.Parse(txtTienCoc.Text, System.Globalization.NumberStyles.AllowThousands);
            phieuMuon.TienDatCoc = Math.Round(Convert.ToDecimal(txtTienCoc.Text), 0);
            phieuMuonDAL.CapNhatPhieuMuon(phieuMuon);
            return true;
        }

        public bool XoaPhieuMuon(TextBox txtMaPhieuMuon)
        {
            phieuMuonDAL.XoaPhieuMuon(txtMaPhieuMuon.Text);
            return true;
        }
    }
}
