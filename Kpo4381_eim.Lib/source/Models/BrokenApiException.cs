using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4381.eim.Lib
{
    public class BrokenApiException : Exception
    {
        public BrokenApiException(string message="Api недоступен")
        : base(message)
        {
        }
    }
}
