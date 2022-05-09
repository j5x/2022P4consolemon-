using System;

namespace GDCSharp2
{
    public class ConsoleMon
    {
        int Health = 100;
        int Energy = 100;
        string Name = "Jakko";
        public void TakeDamage(int Damage)
        {
            Health = Health - Damage;
        }
        public void DepleteEnergy(int Energy)
        {
            this.Energy -= Energy;
        }
    }


    public class Skill
    {
        public int Damage = 100;
        public int EnergyCost = 100;
        public string Name = "StinkyBreathAttack";

        public void UseOn(ConsoleMon target, ConsoleMon caster)
        {
            target.TakeDamage(Damage);
            caster.DepleteEnergy(EnergyCost);


        }
    }
}
