﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternTest
{
    public interface IAbstractFactory
    {
        AbstractProductA CreateProductA();

        AbstractProductB CreateProductB();
    }
}