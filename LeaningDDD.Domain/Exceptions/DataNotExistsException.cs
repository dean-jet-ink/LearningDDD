using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeaningDDD.Domain.Exceptions
{
    public sealed class DataNotExistsException: ExceptionBase
    {
        public DataNotExistsException()
            : base("データがありません") { }

        public override ExceptionType Type => ExceptionType.Info;
    }
}
