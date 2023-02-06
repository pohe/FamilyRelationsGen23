using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyRelationsGenerics
{
    public class Dog : Animal
    {

        public Dog(string name, int weight, int l) : base(name, weight, l)
        {

        }

        public override bool CanSwim()
        {
            return false;
        }

        public override string ToString()
        {
            return $"{base.ToString()}";
        }
    }
}
