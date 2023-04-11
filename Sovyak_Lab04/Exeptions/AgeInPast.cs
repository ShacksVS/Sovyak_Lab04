using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sovyak_Lab04.Exeptions
{
    internal class AgeInPast : Exception
    {
        public AgeInPast(string message) : base(message)
        {
        }
    }
}
