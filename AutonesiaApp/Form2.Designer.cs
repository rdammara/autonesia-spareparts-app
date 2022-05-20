namespace AutonesiaApp
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.myHomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseFromVendorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkInventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.createASalesQuoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.createAReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardMenu,
            this.inventoryMenu,
            this.salesMenu,
            this.reportsMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardMenu
            // 
            this.dashboardMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myHomeToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.logOutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.dashboardMenu.Name = "dashboardMenu";
            this.dashboardMenu.Size = new System.Drawing.Size(76, 20);
            this.dashboardMenu.Text = "Dashboard";
            // 
            // myHomeToolStripMenuItem
            // 
            this.myHomeToolStripMenuItem.Name = "myHomeToolStripMenuItem";
            this.myHomeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.myHomeToolStripMenuItem.Text = "My Home";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // inventoryMenu
            // 
            this.inventoryMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseFromVendorToolStripMenuItem,
            this.checkInventoryToolStripMenuItem});
            this.inventoryMenu.Name = "inventoryMenu";
            this.inventoryMenu.Size = new System.Drawing.Size(69, 20);
            this.inventoryMenu.Text = "Inventory";
            // 
            // purchaseFromVendorToolStripMenuItem
            // 
            this.purchaseFromVendorToolStripMenuItem.Name = "purchaseFromVendorToolStripMenuItem";
            this.purchaseFromVendorToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.purchaseFromVendorToolStripMenuItem.Text = "Purchase from Vendor";
            // 
            // checkInventoryToolStripMenuItem
            // 
            this.checkInventoryToolStripMenuItem.Name = "checkInventoryToolStripMenuItem";
            this.checkInventoryToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.checkInventoryToolStripMenuItem.Text = "Check Inventory";
            // 
            // salesMenu
            // 
            this.salesMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createASalesQuoteToolStripMenuItem});
            this.salesMenu.Name = "salesMenu";
            this.salesMenu.Size = new System.Drawing.Size(45, 20);
            this.salesMenu.Text = "Sales";
            // 
            // createASalesQuoteToolStripMenuItem
            // 
            this.createASalesQuoteToolStripMenuItem.Name = "createASalesQuoteToolStripMenuItem";
            this.createASalesQuoteToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.createASalesQuoteToolStripMenuItem.Text = "Create a Sales Quote";
            // 
            // reportsMenu
            // 
            this.reportsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createAReportToolStripMenuItem});
            this.reportsMenu.Name = "reportsMenu";
            this.reportsMenu.Size = new System.Drawing.Size(59, 20);
            this.reportsMenu.Text = "Reports";
            // 
            // createAReportToolStripMenuItem
            // 
            this.createAReportToolStripMenuItem.Name = "createAReportToolStripMenuItem";
            this.createAReportToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.createAReportToolStripMenuItem.Text = "Create a Report";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem inventoryMenu;
        private ToolStripMenuItem purchaseFromVendorToolStripMenuItem;
        private ToolStripMenuItem checkInventoryToolStripMenuItem;
        private ToolStripMenuItem salesMenu;
        private ToolStripMenuItem createASalesQuoteToolStripMenuItem;
        private ToolStripMenuItem reportsMenu;
        private ToolStripMenuItem createAReportToolStripMenuItem;
        private ToolStripMenuItem dashboardMenu;
        private ToolStripMenuItem myHomeToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Label label1;
    }
}