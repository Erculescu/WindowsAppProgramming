using System;
namespace ConsoleApp
{
    class Program
    {
        static void nrpare(int[,] v)
        {
            int n = v.GetLength(0);
            int m = v.GetLength(1);
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (v[i,j] % 2 == 0)
                    {
                        k++;
                    }
                }
            }
            int[] rez = new int[k];
            k = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (v[i,j] % 2 == 0)
                    {
                        rez[k] = v[i,j];
                        k++;
                    }
                }
            }
             
            for(int i = 0; i < k; i++)
            {
                Console.Write(rez[i] + " ");
            }
            

        }
        static void Main(string[] args)
        {
            int nrranduri = 2;
            int nrcoloane = 4;
            int[,] v = new int[nrranduri,nrcoloane];

            string[] elemente = args[0].Split(',');
            if (elemente.Length != nrranduri * nrcoloane)
            {
                Console.WriteLine("Dimensiune invalida");
            }

            int index = 0;
            for(int i = 0; i < nrranduri; i++)
            {
                for(int j = 0; j < nrcoloane; j++)
                {
                    v[i, j] = int.Parse(elemente[index]);
                    index++;
                }
            }
            nrpare(v);



        }

    }
}