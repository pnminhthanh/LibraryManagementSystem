using System.Collections.Generic;
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

        public bool ThemBanSao(BanSao banSao)
        {
            using (QLThuVienEntities ThuVienDS = new QLThuVienEntities())
            {
                ThuVienDS.BanSaos.Add(banSao);
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

        public bool XoaBanSao(BanSao banSao)
        {
            using (QLThuVienEntities ThuVienDs = new QLThuVienEntities())
            {
                var bSao = ThuVienDs.BanSaos.Find(banSao.MaBanSao);
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
                if (banSao.TrangThai != 0)
                    listBanSao = listBanSao.Where<BanSao>(c => c.TrangThai == banSao.TrangThai);
                if (banSao.CoTheMuon != false)
                    listBanSao = listBanSao.Where<BanSao>(c => c.CoTheMuon == banSao.CoTheMuon);
                return listBanSao.ToList();
            }
        }
    }
}
