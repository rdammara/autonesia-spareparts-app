using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace AutonesiaApp
{
    public partial class LoginForm : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader dr;

        Connections Konn = new Connections();
        public LoginForm()
        {
            InitializeComponent();
        }
        private Form Form1;
        private Form Form2;
        private void buttonLogin_Click(object sender, EventArgs e)
        {
         

            SqlDataReader reader = null;
            SqlConnection conn = Konn.GetConn();
            {
                conn.Open();
                cmd = new SqlCommand("select * from Salesman where SalesmanUsername = '" + textBox1.Text +"' and SalesmanPassword = '" + textBox2.Text + "'", conn);
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    Form2 dashboard = new Form2();
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Info yang anda masukkan salah!");
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }
    }
}