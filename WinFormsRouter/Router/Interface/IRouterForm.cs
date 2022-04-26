using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsRouter.Router
{
    public interface IRouterForm
    {
        Params Params { get; set; }
    }
}
