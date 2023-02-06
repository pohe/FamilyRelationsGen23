using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSort
{
    public class AnimalComparerByWeight : IComparer<Animal>
    {
        public int Compare(Animal x, Animal y)
        {
            if (x.Weight < y.Weight) { return -1; }

            if (x.Weight > y.Weight) { return 1; }

            return 0;
        }
    }
}
