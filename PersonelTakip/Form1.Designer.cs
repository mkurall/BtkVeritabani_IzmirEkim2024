namespace PersonelTakip
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbPersoneller = new ListBox();
            btnPersonelleriGetir = new Button();
            comboBox1 = new ComboBox();
            label1 = new Label();
            btnBirimleriGetir = new Button();
            btnEfCoreKullan = new Button();
            txtYeniBirim = new TextBox();
            label2 = new Label();
            btnBirimEkle = new Button();
            SuspendLayout();
            // 
            // lbPersoneller
            // 
            lbPersoneller.FormattingEnabled = true;
            lbPersoneller.Location = new Point(12, 67);
            lbPersoneller.Name = "lbPersoneller";
            lbPersoneller.Size = new Size(260, 344);
            lbPersoneller.TabIndex = 0;
            // 
            // btnPersonelleriGetir
            // 
            btnPersonelleriGetir.BackColor = Color.FromArgb(255, 192, 128);
            btnPersonelleriGetir.Location = new Point(12, 12);
            btnPersonelleriGetir.Name = "btnPersonelleriGetir";
            btnPersonelleriGetir.Size = new Size(260, 49);
            btnPersonelleriGetir.TabIndex = 1;
            btnPersonelleriGetir.Text = "Personelleri Getir";
            btnPersonelleriGetir.UseVisualStyleBackColor = false;
            btnPersonelleriGetir.Click += btnPersonelleriGetir_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(388, 174);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(311, 28);
            comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(322, 177);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 3;
            label1.Text = "Birimi";
            // 
            // btnBirimleriGetir
            // 
            btnBirimleriGetir.Location = new Point(301, 22);
            btnBirimleriGetir.Name = "btnBirimleriGetir";
            btnBirimleriGetir.Size = new Size(145, 29);
            btnBirimleriGetir.TabIndex = 4;
            btnBirimleriGetir.Text = "Birimleri Getir";
            btnBirimleriGetir.UseVisualStyleBackColor = true;
            btnBirimleriGetir.Click += btnBirimleriGetir_Click;
            // 
            // btnEfCoreKullan
            // 
            btnEfCoreKullan.BackColor = Color.FromArgb(128, 255, 128);
            btnEfCoreKullan.Location = new Point(529, 26);
            btnEfCoreKullan.Name = "btnEfCoreKullan";
            btnEfCoreKullan.Size = new Size(249, 86);
            btnEfCoreKullan.TabIndex = 5;
            btnEfCoreKullan.Text = "EF Core Kullanarak Verileri Getir";
            btnEfCoreKullan.UseVisualStyleBackColor = false;
            btnEfCoreKullan.Click += btnEfCoreKullan_Click;
            // 
            // txtYeniBirim
            // 
            txtYeniBirim.Location = new Point(388, 141);
            txtYeniBirim.Name = "txtYeniBirim";
            txtYeniBirim.Size = new Size(311, 27);
            txtYeniBirim.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(307, 144);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 7;
            label2.Text = "Yeni Birim";
            // 
            // btnBirimEkle
            // 
            btnBirimEkle.Location = new Point(707, 142);
            btnBirimEkle.Name = "btnBirimEkle";
            btnBirimEkle.Size = new Size(94, 29);
            btnBirimEkle.TabIndex = 8;
            btnBirimEkle.Text = "Ekle";
            btnBirimEkle.UseVisualStyleBackColor = true;
            btnBirimEkle.Click += btnBirimEkle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 456);
            Controls.Add(btnBirimEkle);
            Controls.Add(label2);
            Controls.Add(txtYeniBirim);
            Controls.Add(btnEfCoreKullan);
            Controls.Add(btnBirimleriGetir);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Controls.Add(btnPersonelleriGetir);
            Controls.Add(lbPersoneller);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbPersoneller;
        private Button btnPersonelleriGetir;
        private ComboBox comboBox1;
        private Label label1;
        private Button btnBirimleriGetir;
        private Button btnEfCoreKullan;
        private TextBox txtYeniBirim;
        private Label label2;
        private Button btnBirimEkle;
    }
}
