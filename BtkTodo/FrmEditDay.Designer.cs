namespace BtkTodo
{
    partial class FrmEditDay
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
            btnClose = new Button();
            lblDay = new Label();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            colInfo = new DataGridViewTextBoxColumn();
            colColor = new DataGridViewComboBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.OrangeRed;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(155, 20);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(184, 59);
            btnClose.TabIndex = 0;
            btnClose.Text = "Tamam";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lblDay
            // 
            lblDay.BackColor = Color.Salmon;
            lblDay.Dock = DockStyle.Top;
            lblDay.Font = new Font("Segoe UI", 16F);
            lblDay.ForeColor = Color.White;
            lblDay.Location = new Point(0, 0);
            lblDay.Name = "lblDay";
            lblDay.Size = new Size(499, 62);
            lblDay.TabIndex = 1;
            lblDay.Text = "label1";
            lblDay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 359);
            panel1.Name = "panel1";
            panel1.Size = new Size(499, 91);
            panel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colInfo, colColor });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 62);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(499, 297);
            dataGridView1.TabIndex = 3;
            // 
            // colInfo
            // 
            colInfo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colInfo.DataPropertyName = "Info";
            colInfo.HeaderText = "Bilgi";
            colInfo.MinimumWidth = 6;
            colInfo.Name = "colInfo";
            // 
            // colColor
            // 
            colColor.DataPropertyName = "ColorIndex";
            colColor.HeaderText = "Renk";
            colColor.MinimumWidth = 6;
            colColor.Name = "colColor";
            colColor.Width = 125;
            // 
            // FrmEditDay
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 450);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(lblDay);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmEditDay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gün Düzenle";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnClose;
        private Label lblDay;
        private Panel panel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colInfo;
        private DataGridViewComboBoxColumn colColor;
    }
}