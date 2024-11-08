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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 456);
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
    }
}
