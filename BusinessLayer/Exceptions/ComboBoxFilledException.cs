using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Exceptions
{
    public class ComboBoxFilledException : Exception
    {
        public ComboBoxFilledException() : base("Please select an object in the drop-down menu."){ }

        public ComboBoxFilledException(string message) : base(message) { }

        public ComboBoxFilledException(string message, Exception inner) : base(message, inner) { }
    }
}
