﻿namespace QuanLyThuVien.PL
{
    partial class MuonTraSachPL
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnThunho = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.btnTimPhieu = new System.Windows.Forms.Button();
            this.btnTao = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.chinhSuaPhieuMuonUSPL1 = new QuanLyThuVien.PL.ChinhSuaPhieuMuonUSPL();
            this.timKiemPhieu1 = new QuanLyThuVien.PL.TimKiemPhieu();
            this.TopPanel.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.Black;
            this.TopPanel.Controls.Add(this.btnBack);
            this.TopPanel.Controls.Add(this.btnThunho);
            this.TopPanel.Controls.Add(this.btnThoat);
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(1000, 50);
            this.TopPanel.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(27, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(50, 50);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "<-";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnThunho
            // 
            this.btnThunho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThunho.ForeColor = System.Drawing.Color.LightCyan;
            this.btnThunho.Location = new System.Drawing.Point(924, 12);
            this.btnThunho.Name = "btnThunho";
            this.btnThunho.Size = new System.Drawing.Size(30, 30);
            this.btnThunho.TabIndex = 1;
            this.btnThunho.Text = "_";
            this.btnThunho.UseVisualStyleBackColor = true;
            this.btnThunho.Click += new System.EventHandler(this.btnThunho_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.ForeColor = System.Drawing.Color.LightCyan;
            this.btnThoat.Location = new System.Drawing.Point(960, 12);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(30, 30);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "X";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(96)))), ((int)(((byte)(135)))));
            this.LeftPanel.Controls.Add(this.btnTimPhieu);
            this.LeftPanel.Controls.Add(this.btnTao);
            this.LeftPanel.Controls.Add(this.SidePanel);
            this.LeftPanel.Location = new System.Drawing.Point(0, 50);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(200, 550);
            this.LeftPanel.TabIndex = 1;
            // 
            // btnTimPhieu
            // 
            this.btnTimPhieu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(96)))), ((int)(((byte)(135)))));
            this.btnTimPhieu.FlatAppearance.BorderSize = 0;
            this.btnTimPhieu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimPhieu.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimPhieu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(201)))), ((int)(((byte)(220)))));
            this.btnTimPhieu.Location = new System.Drawing.Point(12, 235);
            this.btnTimPhieu.Name = "btnTimPhieu";
            this.btnTimPhieu.Size = new System.Drawing.Size(190, 100);
            this.btnTimPhieu.TabIndex = 1;
            this.btnTimPhieu.Text = "TÌM PHIẾU";
            this.btnTimPhieu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimPhieu.UseVisualStyleBackColor = false;
            this.btnTimPhieu.Click += new System.EventHandler(this.btnTimPhieu_Click);
            // 
            // btnTao
            // 
            this.btnTao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(96)))), ((int)(((byte)(135)))));
            this.btnTao.FlatAppearance.BorderSize = 0;
            this.btnTao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTao.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(201)))), ((int)(((byte)(220)))));
            this.btnTao.Location = new System.Drawing.Point(12, 135);
            this.btnTao.Name = "btnTao";
            this.btnTao.Size = new System.Drawing.Size(190, 100);
            this.btnTao.TabIndex = 1;
            this.btnTao.Text = "TẠO PHIẾU";
            this.btnTao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTao.UseVisualStyleBackColor = false;
            this.btnTao.Click += new System.EventHandler(this.btnTao_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(42)))), ((int)(((byte)(65)))));
            this.SidePanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(201)))), ((int)(((byte)(220)))));
            this.SidePanel.Location = new System.Drawing.Point(2, 135);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 100);
            this.SidePanel.TabIndex = 0;
            // 
            // chinhSuaPhieuMuonUSPL1
            // 
            this.chinhSuaPhieuMuonUSPL1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.chinhSuaPhieuMuonUSPL1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chinhSuaPhieuMuonUSPL1.Location = new System.Drawing.Point(200, 50);
            this.chinhSuaPhieuMuonUSPL1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chinhSuaPhieuMuonUSPL1.Name = "chinhSuaPhieuMuonUSPL1";
            this.chinhSuaPhieuMuonUSPL1.Size = new System.Drawing.Size(800, 550);
            this.chinhSuaPhieuMuonUSPL1.TabIndex = 3;
            // 
            // timKiemPhieu1
            // 
            this.timKiemPhieu1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timKiemPhieu1.Location = new System.Drawing.Point(200, 50);
            this.timKiemPhieu1.Margin = new System.Windows.Forms.Padding(4);
            this.timKiemPhieu1.Name = "timKiemPhieu1";
            this.timKiemPhieu1.Size = new System.Drawing.Size(800, 550);
            this.timKiemPhieu1.TabIndex = 2;
            // 
            // MuonTraSachPL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.chinhSuaPhieuMuonUSPL1);
            this.Controls.Add(this.timKiemPhieu1);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(10, 10);
            this.Name = "MuonTraSachPL";
            this.Text = "MuonTraSachPL";
            this.TopPanel.ResumeLayout(false);
            this.LeftPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Button btnThunho;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnTao;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button btnTimPhieu;
        private TimKiemPhieu timKiemPhieu1;
        private ChinhSuaPhieuMuonUSPL chinhSuaPhieuMuonUSPL1;
    }
}