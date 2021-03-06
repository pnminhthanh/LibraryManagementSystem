﻿using System.Collections.Generic;
using System.Linq;

namespace QuanLyThuVien.DAL
{
    class BanSaoDAL
    {
        public List<BanSao> LayDSBanSao()
        {          
            using (QLThuVienEntities ThuVienDS = new QLThuVienEntities())
            {
                var ListBanSao = from banSao in ThuVienDS.BanSaos
                                 select banSao;
                return ListBanSao.ToList();
            }
        }

        public bool ThemBanSao(List<BanSao> ListBanSao)
        {
            using (QLThuVienEntities ThuVienDS = new QLThuVienEntities())
            {
                foreach  (var banSao in ListBanSao)
                {
                    ThuVienDS.BanSaos.Add(banSao);
                    ThuVienDS.SaveChanges();
                }                
            }
            return true;
        }

        public bool CapNhatBanSao(BanSao banSao)
        {
            using (QLThuVienEntities ThuVienDS = new QLThuVienEntities())
            {
                var bSao = ThuVienDS.BanSaos.Find(banSao.MaBanSao);
                bSao = banSao;
                ThuVienDS.SaveChanges();
            }
            return true;
        }

        public bool XoaBanSao(string maBanSao)
        {
            using (QLThuVienEntities ThuVienDs = new QLThuVienEntities())
            {
                var bSao = ThuVienDs.BanSaos.Find(maBanSao);
                ThuVienDs.BanSaos.Remove(bSao);
                ThuVienDs.SaveChanges();
            }
            return true;
        }

        public List<BanSao> TimKiemBanSao(BanSao banSao)
        {
            using (QLThuVienEntities ThuVienDS = new QLThuVienEntities())
            {
                var listBanSao = from bSao in ThuVienDS.BanSaos select bSao;
                if (banSao.MaBanSao != "none")
                    listBanSao = listBanSao.Where<BanSao>(c => c.MaBanSao.Contains(banSao.MaBanSao));
                if (banSao.Sach.TenSach != "none")
                    listBanSao = listBanSao.Where<BanSao>(c => c.Sach.TenSach.Contains(banSao.Sach.TenSach));
                if (banSao.TrangThai != ETrangThai.None)
                    listBanSao = listBanSao.Where<BanSao>(c => c.TrangThai == banSao.TrangThai);                
                return listBanSao.ToList();
            }
        }

        public BanSao TKBanSaoTheoMa(string maBanSao)
        {
            using (QLThuVienEntities ThuVienDs = new QLThuVienEntities())
            {
                var banSao = ThuVienDs.BanSaos.Find(maBanSao);
                return banSao;
            }
        }

        public List<BanSao> LocBSTheoSach(string maSach)
        {
            using (QLThuVienEntities ThuVienDS = new QLThuVienEntities())
            {
                var listBanSao = ThuVienDS.BanSaos.Where<BanSao>(c => c.MaSach == maSach);
                return listBanSao.ToList();
            }
        }

        public List<BanSao> LocBanSaoCoSan(string maSach)
        {
            using (QLThuVienEntities ThuVienDS = new QLThuVienEntities())
            {
                var ListBanSao = ThuVienDS.BanSaos.Where<BanSao>(c => c.TrangThai == ETrangThai.CoSan && c.MaSach == maSach);
                return ListBanSao.ToList();
            }
        }

        public string LayMaBanSaoMax(string maSach)
        {
            using (QLThuVienEntities ThuVienDS = new QLThuVienEntities())
            {
                string banSao = ThuVienDS.BanSaos.Where<BanSao>(c => c.MaSach == maSach).Select(c => c.MaBanSao).Max();
                return banSao;
            }
        }
    }
}
