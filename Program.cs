using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            InventorySlot<Potion> potions = new InventorySlot<Potion>();

            // Grundaufbau
            Knight knight = new Knight();
            knight.Equip(new Weapon("Excalibur"));
            knight.Equip(new Shield(100));

            // Generische Methode ohne Rückgabewert und Parameter
            knight.HasEquipment<Weapon>();
            knight.HasEquipment<Gloves>();

            // Generischer Rückgabewert
            Weapon weapon = knight.GetEquipment<Weapon>();
            Console.WriteLine(weapon.Name);

            Shield shield = knight.GetEquipment<Shield>();
            Console.WriteLine(shield.Defense);

            potions.AddItem(new Potion());
            potions.AddItem(new Potion());

            Console.WriteLine(potions.Count);

            Potion potion = potions.GetItem(0);
            potion.Drink();
            Console.Read();
        }
    }
}
