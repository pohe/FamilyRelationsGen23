using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FamilyRelationsGen23
{
    public class Cat 
    {
        public string Name { get; set; }

        public string Color { get; set; }

        public Cat(string name, string color) 
        {
            Name = name;
            Color = color;
        }

        

        public override string ToString()
        {
            return $"Kattens navn er {Name} og farve {Color}";
        }
    }
}
