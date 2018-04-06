using System;
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

        public void HienThiDatagridView(DataGridView dgvBanSao, string maSach)
        {
            List<BanSao> listBanSao = banSaoDAL.LocBSTheoSach(maSach);
            for (int i = 0; i < listBanSao.Count; i++)
            {
                dgvBanSao.Rows[i].Cells[0].Value = (i + 1).ToString();
                dgvBanSao.Rows[i].Cells[1].Value = listBanSao[i].MaBanSao;
                dgvBanSao.Rows[i].Cells[2].Value = listBanSao[i].TrangThai.ToString();
            }
        }

        public void HienThiDGVTrongPhieuMuon(DataGridView dgvBanSao, TextBox txtMaBanSao)
        {
            var banSao = banSaoDAL.TKBanSaoTheoMa(txtMaBanSao.Text);
            int newRowIndex = dgvBanSao.NewRowIndex;
            dgvBanSao.Rows[newRowIndex].Cells[1].Value = (newRowIndex + 1).ToString();
            dgvBanSao.Rows[newRowIndex].Cells[1].Value = banSao.MaBanSao;
            dgvBanSao.Rows[newRowIndex].Cells[2].Value = banSao.Sach.TenSach;
            dgvBanSao.Rows[newRowIndex].Cells[3].Value = banSao.Sach.GiaTien;
        }

        public void LocBSCoSan(DataGridView dgvBanSao, CheckBox chbCoSan, TextBox txtMaSach)
        {

            List<BanSao> listBanSao = banSaoDAL.LocBanSaoCoSan(txtMaSach.Text);
            for (int i = 0; i < listBanSao.Count; i++)
            {
                dgvBanSao.Rows[i].Cells[0].Value = (i + 1).ToString();
                dgvBanSao.Rows[i].Cells[1].Value = listBanSao[i].MaBanSao;
                dgvBanSao.Rows[i].Cells[2].Value = listBanSao[i].TrangThai.ToString();
            }
        }

        public bool ThemBanSao(TextBox txtMaSach, TextBox txtSoLuongBS)
        {
            int maBanSao = Convert.ToInt16(banSaoDAL.LayMaBanSaoMax(txtMaSach.Text));
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

        public bool CapNhatTrangThaiDaChoThue(DataGridView dgvBanSao)
        {
            for (int i = 0; i<dgvBanSao.RowCount;i++)
            {
                var banSao = banSaoDAL.TKBanSaoTheoMa(dgvBanSao.Rows[i].Cells[0].ToString());
                banSao.TrangThai = ETrangThai.DaChoThue;
                banSaoDAL.CapNhatBanSao(banSao);
            }            
            return true;
        }

        public bool CapNhatTrangThaiCoSan(DataGridView dgvBanSao)
        {
            for (int i = 0; i < dgvBanSao.RowCount; i++)
            {
                var banSao = banSaoDAL.TKBanSaoTheoMa(dgvBanSao.Rows[i].Cells[0].ToString());
                banSao.TrangThai = ETrangThai.CoSan;
                banSaoDAL.CapNhatBanSao(banSao);
            }
            return true;
        }
    }
}
