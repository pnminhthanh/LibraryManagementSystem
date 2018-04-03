using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DAL
{
    class PhieuViPhamDAL
    {
        public List<PhieuViPham> LayDSPhieuViPham()
        {
            using (QLThuVienEntities ThuVienDS = new QLThuVienEntities())
            {
                var listPhieuViPham = from phieuVP in ThuVienDS.PhieuViPhams select phieuVP;
                return listPhieuViPham.ToList();
            }
        }

        public bool ThemPhieuVP(PhieuViPham phieuVP)
        {
            using (QLThuVienEntities ThuVienDS = new QLThuVienEntities())
            {
                ThuVienDS.PhieuViPhams.Add(phieuVP);
            }
            return true;
        }

        public bool CapNhatPhieuVP(PhieuViPham phieuVP)
        {
            using (QLThuVienEntities ThuVienDS = new QLThuVienEntities())
            {
                var phieu = ThuVienDS.PhieuViPhams.Find(phieuVP.MaPhieuViPham);
                phieu = phieuVP;
                ThuVienDS.SaveChanges();
            }
            return true;
        }

        public bool XoaPhieuVP(PhieuViPham phieuVP)
        {
            using (QLThuVienEntities ThuVienDs = new QLThuVienEntities())
            {
                var phieu = ThuVienDs.PhieuViPhams.Find(phieuVP.MaPhieuViPham);
                ThuVienDs.PhieuViPhams.Remove(phieu);
                ThuVienDs.SaveChanges();
            }
            return true;
        }

        public List<PhieuViPham> TimKiemPhieuViPham(PhieuViPham phieuVP)
        {
            using (QLThuVienEntities ThuVienDS = new QLThuVienEntities())
            {
                var listPhieuVP = from r in ThuVienDS.PhieuViPhams select r;
                if (phieuVP.MaPhieuViPham != "none")
                    listPhieuVP = listPhieuVP.Where<PhieuViPham>(c => c.MaPhieuViPham.Contains(phieuVP.MaPhieuViPham));
                if (phieuVP.MaPhieuMuon != "none")
                    listPhieuVP = listPhieuVP.Where<PhieuViPham>(c => c.MaPhieuMuon.Contains(phieuVP.MaPhieuMuon));
                if (phieuVP.MaViPham != "none")
                    listPhieuVP = listPhieuVP.Where<PhieuViPham>(c => c.MaViPham.Contains(phieuVP.MaViPham));
                return listPhieuVP.ToList();
            }
        }
    }
}
