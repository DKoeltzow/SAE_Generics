using System;
using System.Collections.Generic;

namespace Generics
{
    class Knight
    {
        List<Equipment> equipment = new List<Equipment>();

        public void Equip(Equipment item)
        {
            this.equipment.Add(item);
        }

        // Generic method
        public void HasEquipment<T>()
        {
            foreach (var piece in this.equipment)
            {
                if (piece is T)
                {
                    Console.WriteLine("Knight has " + piece.GetType().Name);
                }
            }
        }

        // Generic return type and constraint
        public T GetEquipment<T>() where T : Equipment
        {
            foreach (var piece in this.equipment)
            {
                if (piece is T)
                {
                    return (T)piece;
                }
            }

            return null;
        }
    }
}
