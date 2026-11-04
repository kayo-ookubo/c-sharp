using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section702
{
    class TwoStrings
    {
        public string String1 { get; set;} = string.Empty;
        public string String2 { get; set;} = string.Empty;

        public string GetConnectedString()
        {
            return String1 + String2;
        }

    }
}
