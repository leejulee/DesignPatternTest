﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest
{
    public abstract class MCountry
    {
        protected UnitNations mediator;

        public MCountry(UnitNations mediator)
        {
            this.mediator = mediator;
        }
    }
}
