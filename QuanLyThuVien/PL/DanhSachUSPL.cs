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
    public partial class DanhSachUSPL : UserControl
    {       
        public DanhSachUSPL()
        {
            InitializeComponent();            
        }
        
        private void DanhSachUSPL_Load(object sender, EventArgs e)
        {
            #region Design DGV
            dgvDSSach.BorderStyle = BorderStyle.None;
            dgvDSSach.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dgvDSSach.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDSSach.DefaultCellStyle.SelectionBackColor = Color.LightGray;
            dgvDSSach.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvDSSach.BackgroundColor = Color.White;
            dgvDSSach.EnableHeadersVisualStyles = false;
            dgvDSSach.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvDSSach.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgvDSSach.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            #endregion            
        }

        private void dgvDSSach_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(dgvDSSach.PointToScreen(e.Location));
            }
        }

        private void xemThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinSachPL sach = new ThongTinSachPL();
            sach.Show();
        }
    }
}
