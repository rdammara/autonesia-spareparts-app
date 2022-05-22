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
    public partial class FormLogin : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader dr;

        Connections Konn = new Connections();
        public FormLogin()
        {
            InitializeComponent();
        }
        private Form Form1;
        private Form FormDashboard;
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
                    Class1.uname = textBox1.Text;
                    FormDashboard dashboard = new FormDashboard();
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