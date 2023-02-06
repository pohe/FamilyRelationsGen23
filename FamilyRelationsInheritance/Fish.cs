using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyRelationsInheritance
{
    public class Fish : Animal
    {
        public Fish(string name, int weigth, int length) : base(name, weigth, length)
        {

        }

        public override bool CanSwim()
        {
            return true;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
