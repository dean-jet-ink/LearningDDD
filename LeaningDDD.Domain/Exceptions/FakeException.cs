using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaningDDD.Domain.Exceptions
{
    public sealed class FakeException: ExceptionBase
    {
        public FakeException(string message, Exception ex)
            :base(message, ex) { }

        public override ExceptionType Type => ExceptionType.Error;
    }
}
