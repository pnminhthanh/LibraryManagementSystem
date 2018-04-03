using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DAL
{
    class LoaiViPhamDAL
    {
        public List<NoiQuyViPham> LayDSViPham()
        {
            using (QLThuVienEntities ThuVienDS = new QLThuVienEntities())
            {
                var listLoaiViPham = from loaiViPham in ThuVienDS.NoiQuyViPhams select loaiViPham;
                return listLoaiViPham.ToList();
            }
        }

        public bool ThemLoaiViPham(NoiQuyViPham loaiViPham)
        {
            using (QLThuVienEntities ThuVienDS = new QLThuVienEntities())
            {
                ThuVienDS.NoiQuyViPhams.Add(loaiViPham);
            }
            return true;
        }

        public bool CapNhatViPham(NoiQuyViPham loaiViPham)
        {
            using (QLThuVienEntities ThuVienDS = new QLThuVienEntities())
            {
                var viPham = ThuVienDS.NoiQuyViPhams.Find(loaiViPham.MaViPham);
                viPham = loaiViPham;
                ThuVienDS.SaveChanges();
            }
            return true;
        }

        public bool XoaLoaiViPham(NoiQuyViPham loaiViPham)
        {
            using (QLThuVienEntities ThuVienDs = new QLThuVienEntities())
            {
                var viPham = ThuVienDs.NoiQuyViPhams.Find(loaiViPham.MaViPham);
                ThuVienDs.NoiQuyViPhams.Remove(viPham);
                ThuVienDs.SaveChanges();
            }
            return true;
        }

        public List<NoiQuyViPham> TimKiemViPham(NoiQuyViPham loaiViPham)
        {
            using (QLThuVienEntities ThuVienDS = new QLThuVienEntities())
            {
                var listLoaiViPham = from r in ThuVienDS.NoiQuyViPhams select r;
                if (loaiViPham.MaViPham != "none")
                    listLoaiViPham = listLoaiViPham.Where<NoiQuyViPham>(c => c.MaViPham.Contains(loaiViPham.MaViPham));
                if (loaiViPham.TenViPham != "none")
                    listLoaiViPham = listLoaiViPham.Where<NoiQuyViPham>(c => c.TenViPham.Contains(loaiViPham.TenViPham));
                return listLoaiViPham.ToList();
            }
        }
    }
}
