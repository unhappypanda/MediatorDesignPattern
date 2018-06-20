using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediatorBadSample
{
    public class Airbus321 : Aircraft
    {
        public Airbus321(string callSign) : base(callSign)
        {
        }

        public override int Ceiling
        {
            get { return 41000; }
        }
    }
}
