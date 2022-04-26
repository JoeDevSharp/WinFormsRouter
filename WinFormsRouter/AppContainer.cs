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
        /// <param name="componentContainer"></param>
        /// <param name="inWindow"></param>
        public AppContainer(ValueType actualAccesLevel, Route[] routes, Form parant, Control componentContainer = null, bool inWindow = false)
        {
            InitializeComponent();
            
            Parant = parant;
            Routes = routes;
            ActualAccesLevel = actualAccesLevel;
            WithControls = inWindow;

            this.TopLevel = false;
            this.Dock = DockStyle.Fill;
            this.FormBorderStyle = FormBorderStyle.None;

            if (componentContainer == null)
            {
                Parant.Controls.Add(this);
            }else
            {
                componentContainer.Controls.Add(this);
            } 
            this.Show();
        }

        /// <summary>
        /// Navigate to new route
        /// </summary>
        /// <param name="name"></param>
        public bool Navigate(string name, Params _params = null)
        {
            var route = getRouteByName(name, Routes);
            route = this.AccessLevelVerification(route, Routes);

            if (route != (History.Count > 0 ? History.Last() : null))
            {
                Component = route.Component;
                Component.TopLevel = false;
                Component.FormBorderStyle = WithControls == true ? FormBorderStyle.Sizable : FormBorderStyle.None;
                Component.Dock = WithControls == true ? DockStyle.None : DockStyle.Fill;

                if(!WithControls)
                {
                    Component.Size = Parant.Size;
                    this.Controls.Clear();
                }
                
                this.Controls.Add((Form)Component);
                
                try
                {
                    ((IRouterForm)Component).Params = _params;
                } catch (Exception) { }

                Component.Show();

                if (!IsRouteError(route))
                {
                    History.Add(route);
                    ((RouterFormContainer)this.Parant).HitoryChange(route);
                }
                    
                return true;
            }
            return false;
        }

        /// <summary>
        /// Shows in a new window a new instance of the component of the current route
        /// </summary>
        /// <param name="name"></param>
        public void Open(string name, Params _params = null)
        {
            var route = getRouteByName(name, Routes);
            route = this.AccessLevelVerification(route, Routes);
            var _component = route.Component.GetType();
            Form instance = (Form)Activator.CreateInstance(_component);

            try
            {
                ((IRouterForm)instance).Params = _params;
            }
            catch (Exception) { }

            instance.Show();
            
        }

        /// <summary>
        /// Shows in a modal dialog a new instance of the component of the current route
        /// </summary>
        /// <param name="name"></param>
        public void OpenModal(string name, Params _params = null)
        {
            var route = getRouteByName(name, Routes);
            route = this.AccessLevelVerification(route, Routes);
            var _component = route.Component.GetType();
            Form instance = (Form)Activator.CreateInstance(_component);

            try
            {
                ((IRouterForm)instance).Params = _params;
            }
            catch (Exception) { }

            instance.ShowDialog();
            
        }

    }
}
