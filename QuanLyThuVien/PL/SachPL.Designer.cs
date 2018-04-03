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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDanhSach = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.SidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.TopPanel.Location = new System.Drawing.Point(180, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(720, 40);
            this.TopPanel.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 80);
            this.panel2.TabIndex = 0;
            // 
            // btnDanhSach
            // 
            this.btnDanhSach.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnDanhSach.FlatAppearance.BorderSize = 0;
            this.btnDanhSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhSach.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhSach.ForeColor = System.Drawing.Color.White;
            this.btnDanhSach.Location = new System.Drawing.Point(10, 100);
            this.btnDanhSach.Name = "btnDanhSach";
            this.btnDanhSach.Size = new System.Drawing.Size(170, 80);
            this.btnDanhSach.TabIndex = 1;
            this.btnDanhSach.Text = "DANH SÁCH";
            this.btnDanhSach.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDanhSach.UseVisualStyleBackColor = false;
            this.btnDanhSach.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(10, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 80);
            this.button1.TabIndex = 1;
            this.button1.Text = "CHỈNH SỬA";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(10, 260);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 80);
            this.button2.TabIndex = 1;
            this.button2.Text = "TÌM KIẾM";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button1_Click);
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
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.SidePanel.Controls.Add(this.btnBack);
            this.SidePanel.Controls.Add(this.button2);
            this.SidePanel.Controls.Add(this.button1);
            this.SidePanel.Controls.Add(this.btnDanhSach);
            this.SidePanel.Controls.Add(this.panel2);
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(180, 500);
            this.SidePanel.TabIndex = 0;
            // 
            // SachPL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.SidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SachPL";
            this.Text = "SachPL";
            this.SidePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDanhSach;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel SidePanel;
    }
}