using System;
using RoleplayGame;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            SpellsBook book = new SpellsBook();
            book.AddSpell(new SpellOne());
            book.AddSpell(new SpellOne());

            Wizard gandalf = new Wizard("Gandalf");
            gandalf.AddItem(book);

            Dwarf gimli = new Dwarf("Gimli");

            Console.WriteLine($"Gimli has <3 {gimli.Health}");
            Console.WriteLine($"Gandalf attacks Gimli with --> {gandalf.AttackValue}");

            gimli.ReceiveAttack(gandalf.AttackValue);

            Console.WriteLine($"Gimli has <3 {gimli.Health}");

            gimli.Cure();

            Console.WriteLine($"Someone cured Gimli. Gimli now has <3 {gimli.Health}");


            ////////////////////7
            Wizard pedro = new Wizard("pedro");
            Enemigos martin = new Enemigos("Martin");
            Console.WriteLine($"salud de pedro: {pedro.Health}");
            Encounter pelea = new Encounter("pelea1");
            pelea.EncounterAdd(martin);
            pelea.EncounterAdd(pedro);
            pelea.DoEncounter();
            Console.WriteLine($"ataque de martin {martin.AttackValue}");
            Console.WriteLine($"salud de pedro post pelea: {pedro.Health}");
        }
    }
}
