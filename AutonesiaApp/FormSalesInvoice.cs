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
//using AutonesiaApp;

namespace AutonesiaApp
{
    public partial class FormSalesInvoice : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader dr;
        private DataTable dt;

        Connections Konn = new Connections();
        public FormSalesInvoice()
        {
            InitializeComponent();
        }

        void tampilData()
        {
            SqlConnection conn = Konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM Invoice", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "Invoice");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Invoice";
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

        void tampilSalesmanCode()
        {
            SqlConnection conn = Konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT SalesmanCode FROM Salesman", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("SalesmanCode", typeof(string));
                dt.Load(dr);
                comboBox1.ValueMember = "SalesmanCode";
                comboBox1.DataSource = dt;
                
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

        void tampilCustomerCode()
        {
            SqlConnection conn = Konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT CustCode FROM Customer", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("CustCode", typeof(string));
                dt.Load(dr);
                comboBox2.ValueMember = "CustCode";
                comboBox2.DataSource = dt;

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
            tampilSalesmanCode();
            tampilCustomerCode();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || dateTimePicker1.Text.Trim() == "" ||  textBox4.Text.Trim() == "" || textBox5.Text.Trim() == "" ||  textBox7.Text.Trim() == "")
            {
                MessageBox.Show("Data Yang di Masukan Belum Lengkap!");
            }
            else
            {
                SqlConnection conn = Konn.GetConn();
                try
                {
                    cmd = new SqlCommand("INSERT INTO Invoice VALUES ('" + textBox1.Text + "', '" + this.dateTimePicker1.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "', '" + textBox7.Text + "')", conn);
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

                try
                {
                    DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                    textBox1.Text = row.Cells["InvoiceNo"].Value.ToString();
                    dateTimePicker1.Text = row.Cells["InvoiceDate"].Value.ToString();
                    
                    textBox4.Text = row.Cells["ItemCode"].Value.ToString();
                    textBox5.Text = row.Cells["Qty"].Value.ToString();
                    
                    textBox7.Text = row.Cells["PickingListNumber"].Value.ToString();
                }
                catch (Exception X)
                {
                    MessageBox.Show(X.ToString());
                }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || dateTimePicker1.Text.Trim() == "" ||  textBox4.Text.Trim() == "" || textBox5.Text.Trim() == "" ||  textBox7.Text.Trim() == "")
            {
                MessageBox.Show("Data Yang di Masukan Belum Lengkap!");
            }
            else
            {
                SqlConnection conn = Konn.GetConn();
                try
                {
                    cmd = new SqlCommand("UPDATE Invoice SET InvoiceDate = '" + this.dateTimePicker1.Text + "', ItemCode ='" + textBox4.Text + "', Qty ='" + textBox5.Text + "', PickingListNumber ='" + textBox7.Text + "' WHERE InvoiceNo = '" + textBox1.Text + "'", conn);
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
                    cmd = new SqlCommand("DELETE Invoice WHERE InvoiceNo = '" + textBox1.Text + "'", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Delete Data Berhasil");
                    tampilData();

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormSalesPrint frm2 = new FormSalesPrint();
            frm2.invoice = textBox1.Text;
            frm2.date = dateTimePicker1.Text;
            frm2.customer = comboBox1.Text;
            frm2.item = textBox4.Text;
            frm2.qty = textBox5.Text;
            frm2.salesman = comboBox2.Text;
            frm2.pickinglist = textBox7.Text;
            frm2.ShowDialog();
        }
    }
    }
