using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DAL
{
    class PhieuMuonDAL
    {
        public List<PhieuMuonSach> LayDSPhieuMuon()
        {
            using (QLThuVienEntities ThuVienDS = new QLThuVienEntities())
            {
                var listPhieuMuon = from phieuMuon in ThuVienDS.PhieuMuonSaches select phieuMuon;
                return listPhieuMuon.ToList();
            }
        }

        public bool ThemPhieuMuon(PhieuMuonSach phieuMuon)
        {
            using (QLThuVienEntities ThuVienDS = new QLThuVienEntities())
            {
                ThuVienDS.PhieuMuonSaches.Add(phieuMuon);
                ThuVienDS.SaveChanges();
            }
            return true;
        }

        public bool CapNhatPhieuMuon(PhieuMuonSach phieuMuon)
        {
            using (QLThuVienEntities ThuVienDS = new QLThuVienEntities())
            {
                var pMuon = ThuVienDS.PhieuMuonSaches.Find(phieuMuon.MaPhieuMuon);
                pMuon = phieuMuon;
                ThuVienDS.SaveChanges();
            }
            return true;
        }

        public bool XoaPhieuMuon(string maPhieuMuon)
        {
            using (QLThuVienEntities ThuVienDs = new QLThuVienEntities())
            {
                var pMuon = ThuVienDs.PhieuMuonSaches.Find(maPhieuMuon);
                ThuVienDs.PhieuMuonSaches.Remove(pMuon);
                ThuVienDs.SaveChanges();
            }
            return true;
        }

        public List<PhieuMuonSach> TimKiemPhieuMuon(PhieuMuonSach phieuMuon)
        {
            using (QLThuVienEntities ThuVienDS = new QLThuVienEntities())
            {
                var listPhieuMuon = from r in ThuVienDS.PhieuMuonSaches select r;
                if (phieuMuon.MaPhieuMuon != "none")
                    listPhieuMuon = listPhieuMuon.Where<PhieuMuonSach>(c => c.MaPhieuMuon.Contains(phieuMuon.MaPhieuMuon));
                if (phieuMuon.MaNguoiMuon != "none")
                    listPhieuMuon = listPhieuMuon.Where<PhieuMuonSach>(c => c.MaNguoiMuon.Contains(phieuMuon.MaNguoiMuon));
                if (phieuMuon.NgayMuonSach != Convert.ToDateTime(01/01/01))
                    listPhieuMuon = listPhieuMuon.Where<PhieuMuonSach>(c => c.NgayMuonSach.Equals(phieuMuon.NgayMuonSach));
                if (phieuMuon.HanTraSach != Convert.ToDateTime(01/01/01))
                    listPhieuMuon = listPhieuMuon.Where<PhieuMuonSach>(c => c.HanTraSach.Equals(phieuMuon.HanTraSach));
                return listPhieuMuon.ToList();
            }
        }


    }
}
