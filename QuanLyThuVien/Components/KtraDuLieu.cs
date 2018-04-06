using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.Components
{
    class KtraDuLieu
    {
        public static bool CheckMa(string chuoiMa)
        {
            return int.TryParse(chuoiMa, out int ma);
        }

        public static bool CheckSDT(string chuoiSDT)
        {
            return ((chuoiSDT.Length < 12) && (chuoiSDT.Length > 9) && (int.TryParse(chuoiSDT, out int sdt)));
        }

        public static bool CheckCMND(string chuoiCMND)
        {
            return ((chuoiCMND.Length < 11) && (chuoiCMND.Length > 8) && (int.TryParse(chuoiCMND, out int cmnd)));
        }
        public static bool CheckNgay(DateTime ngay)
        {
            return (ngay.Date != DateTime.Now);
        }
    }
}
