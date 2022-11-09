using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Exceptions
{
    public class TextBoxIsNotFilledException : Exception
    {
        public TextBoxIsNotFilledException() : base ("The text box is empty.") { }

        public TextBoxIsNotFilledException(string message) : base(message)
        {
            
        }

        public TextBoxIsNotFilledException(string message, Exception inner): base(message, inner)
        {

        }

    }
}
