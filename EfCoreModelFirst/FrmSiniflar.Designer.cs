namespace EfCoreModelFirst
{
    partial class FrmSiniflar
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
            lbSiniflar = new ListBox();
            btnTamam = new Button();
            label1 = new Label();
            txtSinifAdi = new TextBox();
            btnEkleGuncelle = new Button();
            btnYeni = new Button();
            SuspendLayout();
            // 
            // lbSiniflar
            // 
            lbSiniflar.FormattingEnabled = true;
            lbSiniflar.Location = new Point(6, 48);
            lbSiniflar.Name = "lbSiniflar";
            lbSiniflar.Size = new Size(324, 244);
            lbSiniflar.TabIndex = 0;
            lbSiniflar.SelectedIndexChanged += lbSiniflar_SelectedIndexChanged;
            // 
            // btnTamam
            // 
            btnTamam.BackColor = Color.SteelBlue;
            btnTamam.Font = new Font("Segoe UI", 12F);
            btnTamam.ForeColor = Color.White;
            btnTamam.Location = new Point(116, 365);
            btnTamam.Name = "btnTamam";
            btnTamam.Size = new Size(120, 50);
            btnTamam.TabIndex = 1;
            btnTamam.Text = "Tamam";
            btnTamam.UseVisualStyleBackColor = false;
            btnTamam.Click += btnTamam_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 303);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 2;
            label1.Text = "Sınıf";
            // 
            // txtSinifAdi
            // 
            txtSinifAdi.Location = new Point(57, 300);
            txtSinifAdi.Name = "txtSinifAdi";
            txtSinifAdi.Size = new Size(138, 27);
            txtSinifAdi.TabIndex = 3;
            // 
            // btnEkleGuncelle
            // 
            btnEkleGuncelle.Location = new Point(201, 300);
            btnEkleGuncelle.Name = "btnEkleGuncelle";
            btnEkleGuncelle.Size = new Size(129, 29);
            btnEkleGuncelle.TabIndex = 4;
            btnEkleGuncelle.Text = "Ekle/Güncelle";
            btnEkleGuncelle.UseVisualStyleBackColor = true;
            btnEkleGuncelle.Click += btnEkleGuncelle_Click;
            // 
            // btnYeni
            // 
            btnYeni.Location = new Point(236, 13);
            btnYeni.Name = "btnYeni";
            btnYeni.Size = new Size(94, 29);
            btnYeni.TabIndex = 5;
            btnYeni.Text = "Yeni";
            btnYeni.UseVisualStyleBackColor = true;
            btnYeni.Click += btnYeni_Click;
            // 
            // FrmSiniflar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 427);
            Controls.Add(btnYeni);
            Controls.Add(btnEkleGuncelle);
            Controls.Add(txtSinifAdi);
            Controls.Add(label1);
            Controls.Add(btnTamam);
            Controls.Add(lbSiniflar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmSiniflar";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sınıf Listesi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbSiniflar;
        private Button btnTamam;
        private Label label1;
        private TextBox txtSinifAdi;
        private Button btnEkleGuncelle;
        private Button btnYeni;
    }
}