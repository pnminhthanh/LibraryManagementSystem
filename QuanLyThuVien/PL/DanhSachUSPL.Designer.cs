namespace QuanLyThuVien.PL
{
    partial class DanhSachUSPL
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDSSach = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xemThôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSach)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDSSach
            // 
            this.dgvDSSach.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDSSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaSach,
            this.TenSach,
            this.TacGia,
            this.NXB,
            this.GiaTien});
            this.dgvDSSach.GridColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvDSSach.Location = new System.Drawing.Point(0, 35);
            this.dgvDSSach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvDSSach.Name = "dgvDSSach";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSSach.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDSSach.RowHeadersVisible = false;
            this.dgvDSSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSSach.Size = new System.Drawing.Size(800, 515);
            this.dgvDSSach.TabIndex = 0;
            this.dgvDSSach.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDSSach_CellMouseClick);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 50;
            // 
            // MaSach
            // 
            this.MaSach.HeaderText = "Mã Sách";
            this.MaSach.Name = "MaSach";
            // 
            // TenSach
            // 
            this.TenSach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenSach.HeaderText = "Tên Sách";
            this.TenSach.Name = "TenSach";
            // 
            // TacGia
            // 
            this.TacGia.HeaderText = "Tác Giả";
            this.TacGia.Name = "TacGia";
            this.TacGia.Width = 120;
            // 
            // NXB
            // 
            this.NXB.HeaderText = "NXB";
            this.NXB.Name = "NXB";
            // 
            // GiaTien
            // 
            this.GiaTien.HeaderText = "Giá Tiền";
            this.GiaTien.Name = "GiaTien";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemThôngTinToolStripMenuItem,
            this.cậpNhậtToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            // 
            // xemThôngTinToolStripMenuItem
            // 
            this.xemThôngTinToolStripMenuItem.Name = "xemThôngTinToolStripMenuItem";
            this.xemThôngTinToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.xemThôngTinToolStripMenuItem.Text = "Xem thông tin";
            this.xemThôngTinToolStripMenuItem.Click += new System.EventHandler(this.xemThôngTinToolStripMenuItem_Click);
            // 
            // cậpNhậtToolStripMenuItem
            // 
            this.cậpNhậtToolStripMenuItem.Name = "cậpNhậtToolStripMenuItem";
            this.cậpNhậtToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.cậpNhậtToolStripMenuItem.Text = "Cập Nhật";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 35);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(279, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH ĐẦU SÁCH";
            // 
            // DanhSachUSPL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDSSach);
            this.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DanhSachUSPL";
            this.Size = new System.Drawing.Size(800, 550);
            this.Load += new System.EventHandler(this.DanhSachUSPL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSach)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSSach;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemThôngTinToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn NXB;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaTien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}
