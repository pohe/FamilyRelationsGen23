﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSort
{
    public class Swapper
    {
        public void Swap<T>(ref T a,ref  T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

    }
}
