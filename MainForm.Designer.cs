namespace ProgrammingInCSharp10
{
    partial class MainForm
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
            ToolStripMenuItem productManagmentToolStripMenuItem;
            menuStrip1 = new MenuStrip();
            productListToolStripMenuItem = new ToolStripMenuItem();
            customerManagmentToolStripMenuItem = new ToolStripMenuItem();
            customerListToolStripMenuItem = new ToolStripMenuItem();
            orderManagmentToolStripMenuItem = new ToolStripMenuItem();
            saveOrderToolStripMenuItem = new ToolStripMenuItem();
            logoPictureBox = new PictureBox();
            productManagmentToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { productManagmentToolStripMenuItem, customerManagmentToolStripMenuItem, orderManagmentToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // productManagmentToolStripMenuItem
            // 
            productManagmentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { productListToolStripMenuItem });
            productManagmentToolStripMenuItem.Name = "productManagmentToolStripMenuItem";
            productManagmentToolStripMenuItem.Size = new Size(129, 20);
            productManagmentToolStripMenuItem.Text = "Product Managment";
            productManagmentToolStripMenuItem.Click += productManagmentToolStripMenuItem_Click;
            // 
            // productListToolStripMenuItem
            // 
            productListToolStripMenuItem.Name = "productListToolStripMenuItem";
            productListToolStripMenuItem.Size = new Size(180, 22);
            productListToolStripMenuItem.Text = "Product List";
            productListToolStripMenuItem.Click += productListToolStripMenuItem_Click;
            // 
            // customerManagmentToolStripMenuItem
            // 
            customerManagmentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { customerListToolStripMenuItem });
            customerManagmentToolStripMenuItem.Name = "customerManagmentToolStripMenuItem";
            customerManagmentToolStripMenuItem.Size = new Size(139, 20);
            customerManagmentToolStripMenuItem.Text = "Customer Managment";
            // 
            // customerListToolStripMenuItem
            // 
            customerListToolStripMenuItem.Name = "customerListToolStripMenuItem";
            customerListToolStripMenuItem.Size = new Size(147, 22);
            customerListToolStripMenuItem.Text = "Customer List";
            customerListToolStripMenuItem.Click += customerListToolStripMenuItem_Click;
            // 
            // orderManagmentToolStripMenuItem
            // 
            orderManagmentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveOrderToolStripMenuItem });
            orderManagmentToolStripMenuItem.Name = "orderManagmentToolStripMenuItem";
            orderManagmentToolStripMenuItem.Size = new Size(117, 20);
            orderManagmentToolStripMenuItem.Text = "Order Managment";
            // 
            // saveOrderToolStripMenuItem
            // 
            saveOrderToolStripMenuItem.Name = "saveOrderToolStripMenuItem";
            saveOrderToolStripMenuItem.Size = new Size(131, 22);
            saveOrderToolStripMenuItem.Text = "Save Order";
            // 
            // logoPictureBox
            // 
            logoPictureBox.Location = new Point(249, 67);
            logoPictureBox.Name = "logoPictureBox";
            logoPictureBox.Size = new Size(300, 300);
            logoPictureBox.TabIndex = 1;
            logoPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(logoPictureBox);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "MainForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

       

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem productManagmentToolStripMenuItem;
        private ToolStripMenuItem productListToolStripMenuItem;
        private ToolStripMenuItem customerManagmentToolStripMenuItem;
        private ToolStripMenuItem customerListToolStripMenuItem;
        private PictureBox logoPictureBox;
        private ToolStripMenuItem orderManagmentToolStripMenuItem;
        private ToolStripMenuItem saveOrderToolStripMenuItem;
    }
}