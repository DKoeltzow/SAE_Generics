using System;

namespace Generics
{
    class Weapon : Equipment
    {
        private string name;

        public string Name
        {
            get { return this.name; }
        }

        public Weapon(string name)
        {
            this.name = name;
        }
        
    }
}
