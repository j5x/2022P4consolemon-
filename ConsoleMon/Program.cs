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
}
