using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThuVien.Components;
using QuanLyThuVien.BLL;

namespace QuanLyThuVien.PL
{
    public partial class ThuThuPL : Form
    {
        ThuThuBLL thuThuBLL = new ThuThuBLL();
        public ThuThuPL()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThunho_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnTimAnh_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fulllocimage = openFileDialog1.FileName;
                pbHinh.ImageLocation = fulllocimage;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaThuThu.Text))
            {
                MessageBox.Show("Mã không được trống", "Mã thủ thư", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(string.IsNullOrEmpty(txtHoTen.Text))
            {
                MessageBox.Show("Tên không được để trống", "Họ tên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(rbtnNam.Checked == false && rbtnNu.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn giới tính", "Giới tính", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(string.IsNullOrEmpty(txtDiaChi.Text))
            {
                MessageBox.Show("Địa chỉ không được để trống", "Địa chỉ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(txtCMND.Text))
            {
                MessageBox.Show("CMND không được để trống", "CMND", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(txtSDT.Text))
            {
                MessageBox.Show("SDT không được để trống", "SDT", MessageBoxButtons.OK, MessageBoxIcon.Warning);              
            }
            else
            {
                if (!KtraDuLieu.CheckMa(txtMaThuThu.Text))
                    MessageBox.Show("Sai định dạng!", "Mã thủ thư", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (!KtraDuLieu.CheckMa(txtCMND.Text) || txtCMND.Text.Length > 12) 
                    MessageBox.Show("Sai định dạng!", "CMND", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (!KtraDuLieu.CheckMa(txtSDT.Text) || txtSDT.Text.Length > 11) 
                    MessageBox.Show("Sai định dạng!", "Mã thủ thư", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    if (rbtnNam.Checked) 
                    {
                        thuThuBLL.ThemThuThu(txtMaThuThu, txtHoTen, dtpNgaySinh, rbtnNam, txtSDT, txtCMND, txtDiaChi);
                    }
                    else thuThuBLL.ThemThuThu(txtMaThuThu, txtHoTen, dtpNgaySinh, rbtnNu, txtSDT, txtCMND, txtDiaChi);
                }
            }
        } 

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaThuThu.Text))
            {
                MessageBox.Show("Mã không được trống", "Mã thủ thư", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(txtHoTen.Text))
            {
                MessageBox.Show("Tên không được để trống", "Họ tên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (rbtnNam.Checked == false && rbtnNu.Checked == false)
            {
                MessageBox.Show("Vui lòng chọn giới tính", "Giới tính", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(txtDiaChi.Text))
            {
                MessageBox.Show("Địa chỉ không được để trống", "Địa chỉ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(txtCMND.Text))
            {
                MessageBox.Show("CMND không được để trống", "CMND", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(txtSDT.Text))
            {
                MessageBox.Show("SDT không được để trống", "SDT", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (!KtraDuLieu.CheckMa(txtMaThuThu.Text))
                    MessageBox.Show("Sai định dạng!", "Mã thủ thư", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (!KtraDuLieu.CheckMa(txtCMND.Text) || txtCMND.Text.Length > 12)
                    MessageBox.Show("Sai định dạng!", "CMND", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (!KtraDuLieu.CheckMa(txtSDT.Text) || txtSDT.Text.Length > 11)
                    MessageBox.Show("Sai định dạng!", "Mã thủ thư", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    if (rbtnNam.Checked)
                    {
                        if (thuThuBLL.CapNhatThuThu(txtMaThuThu, txtHoTen, dtpNgaySinh, rbtnNam, txtSDT, txtCMND, txtDiaChi))
                        {
                            MessageBox.Show("Tạo thành công!");
                            UpdateDGV();
                            this.tabPage1.Refresh();
                        }
                        else MessageBox.Show("Tạo thất bại!");
                    }
                    else
                    {
                        if (thuThuBLL.CapNhatThuThu(txtMaThuThu, txtHoTen, dtpNgaySinh, rbtnNu, txtSDT, txtCMND, txtDiaChi))
                        {
                            MessageBox.Show("Tạo thành công!");
                            UpdateDGV();
                            this.tabPage1.Refresh();
                        }
                        else MessageBox.Show("Tạo thất bại!");
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaThuThu.Text))
            {
                MessageBox.Show("Mã không được trống", "Mã thủ thư", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void UpdateDGV()
        {
            dgvDSThuThu.DataSource = null;
            thuThuBLL.HienThiDataGridView(dgvDSThuThu);
        }

        private void dgvDSThuThu_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = dgvDSThuThu.CurrentCell.RowIndex;
            ThuThu item = thuThuBLL.LayThuThu(dgvDSThuThu.Rows[index]);
            this.tabPage1.Show();
            txtMaThuThu.Text = item.MaThuThu;
            txtHoTen.Text = item.TenThuThu;
            if (item.GioiTinh == "Nam") rbtnNam.Checked = true;
            else rbtnNu.Checked = true;
            txtDiaChi.Text = item.DiaChi;
            txtSDT.Text = item.SoDienThoai;
            txtCMND.Text = item.SoCMND;
        }
    }
}
