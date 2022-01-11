using System;
using System.Collections.Generic;
using System.Text;

namespace Laba_9
{
    class Students
    {
        private string Name { get; set; }

        public Students(string name) => Name = name;

        public void GossipAboutRaise()
            => Console.WriteLine($"[{Name}] You heard?! Our director got a raise. About five hundred bucks!");

        public void GossipAboutFine()
            => Console.WriteLine($"[{Name}] You heard?! Our director got a fine. About three hundred bucks!");

    }
}
