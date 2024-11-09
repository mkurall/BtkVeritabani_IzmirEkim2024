namespace BtkKursTakip
{
    partial class FrmEgitmenler
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnTamam = new Button();
            dataGridView1 = new DataGridView();
            colAd = new DataGridViewTextBoxColumn();
            colSoyad = new DataGridViewTextBoxColumn();
            colSil = new DataGridViewButtonColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 255, 192);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(598, 71);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F);
            label1.Location = new Point(70, 16);
            label1.Name = "label1";
            label1.Size = new Size(160, 41);
            label1.TabIndex = 1;
            label1.Text = "Eğitmenler";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.training;
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
            panel2.Controls.Add(btnTamam);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 440);
            panel2.Name = "panel2";
            panel2.Size = new Size(598, 64);
            panel2.TabIndex = 1;
            // 
            // btnTamam
            // 
            btnTamam.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTamam.BackColor = Color.SteelBlue;
            btnTamam.Font = new Font("Segoe UI", 11F);
            btnTamam.ForeColor = Color.White;
            btnTamam.Location = new Point(451, 9);
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colAd, colSoyad, colSil });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 71);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(598, 369);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellPainting += dataGridView1_CellPainting;
            // 
            // colAd
            // 
            colAd.DataPropertyName = "Ad";
            colAd.HeaderText = "Eğitmen Adı";
            colAd.MinimumWidth = 6;
            colAd.Name = "colAd";
            colAd.Width = 200;
            // 
            // colSoyad
            // 
            colSoyad.DataPropertyName = "Soyad";
            colSoyad.HeaderText = "Eğitmen Soyadı";
            colSoyad.MinimumWidth = 6;
            colSoyad.Name = "colSoyad";
            colSoyad.Width = 200;
            // 
            // colSil
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.ForeColor = Color.White;
            colSil.DefaultCellStyle = dataGridViewCellStyle1;
            colSil.HeaderText = "Sil";
            colSil.MinimumWidth = 6;
            colSil.Name = "colSil";
            colSil.Text = "";
            colSil.Width = 125;
            // 
            // FrmEgitmenler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 504);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmEgitmenler";
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
        private DataGridViewTextBoxColumn colSoyad;
        private DataGridViewButtonColumn colSil;
    }
}