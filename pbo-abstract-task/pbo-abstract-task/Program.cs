using pbo_abstract_task;

public interface IKemampuan
{
    string Nama { get; }
    int Cooldown { get; }
    void Gunakan(Robot robot, Robot target);
}



class Program
{
    static void Main(string[] args)
    {
        Robot robot1 = new RobotBiasa("Pejuang1", 50, 5, 15);
        Robot bos = new BosRobot("Bos Musuh", 100, 10);

        IKemampuan perbaikan = new Repair();
        IKemampuan listrik = new ElectricShock();

        robot1.Serang(bos);
        robot1.GunakanKemampuan(perbaikan, robot1);

        robot1.CetakInformasi();
        bos.CetakInformasi();
    }
}


