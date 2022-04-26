using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsRouter.Router
{
    public class RouterFormContainer : Form
    {
        protected AppContainer AppContainer { get; set; }
        public virtual void HitoryChange (Route route) { }
    }
}
