using Exersare_3;
namespace Exersare_3
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            var ps1 = new Playstation("PS1", 1000, "3500000", 228, Exclusive.GodofWar);
            Console.WriteLine(ps1);
            ps1.afisarememorie();
            var xbox360 = new Xbox("Xbox360", 900, "4890000", 640, Exclusive.Forza);
            xbox360.calculvenit();
            xbox360.afisarememorie();
            Console.WriteLine(xbox360);
        }
        
    }
}