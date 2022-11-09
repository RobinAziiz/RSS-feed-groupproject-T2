using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Exceptions
{
    public class SelectedItemExistsException : Exception
    {
        public SelectedItemExistsException() : base("No object is selected") { }

        public SelectedItemExistsException(string message) : base(message) { }

        public SelectedItemExistsException(string message, Exception inner) : base(message, inner) { }




    }
}
