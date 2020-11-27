using System;

namespace Zadania_z_rozdziału_5
{
    class Program
    {
        static double Temperatura(double a)
        {
            return ((a-32)*5/9);
        }
        static bool Przedzial(double a, double b, double x)
        {
            if (a < x && x < b)
                return true;
            else
                return false;
        }
        static void Przesun(ref double[] a, double[] b)
        {
            for(int i=0;i<2;i++)
            {
                a[i] = a[i] + b[i];
            }
        }
        static int[] Mnoz1(int[] tab1,int x)
        {
            int[] tab = new int[tab1.Length];
            for(int i=0;i<tab.Length;i++)
            {
                tab[i] = tab1[i] * x;
            }
            return tab;
        }
        static void Mnoz2(ref int[] tab,int x)
        {
            for(int i=0;i<tab.Length;i++)
            {
                tab[i] = tab[i] * x;
            }
        }
        static void Rysuj(int sz,int dl,char znak)
        {
            for(int i=0;i<sz;i++)
            {
                for(int j=0;j<dl;j++)
                {
                    Console.Write(znak);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void Mnoz3(ref string[] tab,int x)
        {
            string z;
            for(int i=0;i<tab.Length;i++)
            {
                z = tab[i];
                for(int j=0;j<x-1;j++)
                {
                    tab[i] += z;
                }
            }
        }
        static double W(double x,double n)
        {
            double W=0;
            for(int i=Convert.ToInt32(n);i>0;i--)
            {
                W =W + (x + i);
            }
            return W;
        }
        static int SumCyfr(int x)
        {
            int sum = 0;
            while(x>0)
            {
                sum = sum + (x % 10);
                x = x / 10;
            }
            return sum;
        }
        public static int Fib1(int n)
        {
            if ((n == 0) || (n == 1))
                return n;
            else
                return Fib1(n - 1) + Fib1(n - 2);
        }
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.WriteLine("Zadanie 5.1\nPodaj temperaturę w fahrenheitach");
            double t = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("To jest: " + Temperatura(t) + " stopni C.\n");
            Console.WriteLine("Zadanie 5.2\nPodaj a, b, x, a program sprawdzi czy x znajduje się w przedziale otwartym (a,b)");
            double a, b, x;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            x = Convert.ToDouble(Console.ReadLine());
            if (Przedzial(a, b, x))
                Console.WriteLine("x znajduje się w przedziale (a,b)");
            else
                Console.WriteLine("x nie znajduje się w tym przedziale");
            Console.WriteLine("Zadanie 5.3\nPodaj współrzędne punktu A.");
            double[] A = new double[2];
            double[] wek = new double[2] { 3, 2 };
            for(int i=0;i<A.Length;i++)
            {
                A[i] = Convert.ToDouble(Console.ReadLine());
            }
            Przesun(ref A, wek);
            for(int i=0;i<A.Length;i++)
            {
               Console.Write(A[i]+" ");
            }
            Console.WriteLine("\nZadanie 5.4\nPodaj mnożnik tablicy jednowymiarowej.");
            int xm = Convert.ToInt32(Console.ReadLine());
            int[] tab = new int[rand.Next(3, 10)];
            Console.WriteLine("Wygenerowana losowo tablica:");
            for (int i = 0; i < tab.Length; i++) 
            {
                tab[i] = rand.Next(-100, 100);
                Console.WriteLine(tab[i]);
            }
            Console.WriteLine("Metoda a:");
            for (int i = 0; i < Mnoz1(tab, xm).Length; i++) 
            {
                Console.WriteLine("" + Mnoz1(tab, xm)[i]);
            }
            Console.WriteLine("Metoda b:");
            Mnoz2(ref tab, xm);
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(tab[i]);
            }
            Console.WriteLine("Zadanie 5.5");
            int sz, dl;
            char znak;
            Console.Write("Podaj szerokość: "); sz = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj długość: "); dl = Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj znak: "); znak = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();
            Rysuj(sz, dl, znak);
            Rysuj(dl, sz, znak);
            Console.WriteLine("Zadanie 5.6");
            string[] slowa = { "ala", "kot", "dom" };
            Console.Write("Podaj mnożnik: ");
            int xs = Convert.ToInt32(Console.ReadLine());
            Mnoz3(ref slowa, xs);
            for(int i=0;i<slowa.Length;i++)
            {
                Console.WriteLine(slowa[i]);
            } 
            Console.WriteLine("Zadanie 5.7\nPodaj x i n.");
            double x7, n;
            x7 = Convert.ToDouble(Console.ReadLine());
            n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Wyrażenie W wynosi: "+W(x7, n));
            Console.WriteLine("Zadanie 5.8\nPodaj liczbę.");
            int x8 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Suma cyfr tej liczby wynosi: " + SumCyfr(x8));
            Console.WriteLine("Zadanie 5.9\nPodaj n, a program wyświetli n-tą liczbę ciągu Fibonacciego.");
            int nf = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Twoja liczba to: " + Fib1(nf));
        }
    }
}
