using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsRouter.Router
{
    public class Params
    {
        private List<Param> @params { get; set; } = new List<Param>();
        public void Add (string _key, object _value)
        {
            @params.Add(
                    new Param() { Key = _key, value = _value}
                );
        }
        public T value<T> (string _key)
        {
            return (T)@params.Find(p => p.Key == _key)?.value;
        }
    }

    public class Param
    {
        public string Key { get; set; }
        public object value { get; set; }
    }
}
