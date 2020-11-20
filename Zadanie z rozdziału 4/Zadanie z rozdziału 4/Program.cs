using System;

namespace Zadanie_z_rozdziału_4
{
    class Program
    {
        static void Main(string[] args)
        {
            static void zadanie4_1()
            {               
                Console.WriteLine("Zadanie 4.1");
                Console.Write("Podaj wielkość tablicy: ");
                int n = Convert.ToInt32(Console.ReadLine());
                int[] tab = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.Write("Podaj liczbę nr." + (i + 1) + " : ");
                    tab[i] = Convert.ToInt32(Console.ReadLine());
                }
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Miejsce w tabeli: " + i + ", liczba: " + tab[i]);
                }
            }
            static void zadanie4_2()
            {
                Console.WriteLine("Zadanie 4.2");
                Console.WriteLine("Podaj 10 liczb, a program wypisze liczby >0");
                int[] tab1 = new int[10]; int[] tab2 = new int[10];
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Podaj " + (i + 1) + " liczbe swojej tablicy");
                    tab1[i] = Convert.ToInt32(Console.ReadLine());
                    if (tab1[i] > 0)
                        tab2[i] = tab1[i];
                }
                for (int i = 0; i < tab2.Length; i++)
                {
                    if(tab2[i]>0)
                        Console.WriteLine("Liczba dodatnia to: " + tab2[i]);
                }
            }
            static void zadanie4_3()
            {
                double max, min, sr=0;
                int dod=0;
                Console.WriteLine("Zadanie 4.3");
                Console.Write("Podaj rozmiar tablicy: ");
                int n = Convert.ToInt32(Console.ReadLine());
                double[] tab = new double[n];
                for (int i = 0; i < tab.Length; i++)
                {
                    Console.Write("Podaj liczbę nr."+(i+1)+" : ");
                    tab[i] = Convert.ToDouble(Console.ReadLine());
                }
                max = tab[0];
                min = tab[0];
                for (int i = 0; i < tab.Length; i++)
                {
                    if (tab[i] > max)
                        max = tab[i];
                    if (tab[i] < min)
                        min = tab[i];
                    sr += tab[i];
                    if (tab[i] > 0)
                        dod++;
                }
                for (int i = 0; i < tab.Length; i++)
                {
                    if(tab[i]==max)
                        Console.WriteLine("Największy element tablicy to: " + max + " w " + i);
                    if (tab[i] == min)
                        Console.WriteLine("Najmniejszy element tablicy to: " + min + " w " + i);
                }
                Console.WriteLine("Średnia elementów w tablicy wynosi: " + (sr / tab.Length));
                Console.WriteLine("Liczba dodatnych elementów w tablicy wynośi: " + dod);
            }
            static bool zadanie4_4czypierwsza(int a)//funkcja pomocnicza do zadania 4.4, sprawdza ona czy podana liczba jest liczbą pierwszą
            {
                if (a < 2)
                    return false;
                for(int i=2;i*i<=a;i++)
                {
                    if (a % i == 0)
                        return false;
                }
                return true;
            }
            static void zadanie4_4()
            {
                Console.WriteLine("Zadanie 4.4");
                Console.WriteLine("Program generuje 100 liczb pseudolosowych i podaje ile z tych liczb jest liczbami pierwszymi.");
                Random rand = new Random();
                int[] tab = new int[100];
                int a=0;
                for (int i = 0; i < tab.Length; i++)
                {
                    tab[i] = rand.Next(1,1000);
                }
                for (int i = 0; i < tab.Length; i++)
                {
                    if (zadanie4_4czypierwsza(tab[i]))
                        a++;
                }
                Console.WriteLine(a + "/100 liczb jest liczbami pierwszymi.");
            }
            static void zadanie4_5()
            {
                int n=0;
                Random rand = new Random();
                Console.WriteLine("Zadanie 4.5");
                Console.WriteLine("Aby wybrać swój rozmiar tablicy wybierz - 1\nAby rozmiar tablicy był losowy w zakresie 5 do 20 wybierz - 2");
                int wyb = Convert.ToInt32(Console.ReadLine());
                switch(wyb)
                {
                    case 1:
                        Console.Write("Podaj rozmiar tablicy: ");
                        n = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 2:
                        n = rand.Next(5, 20);
                        Console.WriteLine("Rozmiar tablicy = " + n);
                        break;
                    default:
                        Console.WriteLine("Nie ma takiej opcji.");
                        break;
                }
                if (wyb == 1 || wyb == 2)
                {
                    int[] tab1 = new int[n];
                    int[] tab2 = new int[n];
                    for (int i = 0; i < tab1.Length; i++)
                    {
                        tab1[i] = rand.Next(1, 100);
                    }
                    for (int i = 0; i < tab1.Length; i++) 
                    {
                        if (i+1 < tab2.Length)
                            tab2[i + 1] = tab1[i];
                        else
                            tab2[0] = tab1[i];
                    }
                    Console.WriteLine("Tablica 1:");
                    for (int i = 0; i < tab1.Length; i++)
                    {
                        Console.Write("{0,8}", tab1[i]);
                    }
                    Console.WriteLine();
                    Console.WriteLine("Tablica 2:");                  
                    for (int i = 0; i < tab2.Length; i++)
                    {
                        Console.Write("{0,8}", tab2[i]);
                    }
                }
                Console.WriteLine();
            }
            static void zadanie4_6()
            {
                Console.WriteLine("Zadanie 4.6\nTablica dwuwymiarowa:");
                double przek = 0;
                double[,] tab = new double[5, 5];
                Random rand = new Random();
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        tab[i, j] = rand.Next(-100, 100);
                    }
                }
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
                Console.WriteLine("Suma elementów głównej przekątnej tej tablicy wynosi: "+przek);
            }
            static void zadanie4_7()
            {
                Console.WriteLine("Zadanie 4.7");
                int[,] tab1 = new int[2, 3];
                int[,] tab2 = new int[2, 3];
                int[,] tab3 = new int[2, 3];
                Random rand = new Random();
                for(int i=0;i<2;i++)
                {
                    for(int j=0;j<3;j++)
                    {
                        tab1[i, j] = rand.Next(-50, 50);
                        tab2[i, j] = rand.Next(-50, 50);
                        tab3[i, j] = tab1[i, j] + tab2[i, j];
                    }
                }
                Console.WriteLine("Macierz A:");
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(tab1[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Macierz B:");
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(tab2[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Macierz C:");
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(tab3[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            static void zadanie4_8()
            {
                Console.WriteLine("Zadanie 4.8");
                string[,] dniTygodnia;
                dniTygodnia = new string[7, 3]; 
                dniTygodnia[0, 0] = "poniedzialek";
                dniTygodnia[1, 0] = "wtorek";
                dniTygodnia[2, 0] = "środa";
                dniTygodnia[3, 0] = "czwartek";
                dniTygodnia[4, 0] = "piątek";
                dniTygodnia[5, 0] = "sobota";
                dniTygodnia[6, 0] = "niedziela";
                dniTygodnia[0, 1] = "monday";
                dniTygodnia[1, 1] = "tuesday";
                dniTygodnia[2, 1] = "wednesday";
                dniTygodnia[3, 1] = "thursday";
                dniTygodnia[4, 1] = "friday";
                dniTygodnia[5, 1] = "saturday";
                dniTygodnia[6, 1] = "sunday";
                dniTygodnia[0, 2] = "montag";
                dniTygodnia[1, 2] = "dienstag";
                dniTygodnia[2, 2] = "mittwoch";
                dniTygodnia[3, 2] = "donnerstag";
                dniTygodnia[4, 2] = "freitag";
                dniTygodnia[5, 2] = "samstag";
                dniTygodnia[6, 2] = "sonntag";
                for (int i = 0; i < 7; i++) 
                {
                    Console.WriteLine(dniTygodnia[i, 0] + " " + dniTygodnia[i, 1] + " " + dniTygodnia[i, 2]);
                }
            }
            static void zadanie4_9()
            {
                Console.WriteLine("Zadanie 4.9");
                int licz = 1;
                Console.WriteLine("Podaj tekst, a program policzy z ilu wyrazów się składa.");
                string txt = Console.ReadLine();
                if(txt.Length<1)
                    Console.WriteLine("Ten tekst składa się z 0 wyrazów.");
                else
                {
                    for (int i = 0; i < txt.Length; i++)
                    {
                        if (txt[i] == ' ')
                            licz++;
                    }
                    Console.WriteLine("Ten tekst składa się z " + licz + " wyrazów.");
                }
            }
            static void zadanie4_10()
            {
                Console.WriteLine("Zadanie 4.10\nPodaj datę w formacie DD-MM-RRRR, a program wyświetli nazwę miesiąca.");
                string m="x";
                string txt = Console.ReadLine();
                for (int i = txt.IndexOf("-"); i < txt.LastIndexOf("-"); i++)
                {

                    m = Convert.ToString(txt[i + 1] +""+ txt[i + 2]);
                        break;
                }           
                switch(m)
                {
                    case "01":
                        Console.WriteLine("Styczeń");
                        break;
                    case "02":
                        Console.WriteLine("Luty");
                        break;
                    case "03":
                        Console.WriteLine("Marzec");
                        break;
                    case "04":
                        Console.WriteLine("Kwiecień");
                        break;
                    case "05":
                        Console.WriteLine("Maj");
                        break;
                    case "06":
                        Console.WriteLine("Czerwiec");
                        break;
                    case "07":
                        Console.WriteLine("Lipiec");
                        break;
                    case "08":
                        Console.WriteLine("Sierpień");
                        break;
                    case "09":
                        Console.WriteLine("Wrzesień");
                        break;
                    case "10":
                        Console.WriteLine("Październik");
                        break;
                    case "11":
                        Console.WriteLine("Listopad");
                        break;
                    case "12":
                        Console.WriteLine("Grudzień");
                        break;
                    default:
                        Console.WriteLine("Coś poszło nie tak...");
                        break;
                }
            }
            /*
            static void zadanie4_11()//nie wiedziałem jak do dokończyć
            {
                int l = 0;
                Console.WriteLine("Zadanie 4.10\nPodaj tekst, a program wypisze ile razy pojawiają się powtórzenia liter.");
                string txt = Console.ReadLine();
                for(int i=0;i<txt.Length;i++)
                {
                    for(int j=i;j<txt.Length;j++)
                    {
                        for(int k=0;k<j;k++)
                        {
                            if (txt[k]==txt[j])
                                break;
                            else
                            {
                                if (txt[i] == txt[j])
                                    l++;
                            }
                        }
                    }
                    Console.WriteLine(txt[i] + " - " + l);
                    l = 0;
                }
            }
            */ 
            zadanie4_1();
            zadanie4_2();
            zadanie4_3();
            zadanie4_4();
            zadanie4_5();
            zadanie4_6();
            zadanie4_7();
            zadanie4_8();
            zadanie4_9();
            zadanie4_10();
            //zadanie4_11();
        }
    }
}
