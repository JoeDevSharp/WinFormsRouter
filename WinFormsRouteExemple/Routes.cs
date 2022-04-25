using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsRouter.Router;

namespace WinFormsRouteExemple
{
    public static class Routes
    {
        public static Route[] routes { get; set; } = new Route[]
        {
            new Route()
            {
                Component = new Login(),
                Name = "login",
                DefaultRoute = true,
            },
            new Route()
            {
                Component = new Form2(),
                Name = "admin",
            },
            new Route()
            {
                Component = new Form3(),
                Name = "management",
            },
            new Route()
            {
                Component = new WinFormsRouter.ErrorApplicationContainer._404(),
                Name = "404",
            },
        };
    }
}
