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
    public partial class ChinhSuaThanhVienUSPL : UserControl
    {
        #region Property
        public TextBox TxtMaThanhVien
        {
            get { return txtMaThanhVien; }
            set { txtMaThanhVien = value; }
        }
        public TextBox TxtTenThanhVien
        {
            get { return txtTenThanhVien; }
            set { txtTenThanhVien = value; }
        }
        public TextBox TxtEmail
        {
            get { return txtEmail; }
            set { txtEmail = value; }
        }
        public TextBox TxtDiaChi
        {
            get { return txtDiaChi; }
            set { txtDiaChi = value; }
        }
        public TextBox TxtSDT
        {
            get { return txtSDT; }
            set { txtSDT = value; }
        }
        public TextBox TxtCMND
        {
            get { return txtCMND; }
            set { txtCMND = value; }
        }
        public DateTimePicker DtpNgaySinh
        {
            get { return dtpNgaySinh; }
            set { dtpNgaySinh = value; }
        }
        public DateTimePicker DtpNgayBatDau
        {
            get { return dtpNgayBatDau; }
            set { dtpNgayBatDau = value; }
        }
        public DateTimePicker DtpNgayKetThuc
        {
            get { return dtpNgayKetThuc; }
            set { dtpNgayKetThuc = value; }
        }
        public PictureBox PbHinhTV
        {
            get { return pbHinhTV; }
            set { pbHinhTV = value; }
        }
        #endregion
        public ChinhSuaThanhVienUSPL()
        {
            InitializeComponent();
        }
    }
}
