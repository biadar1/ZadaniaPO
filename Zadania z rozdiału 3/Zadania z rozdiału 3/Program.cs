using System;

namespace Zadania_z_rozdiału_3
{
    class Program
    {
        static void Main(string[] args)
        {
            void zadanie3_1()
            {
                Console.WriteLine("Zadanie 3.1");
                int rok;
                Console.WriteLine("Podaj rok, a program sprawdzi czy ten rok jest przestępny.");
                rok = Convert.ToInt32(Console.ReadLine());
                if (rok % 4 == 0 & rok % 100 != 0 || rok % 400 == 0)
                { Console.WriteLine("Rok " + rok + " jest przestępny."); }
                else
                { Console.WriteLine("Rok " + rok + " jest nie przestępny."); }
            }
            void zadanie3_2()
            {
                Console.WriteLine("Zadanie 3.2");
                int a, b;
                Console.WriteLine("Podaj 2 liczby, a program sprawdzi czy druga liczba jest dzielnikiem pierwszej.");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                if (b == 0)
                    Console.WriteLine("Nie można dzielić przez 0.");
                else
                {
                    if (a % b == 0)
                    { Console.WriteLine("Liczba " + b + " jest dzielnikiem liczby " + a); }
                    else
                    { Console.WriteLine("Liczba " + b + " nie jest dzielnikiem liczby " + a); }
                }
            }
            void zadanie3_3()
            {
                Console.WriteLine("Zadanie 3.3");
                int b = 0;
                int n = 3;//ile liczb sprawdzamy
                Console.WriteLine("Podaj " + n + " liczby, a program zwróci największą z nich.");
                for (int i = 0; i < n; i++)
                {
                    int a = Convert.ToInt32(Console.ReadLine());
                    if (a > b)
                    { b = a; };
                }
                Console.WriteLine("Największa podana liczba to: " + b);
            }
            void zadanie3_4()
            {
                Console.WriteLine("Zadanie 3.4");
                string i;
                int p = 1;
                double a, b;
                Console.WriteLine("Podaj 2 liczby które chcesz policzyć.");
                a = Convert.ToDouble(Console.ReadLine());
                b = Convert.ToDouble(Console.ReadLine());
                while (p == 1)
                {
                    Console.WriteLine("Wybierz działanie matematyczne.\n + -> Ddodawanie \n - -> Odejmowanie \n * -> Mnożenie \n / -> Dzielenie");
                    i = Console.ReadLine();
                    switch (i)
                    {
                        case "+":
                            Console.WriteLine("Wynikiem dodawania twoich liczb jest: " + a + " + " + b + " = " + (a + b));
                            p = 0;
                            break;
                        case "-":
                            Console.WriteLine("Wynikiem odejmowania twoich liczb jest: " + a + " - " + b + " = " + (a - b));
                            p = 0;
                            break;
                        case "*":
                            Console.WriteLine("Wynikiem mnożenia twoich liczb jest: " + a + " * " + b + " = " + (a * b));
                            p = 0;
                            break;
                        case "/":
                            if (b == 0)
                            { Console.WriteLine("Nie można dzielić przez 0."); break; }
                            Console.WriteLine("Wynikiem dzielenia twoich liczb jest: " + a + " / " + b + " = " + (a / b));
                            p = 0;
                            break;
                        default:
                            Console.WriteLine("Wprowadzono niepoprawne działanie.");
                            p = 1;
                            break;
                    }
                }
            }
            void zadanie3_5()
            {
                Console.WriteLine("Zadanie 3.5");
                double a, b, c, delta;
                Console.WriteLine("Podaj współczynniki a,b,c ,a program zwróci pierwiastki równania kwadratowego na tych współczynnikach.");
                a = Convert.ToDouble(Console.ReadLine());
                b = Convert.ToDouble(Console.ReadLine());
                c = Convert.ToDouble(Console.ReadLine());
                delta = b * b - 4 * a * c;
                if (delta < 0)
                    Console.WriteLine("Delta ujemna, brak rozwiązań.");
                if (delta == 0)
                    Console.WriteLine("Delta równa 0, jedno rozwiązanie: " + (-b / 2 * a));
                if (delta > 0)
                    Console.WriteLine("Delta większa od 0, dwa rozwiązania: " + (-b - Math.Sqrt(delta) / 2 * a) + " oraz " + (-b + Math.Sqrt(delta) / 2 * a));
            }
            void zadanie3_6()
            {
                Console.WriteLine("Zadanie 3.6");
                double waga, wzrost, bmi;
                Console.WriteLine("Podaj wagę i wzrost, a program obliczy towje BMI.");
                Console.WriteLine("Podaj wagę w kilogramach.");
                waga = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Podaj wzrost w metrach.");
                wzrost = Convert.ToDouble(Console.ReadLine());
                bmi = waga / (wzrost * wzrost);
                Console.WriteLine("Twoje BMI wynosi: " + bmi);
                if (bmi < 18.5)
                    Console.WriteLine("Niedowaga.");
                if (bmi > 18.5 & bmi < 24.99)
                    Console.WriteLine("Wartość BMI prawidłowa.");
                if (bmi >= 25)
                    Console.WriteLine("Nadwaga.");
            }
            void zadanie3_7()
            {
                Console.WriteLine("Zadanie 3.7");
                Console.WriteLine("Wpisz numer dnia tygodnia");
                int numer = Convert.ToInt32(Console.ReadLine());
                switch (numer)
                {
                    case 1:
                        Console.WriteLine("Poniedziałek");
                        break;
                    case 2:
                        Console.WriteLine("Wtorek");
                        break;
                    case 3:
                        Console.WriteLine("Środa");
                        break;
                    case 4:
                        Console.WriteLine("Czwartek");
                        break;
                    case 5:
                        Console.WriteLine("Piątek");
                        break;
                    case 6:
                        Console.WriteLine("Sobota");
                        break;
                    case 7:
                        Console.WriteLine("Niedziela");
                        break;
                    default:
                        Console.WriteLine("Nie ma takiego dnia tygodnia");
                        break;
                }
            }
            void zadanie3_8()
            {
                Console.WriteLine("Zadanie 3.8");
                double srocen;
                Console.WriteLine("Podaj średnią ocen, a program wyświetli informację o wysokości przysługującego stypendium.");
                srocen = Convert.ToDouble(Console.ReadLine());
                if (srocen >= 2 & srocen <= 3.99)
                    Console.WriteLine("Kwota twojego stypendium wynosi: 0,00 zł");
                if (srocen >= 4 & srocen <= 4.79)
                    Console.WriteLine("Kwota twojego stypendium wynosi: 350,00 zł");
                if (srocen >= 4.80 & srocen <= 5)
                    Console.WriteLine("Kwota twojego stypendium wynosi: 550,00 zł");
                else
                    Console.WriteLine("Niewłaściwa średnia ocen.");
            }
            void zadanie3_9()
            {
                Console.WriteLine("Zadanie 3.9");
                string i;
                int n,p=1;
                Console.WriteLine("Wybierz wariant zadania: a,b,c lub d.");
                i = Console.ReadLine();
                Console.WriteLine("Wybierz ile program ma wyświetlić wierszy danego wariantu.");
                n = Convert.ToInt32(Console.ReadLine());
                switch(i)
                {
                    case "a":
                        for(int x=0;x<n;x++)
                        {
                            for(int y=0;y<p;y++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                            p++;
                        }
                        break;
                    case "b":
                        p = n;
                        for (int x = 0; x < n; x++)
                        {
                            for (int y = 0; y < p; y++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                            p--;
                        }
                        break;
                    case "c":
                        int l = 1;
                        p = n;
                        for (int x = 0; x < n; x++)
                        {
                            Console.Write("    ");
                            for (int y = 0; y < p; y++)
                            {                               
                                Console.Write(" ");
                            }
                            for(int z=0;z<l;z++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                            p--;
                            l++;
                        }
                        break;
                    case "d":
                        for (int x = 0; x < n; x++)
                        {
                            if (x % 3 == 0)
                                Console.WriteLine("****");
                            else
                                Console.WriteLine("*  *");
                        }
                        break;
                    default:
                        Console.WriteLine("Nie ma takiego wariantu tego zadania.");
                        break;
                }
            }
            void zadanie3_10()
            {
                Console.WriteLine("Zadanie 3.10");
                int n, silnia=1;
                Console.WriteLine("Podaj liczbę, a program wyświetli wynik silni tej liczby.");
                n = Convert.ToInt32(Console.ReadLine());
                for (int i = n; i > 1; i--)
                {
                    silnia *= i;
                }
                Console.WriteLine("Silnia twojej liczby wynosi: " + silnia);

            }        
            void zadanie3_11()
            {
                Console.WriteLine("Zadanie 3.11");
                Console.WriteLine("Program liczy ile liczb całkowitych, zaczynająć od 1, trzeba aby ich suma przekraczała 100.");
                int a = 1, suma=0;
                while (suma < 100)
                {
                    suma += a;
                    a++;
                    Console.WriteLine("Suma=" + suma);
                }
                Console.WriteLine("Potrzeba " + (a-1) + " (nie licząc liczby 1) kolejnych liczb całkowitych aby przekroczyć wartość 100.");
            }
            void zadanie3_12()
            {
                Console.WriteLine("Zadanie 3.12");
                int n=1, suma=0;
                Console.WriteLine("Podaj liczby całkowite do zsumowania, aby zakączyć wprowadzanie podaj liczbę 0.");
                while (n != 0)
                {
                    n = Convert.ToInt32(Console.ReadLine());
                    suma += n;
                }
                Console.WriteLine("Suma twoich liczb wynosi: " + suma);
            }
            void zadanie3_13()
            {
                Console.WriteLine("Zadanie 3.13");
                int n;
                double i = 1, sumaW = 0;
                Console.WriteLine("Podaj liczbę n, a program obliczy W(n).");
                n = Convert.ToInt32(Console.ReadLine());
                while(i<n+1)
                {
                    if (i % 2 == 0)
                        sumaW -= i;
                    else
                        sumaW +=i;
                    i++;
                }
                Console.WriteLine("W(n) = " + sumaW);
            }
            void zadanie3_14()
            {
                Console.WriteLine("Zadanie 3.14");
                int n;
                Console.WriteLine("Podaj liczbę n, a program znajdzie wszystkie liczby doskonałe w przedziale od 1 do n.");
                n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Liczby doskonałe w przedziale od 1 do " + n + " to:");
                for (int i = 2, d = 0; i <= n; i++) //zaczynamy od liczby 2, ponieważ najniższa liczba doskonała to 6 (i jest po prostu wygodniej)
                {
                    for(int j=1;j<i;j++)//sprawdzamy dzielniki zaczynając od 1, bo przez 0 nie można dzielić
                    {
                        if (i % j == 0)
                            d += j;                    
                    }
                    if (d == i)
                        Console.WriteLine(i);
                    d = 0;
                }
               
            }
            void zadanie3_15()
            {
                Console.WriteLine("Na zadanie 15 nie miałem dobrego pomysłu.");
            }
            //przy każdym zadaniu można dodać syntax komentarza, aby sprawdzić pojedyńcze zadania
            zadanie3_1();
            zadanie3_2();
            zadanie3_3();
            zadanie3_4();
            zadanie3_5();
            zadanie3_6();
            zadanie3_7();
            zadanie3_8();
            zadanie3_9();
            zadanie3_10();
            zadanie3_11();
            zadanie3_12();
            zadanie3_13();
            zadanie3_14();
            zadanie3_15();

        }
    }
}
