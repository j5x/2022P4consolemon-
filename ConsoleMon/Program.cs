using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDCSharp2
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleMon a = new ConsoleMon();

            ConsoleMon b = new ConsoleMon();

            Skill fire = new Skill();
            Skill water = new Skill();
            Skill lightning = new Skill();
            Skill shadow = new Skill();

            a.skills.Add(fire);
            a.skills.Add(water);

            b.skills.Add(lightning);
            b.skills.Add(shadow);

            ConsoleMonArena arena = new ConsoleMonArena();
            arena.DoBattle(a, b);
        }
    }

    enum Elementen
    {
        Fire,
        Water,
        Lightning,
        Shadow,
    }

    public class ConsoleMon
    {
        public ConsoleMon()
        {
            
        }

        public ConsoleMon(ConsoleMon copyFrom)
        {
            
            this.Health = copyFrom.Health;
            this.Name = copyFrom.Name;
            this.Energy = copyFrom.Energy;

            for (int i = 0; i < copyFrom.skills.Count; i++)
            {
                Skill copyFromThisSkill = copyFrom.skills[i];
                Skill clone = new Skill(copyFromThisSkill);
                this.skills.Add(clone);
            }
        }

        internal List<Skill> skills = new List<Skill>();
        
        internal int Health = 100;
        internal int Energy = 100;
        internal string Name = "Jakko";
        public void TakeDamage(int Damage)
        {
            Health = Health - Damage;
        }
        public void DepleteEnergy(int Energy)
        {
            this.Energy -= Energy;
        }
        Elementen weakness = Elementen.Water;
    }

    public class Skill
    {
        public int Damage = 100;
        public int EnergyCost = 100;
        public string Name = "StinkyBreathAttack";
        public Skill()
        { }
        
        internal Skill(Skill copyFrom)
        {
            this.Damage = copyFrom.Damage;
            this.EnergyCost = copyFrom.EnergyCost;
            this.Name = copyFrom.Name;
        }

        public void UseOn(ConsoleMon target, ConsoleMon caster)
        {
            target.TakeDamage(Damage);
            caster.DepleteEnergy(EnergyCost);
        }      
        Elementen element = Elementen.Fire;
    }

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
