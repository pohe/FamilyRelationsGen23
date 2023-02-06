using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSort
{
    public class Animal 
    {
        public string Name { get; set; }
        private int _weight;

        public int Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        public Animal(string name, int weight)
        {
            Name = name;
            _weight = weight;
        }

        public override string ToString()
        {
            return $"Name {Name} Weight {Weight}";
        }


    }
}
