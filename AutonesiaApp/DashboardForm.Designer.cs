namespace AutonesiaApp
{
    partial class DashboardForm
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
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelDropDown = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.inventoryButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            this.panelDropDown.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panelDropDown);
            this.flowLayoutPanel1.Controls.Add(this.comboBox1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 1);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(212, 590);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panelDropDown
            // 
            this.panelDropDown.Controls.Add(this.button3);
            this.panelDropDown.Controls.Add(this.button2);
            this.panelDropDown.Controls.Add(this.inventoryButton);
            this.panelDropDown.Location = new System.Drawing.Point(3, 3);
            this.panelDropDown.MaximumSize = new System.Drawing.Size(203, 161);
            this.panelDropDown.MinimumSize = new System.Drawing.Size(203, 71);
            this.panelDropDown.Name = "panelDropDown";
            this.panelDropDown.Size = new System.Drawing.Size(203, 71);
            this.panelDropDown.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(3, 118);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(197, 37);
            this.button3.TabIndex = 3;
            this.button3.Text = "Check Inventory";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(3, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "Purchase From Vendor";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // inventoryButton
            // 
            this.inventoryButton.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.inventoryButton.Image = global::AutonesiaApp.Properties.Resources.icons8_expand_arrow_24;
            this.inventoryButton.Location = new System.Drawing.Point(3, 3);
            this.inventoryButton.Name = "inventoryButton";
            this.inventoryButton.Size = new System.Drawing.Size(197, 66);
            this.inventoryButton.TabIndex = 1;
            this.inventoryButton.Text = "Inventory";
            this.inventoryButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.inventoryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.inventoryButton.UseVisualStyleBackColor = true;
            this.inventoryButton.Click += new System.EventHandler(this.inventoryButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 80);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 23);
            this.comboBox1.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 592);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panelDropDown.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panelDropDown;
        private Button button3;
        private Button button2;
        private Button inventoryButton;
        private System.Windows.Forms.Timer timer1;
        private ComboBox comboBox1;
    }
}