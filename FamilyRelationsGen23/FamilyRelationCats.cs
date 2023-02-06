using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyRelationsGen23
{
    class FamilyRelationCats
    {
        private Cat _self;
        private Cat _father;
        private Cat _mother;
        private List<Cat> _children;

        public FamilyRelationCats(Cat self, Cat father, Cat mother)
        {
            _self = self;
            _father = father;
            _mother = mother;
            _children = new List<Cat>();
        }

        public Cat Self { get { return _self; } }

        public Cat Father { get { return _father; } }

        public Cat Mother { get { return _mother; } }

        public List<Cat> Children { get { return _children; } }

        public void AddChild(Cat child)
        {
            _children.Add(child);
        }

        //Override the Tostring methods to printout the family relations
        public override string ToString()
        {
            string children = "";
            foreach (Cat cat in Children)
            {
                children += cat.Name + " ";
            }
            return $"Name of cat {Self.Name} mother {Mother.Name} father {Father.Name} chrildren {children} ";
        }

    }
}
