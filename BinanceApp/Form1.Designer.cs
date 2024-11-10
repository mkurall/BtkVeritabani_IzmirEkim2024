namespace BinanceApp
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
            lblFiyat = new Label();
            btnBaglan = new Button();
            SuspendLayout();
            // 
            // lblFiyat
            // 
            lblFiyat.AutoSize = true;
            lblFiyat.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblFiyat.Location = new Point(325, 41);
            lblFiyat.Name = "lblFiyat";
            lblFiyat.Size = new Size(137, 54);
            lblFiyat.TabIndex = 0;
            lblFiyat.Text = "label1";
            // 
            // btnBaglan
            // 
            btnBaglan.BackColor = Color.Goldenrod;
            btnBaglan.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnBaglan.Location = new Point(290, 188);
            btnBaglan.Name = "btnBaglan";
            btnBaglan.Size = new Size(208, 64);
            btnBaglan.TabIndex = 1;
            btnBaglan.Text = "Bağlan";
            btnBaglan.UseVisualStyleBackColor = false;
            btnBaglan.Click += btnBaglan_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBaglan);
            Controls.Add(lblFiyat);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFiyat;
        private Button btnBaglan;
    }
}
