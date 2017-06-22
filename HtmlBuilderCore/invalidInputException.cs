using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlBuilderCore
{
    public class invalidInputException : Exception
    {
        public invalidInputException(string message)
           : base(message)
        {
        }
    }
}
