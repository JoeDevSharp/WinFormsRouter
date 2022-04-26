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
            },
            new Route()
            {
                Component = new Admin.AdminPanel(),
                Name = "admin",
            },
            new Route()
            {
                Component = new Management(),
                Name = "management",
            },
            // Error 404 
            //new Route()
            //{
            //    Component = new WinFormsRouter.ErrorApplicationContainer._404(),
            //    Name = "404", // The name 404 is reserved for correct management of errors in router
            //},
        };
    }
}
