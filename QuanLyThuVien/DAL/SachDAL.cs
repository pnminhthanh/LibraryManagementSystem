using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DAL
{
    class SachDAL
    {
        public List<Sach> LayDSSach()
        {
            using (QLThuVienEntities ThuVienDS = new QLThuVienEntities())
            {
                var listSach = from Sach in ThuVienDS.Saches select Sach;
                return listSach.ToList();
            }
        }

        public bool ThemSach(Sach sach)
        {
            using (QLThuVienEntities ThuVienDS = new QLThuVienEntities())
            {
                ThuVienDS.Saches.Add(sach);
                ThuVienDS.SaveChanges();
            }
            return true;
        }

        public bool CapNhatSach(Sach sach)
        {
            using (QLThuVienEntities ThuVienDS = new QLThuVienEntities())
            {
                var phieu = ThuVienDS.Saches.Find(sach.MaSach);
                phieu = sach;
                ThuVienDS.SaveChanges();
            }
            return true;
        }

        public bool XoaSach(string maSach)
        {
            using (QLThuVienEntities ThuVienDs = new QLThuVienEntities())
            {
                var s = ThuVienDs.Saches.Find(maSach);
                ThuVienDs.Saches.Remove(s);
                ThuVienDs.SaveChanges();
            }
            return true;
        }

        public List<Sach> TimKiemSachTheoTen(string tenSach)
        {
            using (QLThuVienEntities ThuVienDS = new QLThuVienEntities())
            {
                var listSach = from r in ThuVienDS.Saches select r;                
                if (tenSach != "")
                    listSach = listSach.Where<Sach>(c => c.TenSach.Contains(tenSach));                                    
                return listSach.ToList();
            }
        }

        public List<Sach> TKSachTheoTenTacGia(string tenTacGia)
        {
            using (QLThuVienEntities ThuVienDS = new QLThuVienEntities())
            {
                var listSach = ThuVienDS.Saches.Where<Sach>(c => c.TacGia.TenTacGia.Contains(tenTacGia));                
                return listSach.ToList();
            }
                
        }

        public List<Sach> LayDSSachTheoTacGia(string maTacGia)
        {
            using (QLThuVienEntities ThuVienDS = new QLThuVienEntities())
            {
                var listSach = ThuVienDS.Saches.Where(b => b.TacGia.MaTacGia == maTacGia); 
                return listSach.ToList();
            }
        }

        public List<Sach> LayDSSachTheoTheLoai(List<int> listMaTheLoai)
        {
            using (QLThuVienEntities ThuVienDS = new QLThuVienEntities())
            {
                var listSach = from b in ThuVienDS.Saches select b;
                foreach (int ma in listMaTheLoai)
                {
                    listSach = listSach.Where<Sach>(c => c.TheLoais.Contains(ThuVienDS.TheLoais.Find(ma)));
                }
                return listSach.ToList();
            }
        }
    }
}
