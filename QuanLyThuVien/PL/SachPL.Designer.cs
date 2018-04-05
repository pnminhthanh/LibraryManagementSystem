namespace QuanLyThuVien.PL
{
    partial class SachPL
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TopPanel = new System.Windows.Forms.Panel();
            this.btnThunho = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnDanhSach = new System.Windows.Forms.Button();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.DanhSachUSPL = new QuanLyThuVien.PL.DanhSachUSPL();
            this.chinhSuaSachUSPL1 = new QuanLyThuVien.PL.ChinhSuaSachUSPL();
            this.timKiemSachPL1 = new QuanLyThuVien.PL.TimKiemSachPL();
            this.TopPanel.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.SystemColors.ControlText;
            this.TopPanel.Controls.Add(this.btnThunho);
            this.TopPanel.Controls.Add(this.btnThoat);
            this.TopPanel.Location = new System.Drawing.Point(200, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(800, 50);
            this.TopPanel.TabIndex = 1;
            // 
            // btnThunho
            // 
            this.btnThunho.Location = new System.Drawing.Point(727, 10);
            this.btnThunho.Name = "btnThunho";
            this.btnThunho.Size = new System.Drawing.Size(30, 30);
            this.btnThunho.TabIndex = 3;
            this.btnThunho.Text = "_";
            this.btnThunho.UseVisualStyleBackColor = true;
            this.btnThunho.Click += new System.EventHandler(this.btnThunho_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(763, 10);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(30, 30);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "X";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.SystemColors.WindowText;
            this.SidePanel.Location = new System.Drawing.Point(0, 131);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 100);
            this.SidePanel.TabIndex = 0;
            // 
            // btnDanhSach
            // 
            this.btnDanhSach.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnDanhSach.FlatAppearance.BorderSize = 0;
            this.btnDanhSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhSach.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhSach.ForeColor = System.Drawing.Color.White;
            this.btnDanhSach.Location = new System.Drawing.Point(10, 131);
            this.btnDanhSach.Name = "btnDanhSach";
            this.btnDanhSach.Size = new System.Drawing.Size(190, 100);
            this.btnDanhSach.TabIndex = 1;
            this.btnDanhSach.Text = "DANH SÁCH";
            this.btnDanhSach.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDanhSach.UseVisualStyleBackColor = false;
            this.btnDanhSach.Click += new System.EventHandler(this.btnDanhSach_Click);
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnChinhSua.FlatAppearance.BorderSize = 0;
            this.btnChinhSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChinhSua.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChinhSua.ForeColor = System.Drawing.Color.White;
            this.btnChinhSua.Location = new System.Drawing.Point(10, 231);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(190, 100);
            this.btnChinhSua.TabIndex = 1;
            this.btnChinhSua.Text = "CHỈNH SỬA";
            this.btnChinhSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChinhSua.UseVisualStyleBackColor = false;
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.White;
            this.btnTimKiem.Location = new System.Drawing.Point(10, 331);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(190, 100);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "TÌM KIẾM";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(10, 10);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 50);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "<-";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.LeftPanel.Controls.Add(this.btnBack);
            this.LeftPanel.Controls.Add(this.btnTimKiem);
            this.LeftPanel.Controls.Add(this.btnChinhSua);
            this.LeftPanel.Controls.Add(this.btnDanhSach);
            this.LeftPanel.Controls.Add(this.SidePanel);
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(200, 600);
            this.LeftPanel.TabIndex = 0;
            // 
            // DanhSachUSPL
            // 
            this.DanhSachUSPL.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DanhSachUSPL.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DanhSachUSPL.Location = new System.Drawing.Point(200, 50);
            this.DanhSachUSPL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DanhSachUSPL.Name = "DanhSachUSPL";
            this.DanhSachUSPL.Size = new System.Drawing.Size(800, 550);
            this.DanhSachUSPL.TabIndex = 4;
            // 
            // chinhSuaSachUSPL1
            // 
            this.chinhSuaSachUSPL1.Location = new System.Drawing.Point(200, 50);
            this.chinhSuaSachUSPL1.Name = "chinhSuaSachUSPL1";
            this.chinhSuaSachUSPL1.Size = new System.Drawing.Size(800, 550);
            this.chinhSuaSachUSPL1.TabIndex = 3;
            // 
            // timKiemSachPL1
            // 
            this.timKiemSachPL1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.timKiemSachPL1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timKiemSachPL1.Location = new System.Drawing.Point(200, 50);
            this.timKiemSachPL1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.timKiemSachPL1.Name = "timKiemSachPL1";
            this.timKiemSachPL1.Size = new System.Drawing.Size(800, 550);
            this.timKiemSachPL1.TabIndex = 2;
            // 
            // SachPL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.DanhSachUSPL);
            this.Controls.Add(this.chinhSuaSachUSPL1);
            this.Controls.Add(this.timKiemSachPL1);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.LeftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SachPL";
            this.Text = "SachPL";
            this.TopPanel.ResumeLayout(false);
            this.LeftPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button btnDanhSach;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Button btnThunho;
        private System.Windows.Forms.Button btnThoat;
        private TimKiemSachPL timKiemSachPL1;
        private ChinhSuaSachUSPL chinhSuaSachUSPL1;
        private DanhSachUSPL DanhSachUSPL;
    }
}