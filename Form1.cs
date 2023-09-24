namespace MineSweeper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tenSecTimer_Click(object sender, EventArgs e)
        {
            var tenSecForm = new TenSecTimer();
            tenSecForm.Show();
        }
    }
}