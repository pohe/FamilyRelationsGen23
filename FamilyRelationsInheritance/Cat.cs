using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyRelationsInheritance
{
    public class Cat : Animal
    {
       public string Color { get; set; }

        public Cat(string name, int weigth, string color, int l) : base(name, weigth, l)
        {
            Color = color;
        }

        public override bool CanSwim()
        {
            return false;
        }

        public override string ToString()
        {
            return $"{base.ToString()} og farve {Color}";
        }
    }
}
