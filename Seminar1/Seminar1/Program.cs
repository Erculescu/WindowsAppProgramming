using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Introdu numele: ");
            //string nume=Console.ReadLine();
            //Console.WriteLine("Hello " + nume + "!");
            //Console.WriteLine("Hello, World!");
            //Console.WriteLine($"Hello {nume}!");

            //int nrpreturi=int.Parse(Console.ReadLine());

            //float[] preturi = new float[nrpreturi];
            //for(int i = 0; i < nrpreturi; i++) {
            //   preturi[i]= int.Parse(Console.ReadLine());
            //}
            //for(int i = 0; i < nrpreturi; i++) {
            //    preturi[i] =(float)( preturi[i] * 1.1);
            //    Console.WriteLine(preturi[i]);

            //}
            //Console.WriteLine(string.Join(",", preturi));
            Console.WriteLine("Parametri: ");
            foreach (var arg in args)
            {
                Console.WriteLine("\t" + arg);
            }
            string[] vSiruri = args[0].Split(',');
            int[] vInt = new int[vSiruri.Length];
            for (int i = 0; i < vInt.Length; i++)
            {
                vInt[i] = int.Parse(vSiruri[i]);

            }
            Console.WriteLine(string.Join(", ", vInt));
            string[] vSiruri2 = args[1].Split(',');
            int[] vInt2 = new int[vSiruri2.Length];
            for (int i = 0; i < vInt2.Length; i++)
            {
                vInt2[i] = int.Parse(vSiruri2[i]);
            }
            Console.WriteLine(string.Join(", ", vInt2));
            int[] vInt3 = new int[vInt.Length + vInt2.Length];
            for (int i = 0; i < vInt.Length; i++)
            {
                vInt3[i] = vInt[i];
            }
            for (int i = vInt.Length, j = 0; i < vInt3.Length; i++, j++)
            {
                vInt3[i] = vInt2[j];
            }
            //Merge si cu Array.Copy(vInt, vInt3, vInt.Length);
            //Array.Copy(sourceArray: vInt,sourceIndex:0,destinationArray:vInt3,destinationIndex: 0 sau vInt.Length,Length:vInt2.Length);

            Array.Sort(vInt3);
            Console.WriteLine(string.Join(", ", vInt3));

        }
    }
}