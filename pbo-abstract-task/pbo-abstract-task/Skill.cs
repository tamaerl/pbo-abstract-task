
namespace pbo_abstract_task
{
    public class Repair : IKemampuan
    {
        public string Nama => "Perbaikan";
        public int Cooldown => 2;

        public void Gunakan(Robot robot, Robot target)
        {
            robot.TambahEnergi(10);
        }
    }

    public class ElectricShock : IKemampuan
    {
        public string Nama => "Serangan Listrik";
        public int Cooldown => 3;

        public void Gunakan(Robot robot, Robot target)
        {
            int damage = 5;
            target.Energi -= damage;
            Console.WriteLine($"{target.Nama} terkena listrik sebesar {damage}");
        }
    }

    public class PlasmaCannon : IKemampuan
    {
        public string Nama => "Serangan Plasma";
        public int Cooldown => 4;

        public void Gunakan(Robot robot, Robot target)
        {
            int damage = 10;
            target.Energi -= damage;
            Console.WriteLine($"{target.Nama} terkena tembakan plasma sebesar {damage}");
        }
    }

    public class SuperShield : IKemampuan
    {
        public string Nama => "Pertahanan Super";
        public int Cooldown => 5;

        public void Gunakan(Robot robot, Robot target)
        {
            const int buffAmount = 5;
            robot.Armor += buffAmount;
            Console.WriteLine($"{robot.Nama} meningkatkan armor sebesar {buffAmount}");
        }
    }
}
