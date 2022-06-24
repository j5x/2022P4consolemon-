namespace GDCSharp2
{
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
