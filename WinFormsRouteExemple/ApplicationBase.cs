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
    public partial class ApplicationBase : RouterFormContainer
    {
        public ApplicationBase()
        {
            InitializeComponent();
            AppContainer = new AppContainer(Routes.routes, this, __BaseContainer);
        }

        public override void HitoryChange (Route to)
        {
            var item = new ToolStripMenuItem();
            item.Text = to.Name;
            item.Click += (s, e) =>
            {
                AppContainer.Navigate(to.Name);
            };
             __NavigationHistory.DropDownItems.Add(item);
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

        private void adminToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AppContainer.Open("admin");
        }

        private void managementToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AppContainer.Open("management");
        }

        private void loginToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AppContainer.Open("login");
        }

        private void adminToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AppContainer.OpenModal("admin");
        }

        private void managementToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AppContainer.OpenModal("management");
        }

        private void loginToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AppContainer.OpenModal("login");
        }

        private void ApplicationBase_Load(object sender, EventArgs e)
        {
            var _params = new Params();
            _params.Add("user", "j.ramos@jm-ramos.com");
            _params.Add("pass", "ajdoajfewfm");
            AppContainer.Navigate("login", _params);
        }
    }
}
