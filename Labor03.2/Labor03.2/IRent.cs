﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labor03._2
{
    internal interface IRent
    {
        int GetCost(int months);
        bool IsBooked { get; }
        bool Book(int months);
    }
}
