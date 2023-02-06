using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyRelationsInheritance
{
    public abstract class Animal 
    {
        private int _weight;
        public int Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        public string Name { get; set; }

        public int Lenght { get; set; }

        public Animal(string name, int weight, int length)
        {
            Name = name;
            _weight = weight;
            Lenght = length;
        }

        public abstract bool CanSwim();

        public override string ToString()
        {
            return $"{Name}  {_weight}  {Lenght} {(CanSwim()?"kan svømme": "kan ikke svømme") }";
        }

       
    }
}
