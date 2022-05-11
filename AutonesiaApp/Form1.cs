namespace AutonesiaApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private Form Form1;
        private Form Form2;
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //this is a placeholder where the login button is used to switch to the DashboardForm
            if (Form2 == null)
                Form2 = new DashboardForm();

            Hide();
            Form2.Show();
        }
    }
}