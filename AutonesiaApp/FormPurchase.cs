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
    public partial class FormPurchase : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader dr;
        private DataTable dt;

        Connections Konn = new Connections();
        public FormPurchase()
        {
            InitializeComponent();
        }

        void tampilData()
        {
            SqlConnection conn = Konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT * FROM PurchaseOrder", conn);
                ds = new DataSet();
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "PurchaseOrder");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "PurchaseOrder";
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

        void tampilOrderType()
        {
            SqlConnection conn = Konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT OrderType FROM PurchaseOrder", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("OrderType", typeof(string));
                dt.Load(dr);
                comboBox1.ValueMember = "OrderType";
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

        void tampilSupplierCode()
        {
            SqlConnection conn = Konn.GetConn();
            try
            {
                conn.Open();
                cmd = new SqlCommand("SELECT SupplierCode FROM Supplier", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("SupplierCode", typeof(string));
                dt.Load(dr);
                comboBox1.ValueMember = "SupplierCode";
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

        private void FormPurchase_Load(object sender, EventArgs e)
        {
            tampilData();
            tampilOrderType();
            tampilSupplierCode();
        }
    }

   
}
