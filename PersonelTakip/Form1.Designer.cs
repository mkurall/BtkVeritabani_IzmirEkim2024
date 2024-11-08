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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(820, 456);
            Controls.Add(btnPersonelleriGetir);
            Controls.Add(lbPersoneller);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbPersoneller;
        private Button btnPersonelleriGetir;
    }
}
