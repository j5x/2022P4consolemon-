using System.Collections.Generic;

namespace GDCSharp2
{
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
}
