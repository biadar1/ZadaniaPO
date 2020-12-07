using System;

namespace Ćwiczenia_6
{
    public class Prostokat
    {
        private static double naj=0;
        private double dlugosc;
        private double szerokosc;
        private double powierzchnia()
        {
            double p = dlugosc * szerokosc;
            if (p > naj)
                naj = p;
            return p;
        }
        private double obwod()
        {
            double o = (dlugosc * 2) + (szerokosc * 2);
            return o;
        }
        public void Prezentuj()
        {
            Console.WriteLine("Powierzchnia tego prostokąta wynosi: {0}", powierzchnia());
            Console.WriteLine("Obwód tego prostokąta wynosi: {0}", obwod());
        }
        public Prostokat(double d,double s)
        {
            dlugosc = d;
            szerokosc = s;
        }
        public void Naj()
        {
            Console.WriteLine("Powierzchnia największego prostokąta wynosi: {0}", naj);
        }
    }
    public class Licznik
    {
        public double poczatkowy;
        public double biezacy;
        public Licznik(double p, double b)
        {
            if (p > b)
                Console.WriteLine("Początkowy licznik nie może być większy od bierzącego!");
            else
            {
                poczatkowy = p;
                biezacy = b;
            }
        }
        public void Pokaz()
        {
            Console.WriteLine("Początkowy stan licznika: {0}", poczatkowy);
            Console.WriteLine("Bieżący stan licznika: {0}", biezacy);
        }
        public double Oblicz()
        {
            double z = biezacy - poczatkowy;
            return z;
        }
    }
    public class Punkt
    {
        public int X;
        public int Y;
        public Punkt(int x,int y)
        {
            X = x;
            Y = y;
        }
        public void Przesun()
        {
            Console.Write("Podaj przesunięcie w osi X: ");
            X += Convert.ToInt32(Console.ReadLine());
            Console.Write("Podaj przesunięcie w osi Y: ");
            Y += Convert.ToInt32(Console.ReadLine());
        }
        public void Wyswietl()
        {
            Console.WriteLine("Współrzędne tego punktu: {0},{1}",X,Y);
        }
    }
    public class Odcinek
    {
        public Punkt A;
        public Punkt B;
        public Odcinek(Punkt a, Punkt b)
        {
            A = a;
            B = b;
        }
        public double Dlugosc()
        {
            Punkt C = new Punkt(B.X,A.Y);
            double d = Math.Sqrt(Math.Pow(B.X-A.X,2)+Math.Pow(B.Y-A.Y,2));
            return d;
        }
    }
    public class Prostopadloscian
    {
        public double dlugosc;
        public double szerokosc;
        public double wysokosc;
        public Prostopadloscian(double d, double s, double w)
        {
            dlugosc = d;
            szerokosc = s;
            wysokosc = w;
        }
        public double Objetosc()
        {
            double o = dlugosc * szerokosc * wysokosc;
            return o;
        }
    }
    public struct StructProstokat
    {
        private double dlugosc;
        private double szerokosc;
        private double powierzchnia()
        {
            double p = dlugosc * szerokosc;
            return p;
        }
        private double obwod()
        {
            double o = (dlugosc * 2) + (szerokosc * 2);
            return o;
        }
        public void Prezentuj()
        {
            Console.WriteLine("Powierzchnia tego prostokąta wynosi: {0}", powierzchnia());
            Console.WriteLine("Obwód tego prostokąta wynosi: {0}", obwod());
        }
        public StructProstokat(double d, double s)
        {
            dlugosc = d;
            szerokosc = s;
        }

    }
    public struct KandydatNaStudia
    {
        public string nazwisko;
        private int punktyMatematyka;
        private int punktyInformatyka;
        private int punktyJezykObcy;
        public KandydatNaStudia(string n, int M, int I, int JO)
        {
            nazwisko = n;
            punktyMatematyka = M;
            punktyInformatyka = I;
            punktyJezykObcy = JO;
        }
        public double WszystkiePunkty()
        {
            double WP =(0.6*punktyMatematyka)+(0.5*punktyInformatyka)+(0.2*punktyJezykObcy);
            return WP;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            static void CzyNaProstej(Punkt a, Punkt b)
            {
                if (a.X == b.X)
                    Console.WriteLine("Obydwa punkty leżą na tej samej prostej X={0}.",a.X);
                if (a.Y == b.Y)
                    Console.WriteLine("Obydwa punkty leżą na tej samej prostej względem Y={0}.",a.Y);
                else
                    Console.WriteLine("Te punkty nie leżą na żadnej wspólnej prostej.");
            }
            static void PorObj(Prostopadloscian a, Prostopadloscian b)
            {
                if (a.Objetosc() < b.Objetosc())
                    Console.WriteLine("Prostopadlościan B jest większy.");
                if (a.Objetosc() > b.Objetosc())
                    Console.WriteLine("Prostopadlościan A jest większy.");
                if (a.Objetosc() == b.Objetosc())
                    Console.WriteLine("Prostopadlościany mają równą objętość.");
            }
            Console.WriteLine("Zadanie 6.1");
            Prostokat p1 = new Prostokat(4,5);
            p1.Prezentuj();
            Console.WriteLine("Zadanie 6.2");
            Prostokat[] p2 = new Prostokat[3];
            p2[0] = new Prostokat(14, 7);
            p2[1] = new Prostokat(9, 4);
            p2[2] = new Prostokat(10.40, 6.25);
            foreach(Prostokat p in p2)
            {
                p.Prezentuj();
            }
            Console.WriteLine("Zadanie 6.3");
            p1.Naj();
            Console.WriteLine("Zadanie 6.4");
            Licznik x = new Licznik(400, 500);
            x.Pokaz();
            Console.WriteLine("Zużyto: {0}",x.Oblicz());
            Console.WriteLine("Zadanie 6.5");
            Punkt P = new Punkt(-1, 1);
            P.Wyswietl();
            P.Przesun();
            P.Wyswietl();
            Console.WriteLine("Zadanie 6.6");
            Punkt[] tabP = new Punkt[3];
            tabP[0] = new Punkt(4, -2);
            tabP[1] = new Punkt(6, -2);
            tabP[2] = new Punkt(4, -4);
            Console.WriteLine("Punkty 1 i 2.");
            CzyNaProstej(tabP[0], tabP[1]);
            Console.WriteLine("Punkty 2 i 3.");
            CzyNaProstej(tabP[1], tabP[2]);
            Console.WriteLine("Zadanie 6.7");
            Odcinek AB = new Odcinek(tabP[1], tabP[2]);
            Console.WriteLine("Długość odcinka wynosi: {0}",AB.Dlugosc());
            Console.WriteLine("Zadanie 6.8");
            Prostopadloscian[] tabABC = new Prostopadloscian[2];
            tabABC[0] = new Prostopadloscian(4, 5, 6);
            tabABC[1] = new Prostopadloscian(7, 5, 4);
            PorObj(tabABC[0], tabABC[1]);
            Console.WriteLine("Zadanie 6.9");
            StructProstokat sp1 = new StructProstokat(6, 6);
            sp1.Prezentuj();
            Prostokat[] sp2 = new Prostokat[3];
            sp2[0] = new Prostokat(4, 4);
            sp2[1] = new Prostokat(10, 12);
            sp2[2] = new Prostokat(2.2, 3.3);
            foreach (Prostokat sp in sp2)
            {
                sp.Prezentuj();
            }
            Console.WriteLine("Zadanie 6.10");
            KandydatNaStudia[] tabK = {new KandydatNaStudia("Kowalski",80,90,100),
                new KandydatNaStudia("Nowak",98,86,80),
                new KandydatNaStudia("Baran",52,58,57)
            };
            foreach(KandydatNaStudia K in tabK)
            {
                Console.WriteLine("{0} wynik: {1}",K.nazwisko,K.WszystkiePunkty());
            }
        }
    }
}
