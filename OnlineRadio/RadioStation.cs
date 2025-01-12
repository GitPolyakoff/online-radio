using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineRadio
{
    class RadioStation
    {
        public string Name { get; set; }
        public string StreamUrl { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}