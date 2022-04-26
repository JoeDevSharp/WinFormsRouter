using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsRouter.Router
{
    public class RouterContainer : Form
    {
        protected Route[] Routes { get; set; }
        protected Form Parant { get; set; }
        protected Form Component { get; set; }
        public List<Route> History = new List<Route>();
        protected Route getRouteByName(string name, Route[] routes = null)
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
        
    }
}
