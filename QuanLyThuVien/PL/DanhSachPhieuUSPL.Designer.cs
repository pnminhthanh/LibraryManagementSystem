namespace QuanLyThuVien.PL
{
    partial class DanhSachPhieuUSPL
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.dgvDSPhieuMuon = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cậpNhậtTìnhTrạngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtNoiDungTim = new System.Windows.Forms.TextBox();
            this.cbDanhMuc = new System.Windows.Forms.ComboBox();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPhieuMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDocGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TienCoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DaTra = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ViPham = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.xemViPhạmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhieuMuon)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Controls.Add(this.btnTimKiem);
            this.TopPanel.Controls.Add(this.txtNoiDungTim);
            this.TopPanel.Controls.Add(this.cbDanhMuc);
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(720, 80);
            this.TopPanel.TabIndex = 1;
            // 
            // dgvDSPhieuMuon
            // 
            this.dgvDSPhieuMuon.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDSPhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSPhieuMuon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaPhieuMuon,
            this.MaDocGia,
            this.SoLuong,
            this.NgayMuon,
            this.ThoiHan,
            this.TienCoc,
            this.DaTra,
            this.ViPham});
            this.dgvDSPhieuMuon.Location = new System.Drawing.Point(0, 80);
            this.dgvDSPhieuMuon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDSPhieuMuon.Name = "dgvDSPhieuMuon";
            this.dgvDSPhieuMuon.RowHeadersVisible = false;
            this.dgvDSPhieuMuon.Size = new System.Drawing.Size(720, 380);
            this.dgvDSPhieuMuon.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cậpNhậtTìnhTrạngToolStripMenuItem,
            this.xóaToolStripMenuItem,
            this.xemViPhạmToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(178, 70);
            // 
            // cậpNhậtTìnhTrạngToolStripMenuItem
            // 
            this.cậpNhậtTìnhTrạngToolStripMenuItem.Name = "cậpNhậtTìnhTrạngToolStripMenuItem";
            this.cậpNhậtTìnhTrạngToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.cậpNhậtTìnhTrạngToolStripMenuItem.Text = "Cập nhật tình trạng";
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "TÌM KIẾM PHIẾU";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.SkyBlue;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(494, 39);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(95, 23);
            this.btnTimKiem.TabIndex = 7;
            this.btnTimKiem.Text = "TÌM KIẾM";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // txtNoiDungTim
            // 
            this.txtNoiDungTim.Location = new System.Drawing.Point(211, 40);
            this.txtNoiDungTim.Name = "txtNoiDungTim";
            this.txtNoiDungTim.Size = new System.Drawing.Size(262, 22);
            this.txtNoiDungTim.TabIndex = 6;
            // 
            // cbDanhMuc
            // 
            this.cbDanhMuc.FormattingEnabled = true;
            this.cbDanhMuc.Location = new System.Drawing.Point(52, 39);
            this.cbDanhMuc.Name = "cbDanhMuc";
            this.cbDanhMuc.Size = new System.Drawing.Size(154, 25);
            this.cbDanhMuc.TabIndex = 5;
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 40;
            // 
            // MaPhieuMuon
            // 
            this.MaPhieuMuon.HeaderText = "Mã Phiếu Mượn";
            this.MaPhieuMuon.Name = "MaPhieuMuon";
            this.MaPhieuMuon.Width = 130;
            // 
            // MaDocGia
            // 
            this.MaDocGia.HeaderText = "Mã Độc Giả";
            this.MaDocGia.Name = "MaDocGia";
            this.MaDocGia.Width = 130;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số lượng sách";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 50;
            // 
            // NgayMuon
            // 
            this.NgayMuon.HeaderText = "Ngày Mượn";
            this.NgayMuon.Name = "NgayMuon";
            // 
            // ThoiHan
            // 
            this.ThoiHan.HeaderText = "Thời Hạn";
            this.ThoiHan.Name = "ThoiHan";
            this.ThoiHan.Width = 80;
            // 
            // TienCoc
            // 
            this.TienCoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TienCoc.HeaderText = "Tiền Cọc";
            this.TienCoc.Name = "TienCoc";
            // 
            // DaTra
            // 
            this.DaTra.HeaderText = "Đã Trả";
            this.DaTra.Name = "DaTra";
            this.DaTra.Width = 40;
            // 
            // ViPham
            // 
            this.ViPham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ViPham.HeaderText = "Vi Phạm";
            this.ViPham.Name = "ViPham";
            this.ViPham.Width = 55;
            // 
            // xemViPhạmToolStripMenuItem
            // 
            this.xemViPhạmToolStripMenuItem.Name = "xemViPhạmToolStripMenuItem";
            this.xemViPhạmToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.xemViPhạmToolStripMenuItem.Text = "Xem Vi Phạm";
            // 
            // DanhSachPhieuUSPL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvDSPhieuMuon);
            this.Controls.Add(this.TopPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DanhSachPhieuUSPL";
            this.Size = new System.Drawing.Size(720, 460);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPhieuMuon)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.DataGridView dgvDSPhieuMuon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtTìnhTrạngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtNoiDungTim;
        private System.Windows.Forms.ComboBox cbDanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPhieuMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDocGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiHan;
        private System.Windows.Forms.DataGridViewTextBoxColumn TienCoc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DaTra;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ViPham;
        private System.Windows.Forms.ToolStripMenuItem xemViPhạmToolStripMenuItem;
    }
}
