using System;

namespace Kolokwium_1
{
    class Program
    {
        static int Aib(string txt)
        {
            int sum=0;
            for (int i = 0; i < txt.Length; i++) 
            {
                if (txt[i] == Convert.ToChar("a") || txt[i] == Convert.ToChar("b"))
                    sum++;
            }
            return sum;
        }
        static string Odwr(string txt)
        {
            char[] ciag = txt.ToCharArray();
            Array.Reverse(ciag);
            return new string(ciag);
        }
        static void Wczyt(int m, int n, ref int[,] A)
        {
            for (int i = 0; i < m; i++) 
            {
                for (int j = 0; j < n; j++) 
                {
                    Console.WriteLine("Podaj element: " + i + ", " + j);
                    A[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        static int NajUjemny(int m, int n, int[,] A)
        {
            int naj = 0;
            for(int i=0;i<m;i++)
            {
                for(int j=0;j<n;j++)
                {
                    if(A[i,j]<naj)
                    {
                        naj = A[i, j];
                    }
                }
            }
            if (naj < 0)
            {
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (A[i, j] == naj)
                        {
                            Console.WriteLine("Najmniejszy element jest w: "+i+", "+j);
                        }
                    }
                }
            }
            else
                Console.WriteLine("Nie ma ujemnych elementów.");
            return naj;
        }
        static int Dod(double[] x)
        {
            int dod = 0;
            for(int i=0;i<x.Length;i++)
            {
                if (x[i] > 0)
                    dod++;
            }
            return dod;
        }
        static int Ujem(double[] x)
        {
            int ujem = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] < 0)
                    ujem++;
            }
            return ujem;
        }
        static int Zero(double[] x)
        {
            int zero = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] == 0)
                    zero++;
            }
            return zero;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Zadanie 1.\nPodaj słowo, a program obliczy ile sumę liter a oraz b.");
            string txt = Console.ReadLine();
            Console.Write("W tym słowie suma liter a i b wynosi: "+Aib(txt)+"\n");
            Console.WriteLine("To słowo na odwrót: " + Odwr(txt));
            Console.WriteLine("Zadanie 2.");
            int m=-1, n=-1,naj;
            while (m < 0 || m > 10 || n < 0 || n > 10) 
            {
                Console.WriteLine("Podaj m i n, te liczby mają być nieujemnie i nie większe od 10.");
                m = Convert.ToInt32(Console.ReadLine());
                n = Convert.ToInt32(Console.ReadLine());
            }
            int[,] A = new int[m, n];
            Wczyt(m, n, ref A);
            Console.WriteLine(naj = NajUjemny(m, n, A));
            Console.WriteLine("Zadanie 3.\nPodaj ile n liczb rzeczywistych chcesz sprawdzić.");
            int n3 = Convert.ToInt32(Console.ReadLine());
            double[] z3 = new double[n3];
            for(int i=0;i<z3.Length;i++)
            {
                Console.WriteLine("Podaj " + (i+1) + " element");
                z3[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.WriteLine("Ilość elementów dodatnich: " + Dod(z3));
            Console.WriteLine("Ilość elementów ujemnych: " + Ujem(z3));
            Console.WriteLine("Ilość elementów równych 0: " + Zero(z3));
            Console.WriteLine("Zadanie 4");
            double przek = 0;
            double[,] tab = new double[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine("Podaj element: "+(i+1)+", "+(j+1));
                    tab[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }
            Console.WriteLine("Twoja tablica: ");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                        Console.Write(tab[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 5; i++)
            {
                przek += tab[i, i];
            }
            Console.WriteLine("Suma elementów głównej przekątnej tej tablicy wynosi: " + przek);
        }
    }
}
