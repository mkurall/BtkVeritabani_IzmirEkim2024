namespace BtkTodo
{
    partial class FrmSettings
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            btnOk = new Button();
            panel3 = new Panel();
            colorDialog1 = new ColorDialog();
            label2 = new Label();
            lblPreview = new Label();
            chkRunAtStartup = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(496, 88);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = Properties.Resources.settings128;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            label1.Location = new Point(100, 12);
            label1.Name = "label1";
            label1.Size = new Size(185, 62);
            label1.TabIndex = 0;
            label1.Text = "Ayarlar";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(btnOk);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 282);
            panel2.Name = "panel2";
            panel2.Size = new Size(496, 81);
            panel2.TabIndex = 1;
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.SkyBlue;
            btnOk.Font = new Font("Segoe UI", 12F);
            btnOk.Location = new Point(164, 16);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(155, 53);
            btnOk.TabIndex = 0;
            btnOk.Text = "Tamam";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Orange;
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 88);
            panel3.Name = "panel3";
            panel3.Size = new Size(496, 4);
            panel3.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 127);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 4;
            label2.Text = "Renk";
            // 
            // lblPreview
            // 
            lblPreview.BackColor = Color.FromArgb(255, 128, 128);
            lblPreview.Font = new Font("Segoe UI", 22F);
            lblPreview.ForeColor = Color.White;
            lblPreview.Location = new Point(100, 95);
            lblPreview.Name = "lblPreview";
            lblPreview.Size = new Size(219, 105);
            lblPreview.TabIndex = 5;
            lblPreview.Text = "Renk";
            lblPreview.TextAlign = ContentAlignment.MiddleCenter;
            lblPreview.Click += lblPreview_Click;
            // 
            // chkRunAtStartup
            // 
            chkRunAtStartup.AutoSize = true;
            chkRunAtStartup.Font = new Font("Segoe UI", 12F);
            chkRunAtStartup.Location = new Point(33, 224);
            chkRunAtStartup.Name = "chkRunAtStartup";
            chkRunAtStartup.Size = new Size(293, 32);
            chkRunAtStartup.TabIndex = 6;
            chkRunAtStartup.Text = "Uygulama başlangıçta çalışsın";
            chkRunAtStartup.UseVisualStyleBackColor = true;
            // 
            // FrmSettings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 363);
            Controls.Add(chkRunAtStartup);
            Controls.Add(lblPreview);
            Controls.Add(label2);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmSettings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ayarlar";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private Button btnOk;
        private Panel panel3;
        private ColorDialog colorDialog1;
        private Label label2;
        private Label lblPreview;
        private CheckBox chkRunAtStartup;
    }
}