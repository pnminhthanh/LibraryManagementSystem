namespace QuanLyThuVien.PL
{
    partial class ThanhVienPL
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
            this.btnThuNho = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.btnDanhSach = new System.Windows.Forms.Button();
            this.locThanhVienPS1 = new QuanLyThuVien.PL.LocThanhVienPS();
            this.chinhSuaThanhVienUSPL1 = new QuanLyThuVien.PL.ChinhSuaThanhVienUSPL();
            this.dsThanhVienUSPL1 = new QuanLyThuVien.PL.DSThanhVienUSPL();
            this.TopPanel.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.TopPanel.Controls.Add(this.btnThuNho);
            this.TopPanel.Controls.Add(this.btnThoat);
            this.TopPanel.Controls.Add(this.btnBack);
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1000, 50);
            this.TopPanel.TabIndex = 0;
            // 
            // btnThuNho
            // 
            this.btnThuNho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThuNho.ForeColor = System.Drawing.Color.LightCyan;
            this.btnThuNho.Location = new System.Drawing.Point(924, 12);
            this.btnThuNho.Name = "btnThuNho";
            this.btnThuNho.Size = new System.Drawing.Size(30, 30);
            this.btnThuNho.TabIndex = 3;
            this.btnThuNho.Text = "_";
            this.btnThuNho.UseVisualStyleBackColor = true;
            this.btnThuNho.Click += new System.EventHandler(this.btnThuNho_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.ForeColor = System.Drawing.Color.LightCyan;
            this.btnThoat.Location = new System.Drawing.Point(960, 12);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(30, 30);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "X";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.LightCyan;
            this.btnBack.Location = new System.Drawing.Point(27, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 50);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "<--";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.LeftPanel.Controls.Add(this.SidePanel);
            this.LeftPanel.Controls.Add(this.btnTimKiem);
            this.LeftPanel.Controls.Add(this.btnChinhSua);
            this.LeftPanel.Controls.Add(this.btnDanhSach);
            this.LeftPanel.Location = new System.Drawing.Point(0, 50);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(200, 550);
            this.LeftPanel.TabIndex = 1;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.SteelBlue;
            this.SidePanel.Location = new System.Drawing.Point(2, 130);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 100);
            this.SidePanel.TabIndex = 2;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.FlatAppearance.BorderSize = 0;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnTimKiem.Location = new System.Drawing.Point(12, 330);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(190, 100);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "TÌM KIẾM";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.FlatAppearance.BorderSize = 0;
            this.btnChinhSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChinhSua.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChinhSua.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnChinhSua.Location = new System.Drawing.Point(12, 230);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(190, 100);
            this.btnChinhSua.TabIndex = 1;
            this.btnChinhSua.Text = "CHỈNH SỬA";
            this.btnChinhSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChinhSua.UseVisualStyleBackColor = true;
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // btnDanhSach
            // 
            this.btnDanhSach.FlatAppearance.BorderSize = 0;
            this.btnDanhSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhSach.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhSach.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnDanhSach.Location = new System.Drawing.Point(12, 130);
            this.btnDanhSach.Name = "btnDanhSach";
            this.btnDanhSach.Size = new System.Drawing.Size(190, 100);
            this.btnDanhSach.TabIndex = 1;
            this.btnDanhSach.Text = "DANH SÁCH";
            this.btnDanhSach.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDanhSach.UseVisualStyleBackColor = true;
            this.btnDanhSach.Click += new System.EventHandler(this.btnDanhSach_Click);
            // 
            // locThanhVienPS1
            // 
            this.locThanhVienPS1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.locThanhVienPS1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locThanhVienPS1.Location = new System.Drawing.Point(200, 50);
            this.locThanhVienPS1.Margin = new System.Windows.Forms.Padding(4);
            this.locThanhVienPS1.Name = "locThanhVienPS1";
            this.locThanhVienPS1.Size = new System.Drawing.Size(800, 550);
            this.locThanhVienPS1.TabIndex = 2;
            // 
            // chinhSuaThanhVienUSPL1
            // 
            this.chinhSuaThanhVienUSPL1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.chinhSuaThanhVienUSPL1.Font = new System.Drawing.Font("Century Gothic", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chinhSuaThanhVienUSPL1.Location = new System.Drawing.Point(200, 50);
            this.chinhSuaThanhVienUSPL1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chinhSuaThanhVienUSPL1.Name = "chinhSuaThanhVienUSPL1";
            this.chinhSuaThanhVienUSPL1.Size = new System.Drawing.Size(800, 550);
            this.chinhSuaThanhVienUSPL1.TabIndex = 3;
            // 
            // dsThanhVienUSPL1
            // 
            this.dsThanhVienUSPL1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dsThanhVienUSPL1.Location = new System.Drawing.Point(200, 50);
            this.dsThanhVienUSPL1.Margin = new System.Windows.Forms.Padding(4);
            this.dsThanhVienUSPL1.Name = "dsThanhVienUSPL1";
            this.dsThanhVienUSPL1.Size = new System.Drawing.Size(800, 550);
            this.dsThanhVienUSPL1.TabIndex = 4;
            // 
            // ThanhVienPL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.dsThanhVienUSPL1);
            this.Controls.Add(this.chinhSuaThanhVienUSPL1);
            this.Controls.Add(this.locThanhVienPS1);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.TopPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ThanhVienPL";
            this.Text = "ThanhVienPL";
            this.TopPanel.ResumeLayout(false);
            this.LeftPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Button btnDanhSach;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnThuNho;
        private System.Windows.Forms.Button btnThoat;
        private LocThanhVienPS locThanhVienPS1;
        private ChinhSuaThanhVienUSPL chinhSuaThanhVienUSPL1;
        private DSThanhVienUSPL dsThanhVienUSPL1;
    }
}