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
                AccesLevel = AccesLevel.Invite
            },
            new Route()
            {
                Component = new Admin.AdminPanel(),
                Name = "admin",
                AccesLevel = AccesLevel.Admin
            },
            new Route()
            {
                Component = new Management(),
                Name = "management",
                AccesLevel = AccesLevel.User
            },

            // Error 404 
            //new Route()
            //{
            //    Component = new custom404Form(),
            //    Name = "404", // The name 404 is reserved for correct management of errors in router
            //},
        };
        public enum AccesLevel
        {
            Admin = 0,
            User = 1,
            Invite = 2
        }
    }
}
