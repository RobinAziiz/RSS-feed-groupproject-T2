using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Exceptions
{
    public class IsUniqueException : Exception
    {
        public IsUniqueException() : base("This object already exists") { }

        public IsUniqueException(string entityName) : base(entityName + " is not unique.") { }

        public IsUniqueException(string message, Exception inner) { }

        public IsUniqueException(string message, string entityName) : base(message) { }

        public IsUniqueException(string message, Exception inner, string entityName ) : base(message, inner){ }

    }
}
