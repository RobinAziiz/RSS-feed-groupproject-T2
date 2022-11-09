using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Exceptions
{
    public class BrokenFeedException : Exception
    {
        public BrokenFeedException() : base("Provide a working URL.") { }

        public BrokenFeedException(string message) : base(message) { }

        public BrokenFeedException(string message, Exception inner) : base(message, inner) { }
    }
}
