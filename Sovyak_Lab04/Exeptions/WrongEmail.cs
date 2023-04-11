using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sovyak_Lab04.Exeptions
{
    internal class WrongEmail : Exception
    {
        public WrongEmail(string message) : base(message)
        {
        }
    }
}
