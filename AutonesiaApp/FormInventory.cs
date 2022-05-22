using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AutonesiaApp
{
    public partial class FormInventory : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;

        Connections Konn = new Connections();
        public FormInventory()
        {
            InitializeComponent();
        }

        void tampilData()
        {
            SqlConnection conn = Konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM Item", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "Item");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Item";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception G)
            {
                MessageBox.Show(G.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        void CariData()
        {
            SqlConnection conn = Konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM Item where ItemCode like '%" + textBox7.Text + "%' or ItemName like '%" + textBox7.Text + "%' or UnitPrice like '%" + textBox7.Text + "%' or UOM like '%" + textBox7.Text + "%' or Availability like '%" + textBox7.Text + "%' ", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "Item");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Item";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception G)
            {
                MessageBox.Show(G.ToString());
            }
            finally
            {
                conn.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tampilData();
        }

        void Bersihkan()
        {
            textBox1.Text = "";
            textBox3.Text = "";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || textBox3.Text.Trim() == "" || textBox4.Text.Trim() == "" || textBox5.Text.Trim() == "" || textBox6.Text.Trim() == "" || textBox7.Text.Trim() == "")
            {
                MessageBox.Show("Data Yang di Masukan Belum Lengkap!");
            }
            else
            {
                SqlConnection conn = Konn.GetConn();
                try
                {
                    cmd = new SqlCommand("INSERT INTO Invoice VALUES ('" + textBox1.Text + "', '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "', '" + textBox6.Text + "','" + textBox7.Text + "')", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Telah Berhasil Dibuat");
                    tampilData();
                }
                catch (Exception X)
                {
                    MessageBox.Show(X.ToString());
                }

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["Itemcode"].Value.ToString();
                textBox3.Text = row.Cells["ItemName"].Value.ToString();
                textBox4.Text = row.Cells["UnitPrice"].Value.ToString();
                textBox5.Text = row.Cells["UOM"].Value.ToString();
                textBox6.Text = row.Cells["Availability"].Value.ToString();
            }
            catch (Exception X)
            {
                MessageBox.Show(X.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || textBox3.Text.Trim() == "" || textBox4.Text.Trim() == "" || textBox5.Text.Trim() == "" || textBox6.Text.Trim() == "" || textBox7.Text.Trim() == "")
            {
                MessageBox.Show("Data Yang di Masukan Belum Lengkap!");
            }
            else
            {
                SqlConnection conn = Konn.GetConn();
                try
                {
                    cmd = new SqlCommand("UPDATE Invoice SET ItemName ='" + textBox3.Text + "', UnitPrice ='" + textBox4.Text + "',  UOM ='" + textBox5.Text + "', Availability ='" + textBox6.Text + "' WHERE ItemCode = '" + textBox1.Text + "'", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update Data Telah Berhasil!");
                    tampilData();

                }
                catch (Exception X)
                {
                    MessageBox.Show(X.ToString());
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Yakin akan menghapus data " + textBox1.Text + " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SqlConnection conn = Konn.GetConn();
                {
                    cmd = new SqlCommand("DELETE Invoice WHERE ItemCode = '" + textBox1.Text + "'", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Delete Data Berhasil");
                    tampilData();

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bersihkan();
            tampilData();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CariData();
        }
    }
}