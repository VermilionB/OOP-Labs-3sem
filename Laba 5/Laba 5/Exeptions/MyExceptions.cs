using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_5.Exeptions
{
    class SearchEx : Exception
    {
        public SearchEx(string message) : base(message)
        {

        }
    }

    class PowerEx : SearchEx
    {
        public PowerEx(string message) : base(message)
        {

        }
    }
}
