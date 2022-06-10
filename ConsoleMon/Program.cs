using System;
using System.Collections.Generic;

namespace GDCSharp2
{

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

            for (int i = 0; i < copyFrom.Skill; i++)
            {

            }
        }

        List<Skill> skills = new List<Skill>();
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
}
