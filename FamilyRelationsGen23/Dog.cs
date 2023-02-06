using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyRelationsGen23
{
    public class Dog 
    {
        public string Name { get; set; }

        public Dog(string name) 
        {
            Name = name;
        }

     
        public override string ToString()
        {
            return $" Name {Name} ";
        }
    }
}
