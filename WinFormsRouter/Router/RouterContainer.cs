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
        protected ValueType ActualAccesLevel { get; set; }

        protected bool InWindow { get; set; }
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
        protected Route AccessLevelVerification(Route route, Route[] routes)
        {
            var _custom403 = routes.SingleOrDefault(r => r.Name == "403");
            var _default403 = new Route { Name = "403", Component = new ErrorApplicationContainer._403() };

            if (route.AccesLevel == null)
                return route;

            return (int)ActualAccesLevel <= (int)route.AccesLevel == false 
                ? _custom403 == null 
                ? _default403 
                : _custom403 
                : route;
        }

        protected bool IsRouteError (Route route)
        {
            List<string> errors = new List<string>();
            errors.AddRange(new string[] {
                "404",
                "403"
            });
            return errors.Contains(route.Name);
        }
    }
}
