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
                ThuVienDS.SaveChanges();
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

        public bool XoaDocGia(string maDocGia)
        {
            using (QLThuVienEntities ThuVienDs = new QLThuVienEntities())
            {
                var dGia = ThuVienDs.DocGias.Find(maDocGia);
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
                if (docGia.SoDienThoai != "none")
                    listDocGia = listDocGia.Where<DocGia>(c => c.SoDienThoai == docGia.SoDienThoai);
                if (docGia.SoCMND != "none")
                    listDocGia = listDocGia.Where<DocGia>(c => c.SoCMND == docGia.SoCMND);
                if (docGia.DiaChi != "none")
                    listDocGia = listDocGia.Where<DocGia>(c => c.DiaChi == docGia.DiaChi);
                if (docGia.NgayBatDau != Convert.ToDateTime(01/01/01))
                    listDocGia = listDocGia.Where<DocGia>(c => c.NgayBatDau == docGia.NgayBatDau);
                if (docGia.NgayKetThuc != Convert.ToDateTime(01 / 01 / 01))
                    listDocGia = listDocGia.Where<DocGia>(c => c.NgayKetThuc == docGia.NgayKetThuc);
                if (docGia.NgaySinh != Convert.ToDateTime(01/01/01))
                    listDocGia = listDocGia.Where<DocGia>(c => c.NgaySinh == docGia.NgaySinh);
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

    }
}
