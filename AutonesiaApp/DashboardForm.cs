using AutonesiaApp.Properties;
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
    public partial class DashboardForm : Form
    {
        private bool isCollapsed;
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            inventoryButton.Image = Resources.icons8_collapse_arrow_24;
            if (isCollapsed)
            {
                panelDropDown.Height += 10;
                if (panelDropDown.Size == panelDropDown.MaximumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }
            else
            {
                inventoryButton.Image = Resources.icons8_expand_arrow_24;
                panelDropDown.Height -= 10;
                if (panelDropDown.Size == panelDropDown.MinimumSize)
                {
                    timer1.Stop();
                    isCollapsed = true;
                }
            }

        }

        private void inventoryButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
