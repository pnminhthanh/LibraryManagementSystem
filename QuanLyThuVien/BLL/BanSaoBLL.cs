﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.DAL;
using System.Windows.Forms;

namespace QuanLyThuVien.BLL
{
    class BanSaoBLL
    {
        private BanSaoDAL banSaoDAL = new BanSaoDAL();

        public void HienThiDatagridView(DataGridView dgvBanSao)
        {
            dgvBanSao.DataSource = banSaoDAL.LayDSBanSao();
        }

        public void HienThiDataGridViewPhieuMuon(DataGridView dgvBanSao, TextBox txtMaBanSao)
        {
            var banSao = banSaoDAL.TKBanSaoTheoMa(txtMaBanSao.Text);
            int newRowIndex = dgvBanSao.NewRowIndex;
            dgvBanSao.Rows[newRowIndex].Cells[0].Value = banSao.MaBanSao;
            dgvBanSao.Rows[newRowIndex].Cells[1].Value = banSao.Sach.TenSach;
            dgvBanSao.Rows[newRowIndex].Cells[2].Value = banSao.Sach.GiaTien;
        }

        public void HienThiBSTheoSach(DataGridView dgvBanSao, DataGridViewRow dgvrBanSao)
        {
            dgvBanSao.DataSource = banSaoDAL.LocBSTheoSach(dgvrBanSao.Cells[0].ToString());
        }

        public bool ThemBanSao(TextBox txtMaSach, TextBox txtSoLuongBS)
        {
            int maBanSao = banSaoDAL.LocBSTheoSach(txtMaSach.Text).Count;
            List<BanSao> listBanSao = new List<BanSao>();
            int soLuong = Convert.ToInt16(txtSoLuongBS.Text);
            for (int i = 0; i < soLuong; i++)
            {
                BanSao banSao = new BanSao();
                banSao.MaSach = txtMaSach.Text;
                maBanSao =+ i + 1;
                banSao.MaBanSao = maBanSao.ToString();
                banSao.TrangThai = ETrangThai.CoSan;
                listBanSao.Add(banSao);
            }
            banSaoDAL.ThemBanSao(listBanSao);
            return true;
        }

        public bool CapNhatBanSao(string maBanSao, TextBox txtMaSach, TextBox txtMaBanSao, ComboBox cbTrangThai)
        {
            BanSao banSao = new BanSao();
            banSao.MaBanSao = txtMaBanSao.Text;
            banSao.MaSach = txtMaSach.Text;
            banSao.TrangThai = (ETrangThai)(Convert.ToInt16(cbTrangThai.ValueMember));
            return true;
        }

        public bool XoaBanSao(DataGridViewRow dgvrBanSao)
        {
            banSaoDAL.XoaBanSao(dgvrBanSao.Cells[0].ToString());
            return true;
        }

        public bool CapNhatTrangThaiSach(DataGridView dgvBanSao)
        {

            return true;
        }
    }
}
