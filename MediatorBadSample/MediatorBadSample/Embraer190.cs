using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediatorBadSample
{
    public class Embraer190: Aircraft
    {
        public Embraer190(string callSign) : base(callSign)
        {
        }

        public override int Ceiling
        {
            get { return 35000; }
        }
    }
}
