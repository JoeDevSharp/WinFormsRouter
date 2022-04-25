using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsRouter;
using WinFormsRouter.Router;

namespace WinFormsRouteExemple
{
    public partial class Form1 : Form
    {
        private AppContainer AppContainer { get; set; }
        public Form1()
        {
            InitializeComponent();
            AppContainer = new AppContainer(Routes.routes, this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppContainer.Navigate("admin");
        }

        private void managementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppContainer.Navigate("management");
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppContainer.Navigate("login");
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppContainer.Navigate("admin.users");
        }
    }
}
