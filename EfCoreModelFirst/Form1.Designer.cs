﻿namespace EfCoreModelFirst
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
            label1 = new Label();
            btnSiniflar = new Button();
            dataGridView1 = new DataGridView();
            colAd = new DataGridViewTextBoxColumn();
            colSoyad = new DataGridViewTextBoxColumn();
            colNumara = new DataGridViewTextBoxColumn();
            btnKaydet = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(329, 22);
            label1.Name = "label1";
            label1.Size = new Size(165, 46);
            label1.TabIndex = 0;
            label1.Text = "Ana Form";
            // 
            // btnSiniflar
            // 
            btnSiniflar.BackColor = Color.FromArgb(255, 128, 128);
            btnSiniflar.Location = new Point(24, 12);
            btnSiniflar.Name = "btnSiniflar";
            btnSiniflar.Size = new Size(94, 39);
            btnSiniflar.TabIndex = 1;
            btnSiniflar.Text = "Sınıflar";
            btnSiniflar.UseVisualStyleBackColor = false;
            btnSiniflar.Click += btnSiniflar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colAd, colSoyad, colNumara });
            dataGridView1.Location = new Point(24, 110);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(579, 188);
            dataGridView1.TabIndex = 2;
            // 
            // colAd
            // 
            colAd.DataPropertyName = "Ad";
            colAd.HeaderText = "Ad";
            colAd.MinimumWidth = 6;
            colAd.Name = "colAd";
            colAd.Width = 125;
            // 
            // colSoyad
            // 
            colSoyad.DataPropertyName = "Soyad";
            colSoyad.HeaderText = "Soyad";
            colSoyad.MinimumWidth = 6;
            colSoyad.Name = "colSoyad";
            colSoyad.Width = 125;
            // 
            // colNumara
            // 
            colNumara.DataPropertyName = "Numara";
            colNumara.HeaderText = "Okul No";
            colNumara.MinimumWidth = 6;
            colNumara.Name = "colNumara";
            colNumara.Width = 125;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(462, 71);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(120, 33);
            btnKaydet.TabIndex = 3;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnKaydet);
            Controls.Add(dataGridView1);
            Controls.Add(btnSiniflar);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnSiniflar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colAd;
        private DataGridViewTextBoxColumn colSoyad;
        private DataGridViewTextBoxColumn colNumara;
        private Button btnKaydet;
    }
}
