﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediatorBadSample
{
    public class Boeing737200 : Aircraft
    {
        public Boeing737200(string callSign) : base(callSign)
        {
        }

        public override int Ceiling
        {
            get { return 35000; }
        }
    }
}
