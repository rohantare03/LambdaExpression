using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    internal class LambdaCustomException : Exception
    {
        Exceptiontype type;
        public enum Exceptiontype
        {
            NO_SUCH_AGE, NO_SUCH_NAME
        }
        public LambdaCustomException(Exceptiontype type, string message) : base(message)
        {
            this.type = type;
        }
    }
}
