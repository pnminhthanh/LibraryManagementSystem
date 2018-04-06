using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.PL
{
    public partial class TimKiemSachPL : UserControl
    {
        #region Property
        public TextBox TxtTenSach
        {
            get { return txtTenSach; }
            set { txtTenSach = value; }
        }
        public TextBox TxtMaSach
        {
            get { return txtMaSach; }
            set { txtMaSach = value; }
        }
        public TextBox TxtNamXuatBan
        {
            get { return txtNamXuatBan; }
            set { txtNamXuatBan = value; }
        }
        public TextBox TxtTacGia
        {
            get { return txtTacGia; }
            set { txtTacGia = value; }
        }
        public ComboBox CboMaKe
        {
            get { return cbMaKe; }
            set { cbMaKe = value; }
        }
        public ComboBox CboTheLoai
        {
            get { return cbTheLoai; }
            set { cbTheLoai = value; }
        }
        public TextBox TxtNXB
        {
            get { return txtNXB; }
            set { txtNXB = value; }
        }
        public DataGridView DgvDSSach
        {
            get { return dgvDSSach; }
            set { dgvDSSach = value; }
        }
        #endregion
        public TimKiemSachPL()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }
    }
}
