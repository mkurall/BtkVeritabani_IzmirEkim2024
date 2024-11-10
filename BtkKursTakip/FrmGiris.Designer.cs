namespace BtkKursTakip
{
    partial class FrmGiris
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
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            txtKullaniciAdi = new TextBox();
            label4 = new Label();
            txtParola = new TextBox();
            btnOturumAc = new Button();
            lblBilgi = new Label();
            pbLoading = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbLoading).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(465, 132);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(295, 61);
            label2.Name = "label2";
            label2.Size = new Size(167, 37);
            label2.TabIndex = 2;
            label2.Text = "Güvenli Giriş";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F);
            label1.Location = new Point(117, 11);
            label1.Name = "label1";
            label1.Size = new Size(345, 50);
            label1.TabIndex = 1;
            label1.Text = "BtkKurs Uygulaması";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user__2_;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 107);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(29, 176);
            label3.Name = "label3";
            label3.Size = new Size(120, 28);
            label3.TabIndex = 1;
            label3.Text = "Kullanıcı Adı";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Font = new Font("Segoe UI", 12F);
            txtKullaniciAdi.Location = new Point(29, 207);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(404, 34);
            txtKullaniciAdi.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(29, 244);
            label4.Name = "label4";
            label4.Size = new Size(66, 28);
            label4.TabIndex = 1;
            label4.Text = "Parola";
            // 
            // txtParola
            // 
            txtParola.Font = new Font("Segoe UI", 12F);
            txtParola.Location = new Point(29, 275);
            txtParola.Name = "txtParola";
            txtParola.PasswordChar = '●';
            txtParola.Size = new Size(404, 34);
            txtParola.TabIndex = 2;
            // 
            // btnOturumAc
            // 
            btnOturumAc.BackColor = Color.DodgerBlue;
            btnOturumAc.Font = new Font("Segoe UI", 12F);
            btnOturumAc.ForeColor = Color.White;
            btnOturumAc.Location = new Point(29, 339);
            btnOturumAc.Name = "btnOturumAc";
            btnOturumAc.Size = new Size(404, 60);
            btnOturumAc.TabIndex = 3;
            btnOturumAc.Text = "Oturum Aç";
            btnOturumAc.UseVisualStyleBackColor = false;
            btnOturumAc.Click += btnOturumAc_Click;
            // 
            // lblBilgi
            // 
            lblBilgi.AutoSize = true;
            lblBilgi.Font = new Font("Segoe UI", 12F);
            lblBilgi.ForeColor = Color.Red;
            lblBilgi.Location = new Point(90, 413);
            lblBilgi.Name = "lblBilgi";
            lblBilgi.Size = new Size(276, 28);
            lblBilgi.TabIndex = 4;
            lblBilgi.Text = "Kullanıcı adı veya parola hatalı";
            lblBilgi.Visible = false;
            // 
            // pbLoading
            // 
            pbLoading.Image = Properties.Resources.rotate;
            pbLoading.Location = new Point(180, 405);
            pbLoading.Name = "pbLoading";
            pbLoading.Size = new Size(107, 87);
            pbLoading.SizeMode = PictureBoxSizeMode.Zoom;
            pbLoading.TabIndex = 5;
            pbLoading.TabStop = false;
            pbLoading.Visible = false;
            // 
            // FrmGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 493);
            Controls.Add(pbLoading);
            Controls.Add(lblBilgi);
            Controls.Add(btnOturumAc);
            Controls.Add(txtParola);
            Controls.Add(label4);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmGiris";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BtkKurs Uygulaması - Giriş";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbLoading).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label3;
        private TextBox txtKullaniciAdi;
        private Label label4;
        private TextBox txtParola;
        private Button btnOturumAc;
        private Label lblBilgi;
        private PictureBox pbLoading;
    }
}