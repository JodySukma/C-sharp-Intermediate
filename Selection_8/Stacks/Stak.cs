using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_8.Stacks
{
    public class Stak
    {
        private readonly List<object> _list = new List<object>();

        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("You can not add a null object to the stack.");

            _list.Add(obj);
           
        }

        public object Pop()
        {
            if(_list.Count == 0)
                throw new InvalidOperationException("There are no element in the stack yet.");

            var index = _list.Count - 1;
            var toReturn = _list[_list.Count - 1];

            _list.RemoveAt(_list.Count - 1);

            return (toReturn) ;
        }
    }
}
