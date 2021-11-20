using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_5.Exeptions
{
    class TopUpEx : Exception
    {
        public float Top { get; set; }
        public TopUpEx(string message, float TopUp) : base(message)
        {
            this.Top = TopUp;
        }
    }
}
