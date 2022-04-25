using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsRouter.Router
{
    public class Router
    {
        public List<Route> Routes { get; }
        
        public Router(List<Route> routes) 
        {
            Routes = routes;
        }


    }
}
