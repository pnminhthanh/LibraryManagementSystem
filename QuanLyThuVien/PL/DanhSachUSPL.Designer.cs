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
            this.dgvDSSach = new System.Windows.Forms.DataGridView();
            this.cbDanhMuc = new System.Windows.Forms.ComboBox();
            this.txtNoiDungTim = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cậpNhậtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhSáchBảnSaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSach)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDSSach
            // 
            this.dgvDSSach.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDSSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSach.GridColor = System.Drawing.SystemColors.Window;
            this.dgvDSSach.Location = new System.Drawing.Point(0, 80);
            this.dgvDSSach.Name = "dgvDSSach";
            this.dgvDSSach.Size = new System.Drawing.Size(720, 380);
            this.dgvDSSach.TabIndex = 0;
            // 
            // cbDanhMuc
            // 
            this.cbDanhMuc.FormattingEnabled = true;
            this.cbDanhMuc.Location = new System.Drawing.Point(38, 38);
            this.cbDanhMuc.Name = "cbDanhMuc";
            this.cbDanhMuc.Size = new System.Drawing.Size(154, 21);
            this.cbDanhMuc.TabIndex = 1;
            // 
            // txtNoiDungTim
            // 
            this.txtNoiDungTim.Location = new System.Drawing.Point(197, 39);
            this.txtNoiDungTim.Name = "txtNoiDungTim";
            this.txtNoiDungTim.Size = new System.Drawing.Size(262, 20);
            this.txtNoiDungTim.TabIndex = 2;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Location = new System.Drawing.Point(480, 38);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(95, 23);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "TÌM KIẾM";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "TÌM KIẾM SÁCH:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cậpNhậtToolStripMenuItem,
            this.xóaToolStripMenuItem,
            this.danhSáchBảnSaoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(176, 70);
            // 
            // cậpNhậtToolStripMenuItem
            // 
            this.cậpNhậtToolStripMenuItem.Name = "cậpNhậtToolStripMenuItem";
            this.cậpNhậtToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.cậpNhậtToolStripMenuItem.Text = "Cập Nhật";
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.xóaToolStripMenuItem.Text = "Xóa";
            // 
            // danhSáchBảnSaoToolStripMenuItem
            // 
            this.danhSáchBảnSaoToolStripMenuItem.Name = "danhSáchBảnSaoToolStripMenuItem";
            this.danhSáchBảnSaoToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.danhSáchBảnSaoToolStripMenuItem.Text = "Danh Sách Bản Sao";
            // 
            // DanhSachUSPL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtNoiDungTim);
            this.Controls.Add(this.cbDanhMuc);
            this.Controls.Add(this.dgvDSSach);
            this.Name = "DanhSachUSPL";
            this.Size = new System.Drawing.Size(720, 460);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSach)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSSach;
        private System.Windows.Forms.ComboBox cbDanhMuc;
        private System.Windows.Forms.TextBox txtNoiDungTim;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhSáchBảnSaoToolStripMenuItem;
    }
}
