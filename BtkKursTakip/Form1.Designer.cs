namespace BtkKursTakip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbKurslar = new ToolStripButton();
            tsbEgitmenler = new ToolStripButton();
            tsbKullanici = new ToolStripSplitButton();
            oturumuKapatToolStripMenuItem = new ToolStripMenuItem();
            toolStripButton2 = new ToolStripButton();
            toolStripButton3 = new ToolStripButton();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.FromArgb(255, 255, 192);
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripSeparator1, tsbKurslar, tsbEgitmenler, tsbKullanici, toolStripButton2, toolStripButton3 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(942, 39);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = Properties.Resources.save__1_;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(36, 36);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 39);
            // 
            // tsbKurslar
            // 
            tsbKurslar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbKurslar.Image = Properties.Resources.online_learning;
            tsbKurslar.ImageTransparentColor = Color.Magenta;
            tsbKurslar.Name = "tsbKurslar";
            tsbKurslar.Size = new Size(36, 36);
            tsbKurslar.Text = "toolStripButton2";
            tsbKurslar.Click += tsbKurslar_Click;
            // 
            // tsbEgitmenler
            // 
            tsbEgitmenler.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsbEgitmenler.Image = Properties.Resources.training;
            tsbEgitmenler.ImageTransparentColor = Color.Magenta;
            tsbEgitmenler.Name = "tsbEgitmenler";
            tsbEgitmenler.Size = new Size(36, 36);
            tsbEgitmenler.Text = "toolStripButton3";
            tsbEgitmenler.Click += tsbEgitmenler_Click;
            // 
            // tsbKullanici
            // 
            tsbKullanici.Alignment = ToolStripItemAlignment.Right;
            tsbKullanici.DropDownItems.AddRange(new ToolStripItem[] { oturumuKapatToolStripMenuItem });
            tsbKullanici.Image = Properties.Resources.user__3_;
            tsbKullanici.ImageTransparentColor = Color.Magenta;
            tsbKullanici.Name = "tsbKullanici";
            tsbKullanici.Size = new Size(143, 36);
            tsbKullanici.Text = "Kullanıcı Adı";
            // 
            // oturumuKapatToolStripMenuItem
            // 
            oturumuKapatToolStripMenuItem.Font = new Font("Segoe UI", 12F);
            oturumuKapatToolStripMenuItem.Name = "oturumuKapatToolStripMenuItem";
            oturumuKapatToolStripMenuItem.Size = new Size(230, 32);
            oturumuKapatToolStripMenuItem.Text = "Oturumu Kapat";
            oturumuKapatToolStripMenuItem.Click += oturumuKapatToolStripMenuItem_Click;
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(36, 36);
            toolStripButton2.Text = "toolStripButton2";
            toolStripButton2.Click += toolStripButton2_Click;
            // 
            // toolStripButton3
            // 
            toolStripButton3.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton3.Image = (Image)resources.GetObject("toolStripButton3.Image");
            toolStripButton3.ImageTransparentColor = Color.Magenta;
            toolStripButton3.Name = "toolStripButton3";
            toolStripButton3.Size = new Size(36, 36);
            toolStripButton3.Text = "toolStripButton3";
            toolStripButton3.Click += toolStripButton3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(942, 487);
            Controls.Add(toolStrip1);
            Name = "Form1";
            Text = "Form1";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsbKurslar;
        private ToolStripButton tsbEgitmenler;
        private ToolStripSplitButton tsbKullanici;
        private ToolStripMenuItem oturumuKapatToolStripMenuItem;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
    }
}
