using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DAL
{
    class TheLoaiDAL
    {
        public List<TheLoai> LayDSTheLoai()
        {
            using (QLThuVienEntities ThuVienDS = new QLThuVienEntities())
            {
                var listTheLoai = from theLoai in ThuVienDS.TheLoais select theLoai;
                return listTheLoai.ToList();
            }
        }

        public bool ThemTheLoai(TheLoai theLoai)
        {
            using (QLThuVienEntities ThuVienDS = new QLThuVienEntities())
            {
                ThuVienDS.TheLoais.Add(theLoai);
            }
            return true;
        }

        public bool CapNhatTheLoai(TheLoai theLoai)
        {
            using (QLThuVienEntities ThuVienDS = new QLThuVienEntities())
            {
                var tLoai = ThuVienDS.TheLoais.Find(theLoai.MaTheLoai);
                tLoai = theLoai;
                ThuVienDS.SaveChanges();
            }
            return true;
        }

        public bool XoaTheLoai(string maTheLoai)
        {
            using (QLThuVienEntities ThuVienDs = new QLThuVienEntities())
            {
                var tLoai = ThuVienDs.TheLoais.Find(maTheLoai);
                ThuVienDs.TheLoais.Remove(tLoai);
                ThuVienDs.SaveChanges();
            }
            return true;
        }

        public List<TheLoai> TimKiemTheLoai(TheLoai theLoai)
        {
            using (QLThuVienEntities ThuVienDS = new QLThuVienEntities())
            {
                var listTheLoai = from r in ThuVienDS.TheLoais select r;
                if (theLoai.MaTheLoai != "none")
                    listTheLoai = listTheLoai.Where<TheLoai>(c => c.MaTheLoai.Contains(theLoai.MaTheLoai));
                if (theLoai.TenTheLoai != "none")
                    listTheLoai = listTheLoai.Where<TheLoai>(c => c.TenTheLoai.Contains(theLoai.TenTheLoai));
                return listTheLoai.ToList();
            }
        }
    }
}
