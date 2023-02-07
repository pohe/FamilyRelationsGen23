using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSort
{
    public class Animal : IComparable<Animal>
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

        public int CompareTo(Animal? other)
        {
            if (_weight < other.Weight)
            {
                return -1;
            }
            else if (_weight > other.Weight)
            {
                return 1;
            }
            else return 0;
            //return Name.CompareTo(other.Name);
        }
    }
}
