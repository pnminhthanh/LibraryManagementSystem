namespace QuanLyThuVien
{
    partial class MainForm
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
            this.btnSach = new System.Windows.Forms.Button();
            this.btnThanhVien = new System.Windows.Forms.Button();
            this.btnMuonTra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSach
            // 
            this.btnSach.BackColor = System.Drawing.Color.Silver;
            this.btnSach.FlatAppearance.BorderSize = 0;
            this.btnSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSach.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSach.Location = new System.Drawing.Point(164, 184);
            this.btnSach.Name = "btnSach";
            this.btnSach.Size = new System.Drawing.Size(140, 205);
            this.btnSach.TabIndex = 0;
            this.btnSach.Text = "SÁCH";
            this.btnSach.UseVisualStyleBackColor = false;
            // 
            // btnThanhVien
            // 
            this.btnThanhVien.BackColor = System.Drawing.Color.Silver;
            this.btnThanhVien.FlatAppearance.BorderSize = 0;
            this.btnThanhVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhVien.Font = new System.Drawing.Font("Segoe UI Symbol", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhVien.Location = new System.Drawing.Point(340, 184);
            this.btnThanhVien.Name = "btnThanhVien";
            this.btnThanhVien.Size = new System.Drawing.Size(140, 205);
            this.btnThanhVien.TabIndex = 0;
            this.btnThanhVien.Text = "THÀNH VIÊN";
            this.btnThanhVien.UseVisualStyleBackColor = false;
            // 
            // btnMuonTra
            // 
            this.btnMuonTra.BackColor = System.Drawing.Color.Silver;
            this.btnMuonTra.FlatAppearance.BorderSize = 0;
            this.btnMuonTra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMuonTra.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMuonTra.Location = new System.Drawing.Point(512, 184);
            this.btnMuonTra.Name = "btnMuonTra";
            this.btnMuonTra.Size = new System.Drawing.Size(140, 205);
            this.btnMuonTra.TabIndex = 0;
            this.btnMuonTra.Text = "MƯỢN / TRẢ SÁCH";
            this.btnMuonTra.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(525, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "PHẦN MỀM QUẢN LÝ THƯ VIỆN";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMuonTra);
            this.Controls.Add(this.btnThanhVien);
            this.Controls.Add(this.btnSach);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSach;
        private System.Windows.Forms.Button btnThanhVien;
        private System.Windows.Forms.Button btnMuonTra;
        private System.Windows.Forms.Label label1;
    }
}

