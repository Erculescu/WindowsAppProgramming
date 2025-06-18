namespace Exersare_14
{
    internal static class Program
    {
        public static Job job { get; } = new Job("Software Manager");
        [STAThread]
        static void Main()
        {
            job.adaugaInterviu( new Interviu(1, "Rares", 88));
            job.adaugaInterviu(new Interviu(2, "Ionut", 66));
            job.adaugaInterviu(new Interviu(3, "Andrei", 72));
            job.adaugaInterviu(new Interviu(4, "Mihai", 91));

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}