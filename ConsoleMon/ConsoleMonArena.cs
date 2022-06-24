using System;

namespace GDCSharp2
{
    public class ConsoleMonArena
    {
        public void DoBattle(ConsoleMon a, ConsoleMon b)
        {
            Random random = new Random();

            Skill skillA = a.skills[random.Next(2)];
            Skill skillB = b.skills[random.Next(2)];

            while (a.Health > 0 || b.Health > 0)
            {
                skillA.UseOn(b, a);
                skillB.UseOn(a, b);

                Console.WriteLine(a.Health);
                Console.WriteLine(b.Health);
            }
        }
    }
}
