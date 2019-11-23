﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PartyCodding
{
    public interface IFlyable
    {
        void Fly();
        FlightPower FlightPower { get; set; }
    }
}
