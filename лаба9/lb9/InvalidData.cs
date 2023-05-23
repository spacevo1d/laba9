using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb9
{
    internal class InvalidData : Exception
    {
        public InvalidData(string masge) : base(masge)
        {

        }
    }
}
