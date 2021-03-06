﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThuVien.DAL;

namespace QuanLyThuVien.BLL
{
    class KeSachBLL
    {
        private KeSachDAL keSachDAL = new KeSachDAL();

        public void HienThiDataGridView(DataGridView dgvListKeSach)
        {
            List<KeSach> listKeSach = keSachDAL.LayDSKeSach();
            for (int i = 0; i < listKeSach.Count; i++)
            {
                DataGridViewRow newRow = new DataGridViewRow();
                dgvListKeSach.Rows.Add(newRow);
                dgvListKeSach.Rows[i].Cells[0].Value = (i + 1).ToString();
                dgvListKeSach.Rows[i].Cells[1].Value = listKeSach[i].MaKeSach;
                dgvListKeSach.Rows[i].Cells[2].Value = listKeSach[i].TenTheLoai;
            }
        }

        public void HienThiComboBox(ComboBox cbKeSach)
        {
            cbKeSach.DataSource = keSachDAL.LayDSKeSach();
            cbKeSach.DisplayMember = "TenTheLoai";
            cbKeSach.ValueMember = "MaTheLoai";
        }
        
        public bool ThemKeMoi(TextBox txtMaKeSach, TextBox txtTenTheLoai)
        {
            KeSach keSach = new KeSach();
            keSach.MaKeSach = txtMaKeSach.Text;
            keSach.TenTheLoai = txtTenTheLoai.Text;
            keSachDAL.ThemKeSach(keSach);
            return true;
        }

        public bool SuaThongTinSach(TextBox txtMaKeSach, TextBox txtTenTheLoai)
        {
            KeSach keSach = new KeSach();
            keSach.MaKeSach = txtMaKeSach.Text;
            keSach.TenTheLoai = txtTenTheLoai.Text;
            keSachDAL.CapNhatKeSach(keSach);
            return true;
        }

        public bool XoaKeSach(TextBox txtMaKeSach)
        {
            keSachDAL.XoaKeSach(txtMaKeSach.Text);
            return true;
        }

        public void HienThiKeSach(TextBox txtMaKeSach, TextBox txtTenTheLoai, DataGridViewRow dgvrKeSach)
        {
            KeSach keSach = keSachDAL.LayKeSachTheoMa(dgvrKeSach.Cells[1].Value.ToString());
            txtMaKeSach.Text = keSach.MaKeSach;
            txtTenTheLoai.Text = keSach.TenTheLoai;
        }
    }
}
