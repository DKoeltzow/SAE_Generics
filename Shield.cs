using System;

namespace Generics
{
    class Shield : Equipment
    {
        private int defense;

        public int Defense
        {
            get { return this.defense; }
        }

        public Shield(int defense)
        {
            this.defense = defense;
        }
    }
}
