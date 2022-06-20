using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary.Exceptions
{
    public class InvalidUserException : Exception
    {
        public InvalidUserException(string message) : base(message)
        {
        }

        public InvalidUserException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public override string StackTrace
        {
            get
            {
                return base.StackTrace + " ";
            }
        }
    }
}
