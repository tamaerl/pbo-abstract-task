namespace pbo_abstract_task
{
    public abstract class Robot
    {
        public string Nama;     
        public int Energi;
        public int Armor;
        public int Serangan;

        public Robot(string nama, int energi, int armor, int serangan)
        {
            Nama = nama;
            Energi = energi;
            Armor = armor;
            Serangan = serangan;
        }

        public virtual void Serang(Robot target)
        {
            int damage = Math.Max(0, Serangan - target.Armor);
            target.Energi -= damage;
            Console.WriteLine($"{Nama} menyerang {target.Nama} dengan damage {damage}");
        }

        public void GunakanKemampuan(IKemampuan kemampuan, Robot target)
        {
            Console.WriteLine($"{Nama} menggunakan {kemampuan.Nama}");
            kemampuan.Gunakan(this, target);
        }

        public void CetakInformasi()
        {
            Console.WriteLine($"Nama: {Nama}, Energi: {Energi}, Armor: {Armor}, Serangan: {Serangan}");
        }

        public void TambahEnergi(int amount)
        {
            Energi += amount;
            Console.WriteLine($"{Nama} memulihkan {amount} energi.");
        }
    }

    public class BosRobot : Robot
    {
        public BosRobot(string nama, int energi, int armor) : base(nama, energi, armor, 0)
        {
        }

        public void Diserang(Robot penyerang)
        {
            Serang(penyerang);
            if (Energi <= 0)
            {
                Mati();
            }
        }

        private void Mati()
        {
            Console.WriteLine($"{Nama} telah mati.");
        }
    }

    public class RobotBiasa : Robot
    {
        public RobotBiasa(string nama, int energi, int armor, int serangan) : base(nama, energi, armor, serangan)
        {
        }
    }
}
