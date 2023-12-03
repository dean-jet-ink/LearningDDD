using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaningDDD.Domain.Exceptions
{
    public abstract class ExceptionBase : Exception
    {
        public ExceptionBase(string message)
            : base(message) { }

        public ExceptionBase(string message, Exception ex)
            : base(message, ex) { }

        public abstract ExceptionType Type { get; }

        public enum ExceptionType
        {
            Info,
            Warning,
            Error,
        }
    }
}
