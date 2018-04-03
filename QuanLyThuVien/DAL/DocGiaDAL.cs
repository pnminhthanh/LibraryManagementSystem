using System;
using System.Collections.Generic;
using System.Linq;

namespace QuanLyThuVien.DAL
{
    public class DocGiaDAL
    {
        public List<DocGia> LayDSDocGia()
        {
            using (QLThuVienEntities ThuVienDS = new QLThuVienEntities())
            {
                var ListDocGia = from docGia in ThuVienDS.DocGias select docGia;
                return ListDocGia.ToList();
            }
        }

        public bool ThemDocGia(DocGia docGia)
        {
            using (QLThuVienEntities ThuVienDS = new QLThuVienEntities())
            {
                ThuVienDS.DocGias.Add(docGia);
            }
            return true;
        }

        public bool CapNhatDocGia(DocGia docGia)
        {
            using (QLThuVienEntities ThuVienDS = new QLThuVienEntities())
            {
                var dGia = ThuVienDS.DocGias.Find(docGia.MaDocGia);
                dGia = docGia;
                ThuVienDS.SaveChanges();
            }
            return true;
        }

        public bool XoaDocGia(DocGia docGia)
        {
            using (QLThuVienEntities ThuVienDs = new QLThuVienEntities())
            {
                var dGia = ThuVienDs.DocGias.Find(docGia.MaDocGia);
                ThuVienDs.DocGias.Remove(dGia);
                ThuVienDs.SaveChanges();
            }
            return true;
        }

        public List<DocGia> TimKiemDocGia(DocGia docGia)
        {
            using (QLThuVienEntities ThuVienDS = new QLThuVienEntities())
            {
                var listDocGia = from r in ThuVienDS.DocGias select r;
                if (docGia.MaDocGia != "none")
                    listDocGia = listDocGia.Where<DocGia>(c => c.MaDocGia.Contains(docGia.MaDocGia));
                if (docGia.TenDocGia != "none")
                    listDocGia = listDocGia.Where<DocGia>(c => c.TenDocGia.Contains(docGia.TenDocGia));
                if (docGia.GioiTinh != "none")
                    listDocGia = listDocGia.Where<DocGia>(c => c.GioiTinh == docGia.GioiTinh);
                if (docGia.SoDienThoai != 0)
                    listDocGia = listDocGia.Where<DocGia>(c => c.SoDienThoai == docGia.SoDienThoai);
                if (docGia.SoCMND != 0)
                    listDocGia = listDocGia.Where<DocGia>(c => c.SoCMND == docGia.SoCMND);
                return listDocGia.ToList();
            }
        }

        public List<PhieuMuonSach> LayDSPhieuMuon(string maDocGia)
        {
            using (QLThuVienEntities ThuVienDS = new QLThuVienEntities())
            {
                var docGia = ThuVienDS.DocGias.Find(maDocGia);
                return docGia.PhieuMuonSaches.ToList();
            }                
        }

        public List<PhieuViPham> LayDSPhieuVP(string maDocGia)
        {
            using (QLThuVienEntities ThuVienDS = new QLThuVienEntities())
            {
                var listPhieuVP = from p in ThuVienDS.PhieuViPhams
                                  where p.PhieuMuonSach.MaNguoiMuon == maDocGia select p;
                return listPhieuVP.ToList();
            }
        }
    }
}
