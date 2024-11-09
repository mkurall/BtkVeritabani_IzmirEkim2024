namespace BtkKursTakip
{
    partial class FrmKurslar
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnSil = new Button();
            btnTamam = new Button();
            dataGridView1 = new DataGridView();
            colAd = new DataGridViewTextBoxColumn();
            colAciklama = new DataGridViewTextBoxColumn();
            colTarih = new DataGridViewTextBoxColumn();
            colSehir = new DataGridViewComboBoxColumn();
            colIlce = new DataGridViewComboBoxColumn();
            colKursYeri = new DataGridViewTextBoxColumn();
            colEgitmen = new DataGridViewComboBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 192, 255);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1213, 71);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(70, 16);
            label1.Name = "label1";
            label1.Size = new Size(107, 41);
            label1.TabIndex = 1;
            label1.Text = "Kurslar";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.online_learning;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 49);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnSil);
            panel2.Controls.Add(btnTamam);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 401);
            panel2.Name = "panel2";
            panel2.Size = new Size(1213, 64);
            panel2.TabIndex = 1;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.OrangeRed;
            btnSil.ForeColor = Color.White;
            btnSil.Location = new Point(12, 10);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(197, 44);
            btnSil.TabIndex = 1;
            btnSil.Text = "Seçili Kursu Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnTamam
            // 
            btnTamam.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTamam.BackColor = Color.SteelBlue;
            btnTamam.Font = new Font("Segoe UI", 11F);
            btnTamam.ForeColor = Color.White;
            btnTamam.Location = new Point(1066, 9);
            btnTamam.Name = "btnTamam";
            btnTamam.Size = new Size(135, 43);
            btnTamam.TabIndex = 0;
            btnTamam.Text = "Tamam";
            btnTamam.UseVisualStyleBackColor = false;
            btnTamam.Click += btnTamam_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colAd, colAciklama, colTarih, colSehir, colIlce, colKursYeri, colEgitmen });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 71);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1213, 330);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // colAd
            // 
            colAd.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colAd.DataPropertyName = "Ad";
            colAd.HeaderText = "Kurs Adı";
            colAd.MinimumWidth = 6;
            colAd.Name = "colAd";
            // 
            // colAciklama
            // 
            colAciklama.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colAciklama.DataPropertyName = "Aciklama";
            colAciklama.HeaderText = "Kurs Açıklaması";
            colAciklama.MinimumWidth = 6;
            colAciklama.Name = "colAciklama";
            // 
            // colTarih
            // 
            colTarih.DataPropertyName = "Tarih";
            colTarih.HeaderText = "Tarih";
            colTarih.MinimumWidth = 6;
            colTarih.Name = "colTarih";
            colTarih.Width = 125;
            // 
            // colSehir
            // 
            colSehir.DataPropertyName = "SehirId";
            colSehir.HeaderText = "Şehir";
            colSehir.MinimumWidth = 6;
            colSehir.Name = "colSehir";
            colSehir.Width = 125;
            // 
            // colIlce
            // 
            colIlce.DataPropertyName = "IlceId";
            colIlce.HeaderText = "İlçe";
            colIlce.MinimumWidth = 6;
            colIlce.Name = "colIlce";
            colIlce.Width = 125;
            // 
            // colKursYeri
            // 
            colKursYeri.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colKursYeri.DataPropertyName = "KursYeri";
            colKursYeri.HeaderText = "Kurs Yeri";
            colKursYeri.MinimumWidth = 6;
            colKursYeri.Name = "colKursYeri";
            // 
            // colEgitmen
            // 
            colEgitmen.DataPropertyName = "EgitmenId";
            colEgitmen.HeaderText = "Eğitmen";
            colEgitmen.MinimumWidth = 6;
            colEgitmen.Name = "colEgitmen";
            colEgitmen.Width = 200;
            // 
            // FrmKurslar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1213, 465);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmKurslar";
            Text = "Kurslar";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private Button btnTamam;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colAd;
        private DataGridViewTextBoxColumn colAciklama;
        private DataGridViewTextBoxColumn colTarih;
        private DataGridViewComboBoxColumn colSehir;
        private DataGridViewComboBoxColumn colIlce;
        private DataGridViewTextBoxColumn colKursYeri;
        private DataGridViewComboBoxColumn colEgitmen;
        private Button btnSil;
    }
}