
namespace WinFormsRouteExemple
{
    partial class ApplicationBase
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.navigationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.managementToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.managementToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.@__NavigationHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.@__BaseContainer = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.navigationToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.modalToolStripMenuItem,
            this.@__NavigationHistory});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // navigationToolStripMenuItem
            // 
            this.navigationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.managementToolStripMenuItem,
            this.loginToolStripMenuItem});
            this.navigationToolStripMenuItem.Name = "navigationToolStripMenuItem";
            this.navigationToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.navigationToolStripMenuItem.Text = "Navigation";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usersToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // managementToolStripMenuItem
            // 
            this.managementToolStripMenuItem.Name = "managementToolStripMenuItem";
            this.managementToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.managementToolStripMenuItem.Text = "Management";
            this.managementToolStripMenuItem.Click += new System.EventHandler(this.managementToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem1,
            this.managementToolStripMenuItem1,
            this.loginToolStripMenuItem1});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // adminToolStripMenuItem1
            // 
            this.adminToolStripMenuItem1.Name = "adminToolStripMenuItem1";
            this.adminToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            this.adminToolStripMenuItem1.Text = "Admin";
            this.adminToolStripMenuItem1.Click += new System.EventHandler(this.adminToolStripMenuItem1_Click);
            // 
            // managementToolStripMenuItem1
            // 
            this.managementToolStripMenuItem1.Name = "managementToolStripMenuItem1";
            this.managementToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            this.managementToolStripMenuItem1.Text = "Management";
            this.managementToolStripMenuItem1.Click += new System.EventHandler(this.managementToolStripMenuItem1_Click);
            // 
            // loginToolStripMenuItem1
            // 
            this.loginToolStripMenuItem1.Name = "loginToolStripMenuItem1";
            this.loginToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            this.loginToolStripMenuItem1.Text = "Login";
            this.loginToolStripMenuItem1.Click += new System.EventHandler(this.loginToolStripMenuItem1_Click);
            // 
            // modalToolStripMenuItem
            // 
            this.modalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem2,
            this.managementToolStripMenuItem2,
            this.loginToolStripMenuItem2});
            this.modalToolStripMenuItem.Name = "modalToolStripMenuItem";
            this.modalToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.modalToolStripMenuItem.Text = "Modal";
            // 
            // adminToolStripMenuItem2
            // 
            this.adminToolStripMenuItem2.Name = "adminToolStripMenuItem2";
            this.adminToolStripMenuItem2.Size = new System.Drawing.Size(145, 22);
            this.adminToolStripMenuItem2.Text = "Admin";
            this.adminToolStripMenuItem2.Click += new System.EventHandler(this.adminToolStripMenuItem2_Click);
            // 
            // managementToolStripMenuItem2
            // 
            this.managementToolStripMenuItem2.Name = "managementToolStripMenuItem2";
            this.managementToolStripMenuItem2.Size = new System.Drawing.Size(145, 22);
            this.managementToolStripMenuItem2.Text = "Management";
            this.managementToolStripMenuItem2.Click += new System.EventHandler(this.managementToolStripMenuItem2_Click);
            // 
            // loginToolStripMenuItem2
            // 
            this.loginToolStripMenuItem2.Name = "loginToolStripMenuItem2";
            this.loginToolStripMenuItem2.Size = new System.Drawing.Size(145, 22);
            this.loginToolStripMenuItem2.Text = "Login";
            this.loginToolStripMenuItem2.Click += new System.EventHandler(this.loginToolStripMenuItem2_Click);
            // 
            // __NavigationHistory
            // 
            this.@__NavigationHistory.Name = "__NavigationHistory";
            this.@__NavigationHistory.Size = new System.Drawing.Size(57, 20);
            this.@__NavigationHistory.Text = "History";
            // 
            // __BaseContainer
            // 
            this.@__BaseContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.@__BaseContainer.Location = new System.Drawing.Point(0, 24);
            this.@__BaseContainer.Name = "__BaseContainer";
            this.@__BaseContainer.Size = new System.Drawing.Size(800, 426);
            this.@__BaseContainer.TabIndex = 1;
            // 
            // ApplicationBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.@__BaseContainer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ApplicationBase";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ApplicationBase_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem navigationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.Panel __BaseContainer;
        private System.Windows.Forms.ToolStripMenuItem __NavigationHistory;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem managementToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem managementToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem2;
    }
}

