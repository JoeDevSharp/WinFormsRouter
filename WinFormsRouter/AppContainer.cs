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
    public partial class AppContainer : RouterContainer
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="routes"></param>
        /// <param name="parant"></param>
        /// <param name="container"></param>
        /// <param name="withControls"></param>
        public AppContainer(Route[] routes, Form parant, Control container = null, bool withControls = false)
        {
            InitializeComponent();
            
            Parant = parant;
            Routes = routes;

            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
            this.FormBorderStyle = !withControls ? FormBorderStyle.None : FormBorderStyle.Sizable;

            if (container == null)
            {
                Parant.Controls.Add(this);
            }else
            {
                container.Controls.Add(this);
            } 
            this.Show();
        }
        
        /// <summary>
        /// Navigate to new route
        /// </summary>
        /// <param name="name"></param>
        public void Navigate(string name, Params _params = null)
        {
            var route = getRouteByName(name, Routes);
            
            if(route != (History.Count > 0 ? History.Last() : null))
            {
                Component = route.Component;
                Component.TopLevel = false;
                Component.FormBorderStyle = FormBorderStyle.None;
                Component.Size = Parant.Size;
                Component.Dock = DockStyle.Fill;

                this.Controls.Clear();
                this.Controls.Add((Form)Component);
                
                try
                {
                    ((IRouterForm)Component).Params = _params;
                } catch (Exception) { }

                Component.Show();
                History.Add(route);
                ((RouterFormContainer)this.Parant).HitoryChange(route);
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
