namespace QuanLyThuVien.PL
{
    partial class ThemBanSaoPL
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.txtMaBanSao = new System.Windows.Forms.TextBox();
            this.dgvDSBS = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.checkCoTheMuon = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbMaKe = new System.Windows.Forms.ComboBox();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBanSao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoTheMuon = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MaKe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSBS)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÊM BẢN SAO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "MÃ SÁCH:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "MÃ BẢN SAO:";
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(139, 63);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(188, 22);
            this.txtMaSach.TabIndex = 3;
            // 
            // txtMaBanSao
            // 
            this.txtMaBanSao.Location = new System.Drawing.Point(139, 100);
            this.txtMaBanSao.Name = "txtMaBanSao";
            this.txtMaBanSao.Size = new System.Drawing.Size(188, 22);
            this.txtMaBanSao.TabIndex = 4;
            // 
            // dgvDSBS
            // 
            this.dgvDSBS.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDSBS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSBS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaSach,
            this.MaBanSao,
            this.CoTheMuon,
            this.MaKe});
            this.dgvDSBS.Location = new System.Drawing.Point(49, 223);
            this.dgvDSBS.Name = "dgvDSBS";
            this.dgvDSBS.RowHeadersVisible = false;
            this.dgvDSBS.Size = new System.Drawing.Size(494, 150);
            this.dgvDSBS.TabIndex = 5;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.SkyBlue;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Location = new System.Drawing.Point(368, 67);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(85, 30);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "THÊM";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Location = new System.Drawing.Point(368, 112);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(85, 30);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "SỬA";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // checkCoTheMuon
            // 
            this.checkCoTheMuon.AutoSize = true;
            this.checkCoTheMuon.Location = new System.Drawing.Point(139, 138);
            this.checkCoTheMuon.Name = "checkCoTheMuon";
            this.checkCoTheMuon.Size = new System.Drawing.Size(141, 21);
            this.checkCoTheMuon.TabIndex = 12;
            this.checkCoTheMuon.Text = "CÓ THỂ CHO MƯỢN";
            this.checkCoTheMuon.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "MÃ KỆ:";
            // 
            // cbMaKe
            // 
            this.cbMaKe.FormattingEnabled = true;
            this.cbMaKe.Location = new System.Drawing.Point(139, 166);
            this.cbMaKe.Name = "cbMaKe";
            this.cbMaKe.Size = new System.Drawing.Size(131, 25);
            this.cbMaKe.TabIndex = 13;
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
            this.MaSach.Width = 120;
            // 
            // MaBanSao
            // 
            this.MaBanSao.HeaderText = "Mã Bản Sao";
            this.MaBanSao.Name = "MaBanSao";
            this.MaBanSao.Width = 120;
            // 
            // CoTheMuon
            // 
            this.CoTheMuon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CoTheMuon.HeaderText = "Có Thể Mượn";
            this.CoTheMuon.Name = "CoTheMuon";
            // 
            // MaKe
            // 
            this.MaKe.HeaderText = "Mã Kệ";
            this.MaKe.Name = "MaKe";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.SkyBlue;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Location = new System.Drawing.Point(368, 157);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 30);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "XÓA";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.ForestGreen;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnLuu.Location = new System.Drawing.Point(481, 112);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(90, 40);
            this.btnLuu.TabIndex = 11;
            this.btnLuu.Text = "LƯU";
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(541, 8);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(30, 30);
            this.btnThoat.TabIndex = 14;
            this.btnThoat.Text = "X";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // ThemBanSaoPL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(583, 397);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.cbMaKe);
            this.Controls.Add(this.checkCoTheMuon);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvDSBS);
            this.Controls.Add(this.txtMaBanSao);
            this.Controls.Add(this.txtMaSach);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ThemBanSaoPL";
            this.Text = "ThemBanSaoPL";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSBS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.TextBox txtMaBanSao;
        private System.Windows.Forms.DataGridView dgvDSBS;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.CheckBox checkCoTheMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBanSao;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CoTheMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbMaKe;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThoat;
    }
}