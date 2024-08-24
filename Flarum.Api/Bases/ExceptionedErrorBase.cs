using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flarum.Api.Bases
{
    public class ExceptionedErrorBase : ErrorResultBase
    {
        public new Exception? InnerException { get; }

        public ExceptionedErrorBase(int errorCode, string? errorMessage = null, Exception? exception = null) : base(errorCode, errorMessage)
        {
            InnerException = exception;
        }
    }
}
