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
            }
            return true;
        }

        public bool CapNhatach(Sach sach)
        {
            using (QLThuVienEntities ThuVienDS = new QLThuVienEntities())
            {
                var phieu = ThuVienDS.Saches.Find(sach.MaSach);
                phieu = sach;
                ThuVienDS.SaveChanges();
            }
            return true;
        }

        public bool XoaSach(Sach sach)
        {
            using (QLThuVienEntities ThuVienDs = new QLThuVienEntities())
            {
                var s = ThuVienDs.Saches.Find(sach.MaSach);
                ThuVienDs.Saches.Remove(s);
                ThuVienDs.SaveChanges();
            }
            return true;
        }

        public List<Sach> TimKiemSach(Sach sach)
        {
            using (QLThuVienEntities ThuVienDS = new QLThuVienEntities())
            {
                var listSach = from r in ThuVienDS.Saches select r;
                if (sach.MaSach != "none")
                    listSach = listSach.Where<Sach>(c => c.MaSach.Contains(sach.MaSach));
                if (sach.TenSach != "none")
                    listSach = listSach.Where<Sach>(c => c.TenSach.Contains(sach.TenSach));
                if (sach.MaTacGia != "none")
                    listSach = listSach.Where<Sach>(c => c.MaTacGia.Contains(sach.MaTacGia));
                return listSach.ToList();
            }
        }

        public List<Sach> LayDSSachTheoTacGia(int maTacGia)
        {
            using (QLThuVienEntities ThuVienDS = new QLThuVienEntities())
            {
                TacGia tGia = ThuVienDS.TacGias.Find(maTacGia);
                var listSach = from b in ThuVienDS.Saches where b.TacGias.Contains(tGia) select b;
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
