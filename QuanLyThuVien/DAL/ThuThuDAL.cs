using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DAL
{
    class ThuThuDAL
    {
        public List<ThuThu> LayDSthuThu()
        {
            using (QLThuVienEntities ThuVienDS = new QLThuVienEntities())
            {
                var ListThuThu = from thuThu in ThuVienDS.ThuThus select thuThu;
                return ListThuThu.ToList();
            }
        }

        public bool ThemThuThu(ThuThu thuThu)
        {
            using (QLThuVienEntities ThuVienDS = new QLThuVienEntities())
            {
                ThuVienDS.ThuThus.Add(thuThu);
                ThuVienDS.SaveChanges();
            }
            return true;
        }

        public bool CapNhatThuThu(ThuThu thuThu)
        {
            using (QLThuVienEntities ThuVienDS = new QLThuVienEntities())
            {
                var tThu = ThuVienDS.ThuThus.Find(thuThu.MaThuThu);
                tThu = thuThu;
                ThuVienDS.SaveChanges();
            }
            return true;
        }

        public bool XoaThuThu(string maThuThu)
        {
            using (QLThuVienEntities ThuVienDs = new QLThuVienEntities())
            {
                var tThu = ThuVienDs.ThuThus.Find(maThuThu);
                ThuVienDs.ThuThus.Remove(tThu);
                ThuVienDs.SaveChanges();
            }
            return true;
        }

        public List<ThuThu> TimKiemThuThu(ThuThu thuThu)
        {
            using (QLThuVienEntities ThuVienDS = new QLThuVienEntities())
            {
                var listThuThu = from r in ThuVienDS.ThuThus select r;
                if (thuThu.MaThuThu != "none")
                    listThuThu = listThuThu.Where<ThuThu>(c => c.MaThuThu.Contains(thuThu.MaThuThu));
                if (thuThu.TenThuThu != "none")
                    listThuThu = listThuThu.Where<ThuThu>(c => c.TenThuThu.Contains(thuThu.TenThuThu));
                if (thuThu.GioiTinh != "none")
                    listThuThu = listThuThu.Where<ThuThu>(c => c.GioiTinh == thuThu.GioiTinh);
                if (thuThu.SoDienThoai != "none")
                    listThuThu = listThuThu.Where<ThuThu>(c => c.SoDienThoai == thuThu.SoDienThoai);
                if (thuThu.SoCMND != "none")
                    listThuThu = listThuThu.Where<ThuThu>(c => c.SoCMND == thuThu.SoCMND);
                if (thuThu.DiaChi != "none")
                    listThuThu = listThuThu.Where<ThuThu>(c => c.DiaChi == thuThu.DiaChi);
                if (thuThu.NgaySinh != Convert.ToDateTime(01/01/01))
                    listThuThu = listThuThu.Where<ThuThu>(c => c.NgaySinh == thuThu.NgaySinh);
                return listThuThu.ToList();
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
