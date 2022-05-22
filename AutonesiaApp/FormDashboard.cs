using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutonesiaApp
{
    public partial class FormDashboard : Form
    {
        
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void createASalesQuoteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var salesForm = new FormSalesInvoice();
            salesForm.Show();
        }

        private void addNewCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var customerForm = new FormCustomer();
            customerForm.Show();
        }

        private void checkInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var inventoryForm = new FormInventory();
            inventoryForm.Show();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            label2.Text = Class1.uname; 
        }

        private void purchaseFromVendorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var purchaseForm = new FormPurchase();
            purchaseForm.Show();
        }
    }
}
