namespace EfCoreModelFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSiniflar_Click(object sender, EventArgs e)
        {
            FrmSiniflar form = new FrmSiniflar();
            form.ShowDialog();
        }
    }
}
