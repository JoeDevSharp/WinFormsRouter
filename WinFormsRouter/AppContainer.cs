using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsRouter.Router;

namespace WinFormsRouter
{
    public partial class AppContainer : Form
    {
        private Route[] Routes { get; set; }
        private Form Parant { get; set; }
        private Form Component { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="routes"></param>
        /// <param name="parant"></param>
        /// <param name="withControls"></param>
        public AppContainer(Route[] routes, Form parant, bool withControls = false)
        {
            InitializeComponent();
            
            Parant = parant;
            Routes = routes;
            
            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
            this.FormBorderStyle = !withControls ? FormBorderStyle.None : FormBorderStyle.Sizable;

            // Router default route
            var dr = routes.SingleOrDefault(r => r.DefaultRoute == true);
            if (dr != null)
                Navigate(dr.Name);

            Parant.Controls.Add(this);
            this.Show();
        }

        internal Route getRouteByName (string name, Route[] routes = null)
        {
            var route = routes.SingleOrDefault(r => {
                return r.Name == name;
            });

            var user404 = routes.SingleOrDefault(r => r.Name == "404");
            return route == null 
                ? user404 == null 
                ? new Route { Name = "404", Component = new ErrorApplicationContainer._404() }
                : user404 
                : route;
        }
        
        /// <summary>
        /// Navigate to new route
        /// </summary>
        /// <param name="name"></param>
        public void Navigate(string name)
        {
            var route = getRouteByName(name, Routes);
            
            if(route == null)
            {
                MessageBox.Show("This route does not exist", "Router Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                Component = route.Component;
                Component.TopLevel = false;
                Component.FormBorderStyle = FormBorderStyle.None;
                Component.Size = Parant.Size;
                Component.Dock = DockStyle.Fill;

                this.Controls.Clear();
                this.Controls.Add((Form)Component);
                Component.Show();
            }
        }

        /// <summary>
        /// Shows in a new window a new instance of the component of the current route
        /// </summary>
        /// <param name="name"></param>
        public void Open(string name)
        {
            var route = getRouteByName(name, Routes);
            var _component = route.Component.GetType();
            Form instance = (Form)Activator.CreateInstance(_component);
            instance.Show();
        }

        /// <summary>
        /// Shows in a modal dialog a new instance of the component of the current route
        /// </summary>
        /// <param name="name"></param>
        public void OpenModal(string name)
        {
            var route = getRouteByName(name, Routes);
            var _component = route.Component.GetType();
            Form instance = (Form)Activator.CreateInstance(_component);
            instance.ShowDialog();
        }

    }
}
