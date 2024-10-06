using System;
using System.Collections.Generic;
using Actividad_1_PSP.CharacterWithPerks;

class Program
{
    static void Main()
    {
        Character hero = new Character("Guerrero", 100, 20, 10);
        
        Console.WriteLine($"Personaje: {hero.Name}");
        Console.WriteLine($"Vida: {hero.GetMaxHitPoints()}");
        Console.WriteLine($"Daño base: {hero.Attack()}");
        Console.WriteLine($"Armadura base: {hero.Defense()}");
        Console.WriteLine();

        Axe axe = new Axe { Name = "Hacha de batalla", Damage = 15 };
        hero.EquipItem(axe);

        Helmet helmet = new Helmet { Name = "Casco de acero", Armor = 5 };
        hero.EquipItem(helmet);

        Console.WriteLine("El personaje ataca a un enemigo...");
        int damage = hero.Attack();
        Console.WriteLine($"Daño infligido: {damage}");

        Console.WriteLine("El personaje recibe un ataque de 30 de daño...");
        hero.ReceiveDamage(30);
        Console.WriteLine($"Vida después del daño: {hero.GetMaxHitPoints()}");

        Console.WriteLine("El personaje recibe una curación de 50 puntos...");
        hero.Heal(50);
        Console.WriteLine($"Vida después de la curación: {hero.GetMaxHitPoints()}");    }
}



