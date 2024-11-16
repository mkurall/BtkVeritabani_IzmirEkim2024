using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BtkTodo
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();

            lblPreview.Text = DateTime.Now.ToString("yyyy\nMMMM");


            RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\BtkTodoApp");

            object keyValue = key.GetValue("Renk");

            if (keyValue != null)
            {
                lblPreview.BackColor = Color.FromArgb((int)(((int)keyValue) & 0xFFFFFFFF));
            }
            else
            {
                lblPreview.BackColor = Color.Tomato;
            }

            RegistryKey regRunAtStartup = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            object runAtStartupVal = regRunAtStartup.GetValue("BtkTodoApp");
            
            if(runAtStartupVal != null && runAtStartupVal.Equals(Application.ExecutablePath))
            {
                chkRunAtStartup.Checked = true;
            }
            else
            {
                chkRunAtStartup.Checked= false;
            }

            regRunAtStartup.Close();

            key.Close();

        }

        private void lblPreview_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = lblPreview.BackColor;

            if (DialogResult.OK == colorDialog1.ShowDialog())
            {
                lblPreview.BackColor = colorDialog1.Color;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

            RegistryKey regSoftware = Registry.CurrentUser.OpenSubKey("Software", true);

            RegistryKey regApp = regSoftware.CreateSubKey("BtkTodoApp");

            regApp.SetValue("Renk", lblPreview.BackColor.ToArgb(), RegistryValueKind.DWord);

            regApp.Close();

            RegistryKey regRunAtStartup  = regSoftware.OpenSubKey("Microsoft\\Windows\\CurrentVersion\\Run", true);


            if(chkRunAtStartup.Checked)
            {
                regRunAtStartup.SetValue("BtkTodoApp",Application.ExecutablePath);
            }
            else
            {
              if(regRunAtStartup.GetValue("BtkTodoApp")!=null)
                regRunAtStartup.DeleteValue("BtkTodoApp");
            }

            regRunAtStartup.Close();
            regSoftware.Close();
            DialogResult = DialogResult.OK;
        }
    }
}
