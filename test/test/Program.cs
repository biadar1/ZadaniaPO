using System;

namespace test
{
    class zadania
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Zadanie 2.1");
             double celc,far;
             celc = Convert.ToDouble(Console.ReadLine());
             far = celc*9/5+32;
             Console.WriteLine(far);

             Console.WriteLine("Zadanie 2.2");
             double a, b, c, delta;
             Console.WriteLine("Podaj A");
             a = Convert.ToDouble(Console.ReadLine());
             Console.WriteLine("Podaj B");
             b = Convert.ToDouble(Console.ReadLine());
             Console.WriteLine("Podaj C");
             c = Convert.ToDouble(Console.ReadLine());
             delta=b*b-4*a*c;
             Console.WriteLine("Delta wynosi " + delta);        

             Console.WriteLine("Zadanie 2.3");
             double m, w, bmi;
             Console.WriteLine("Podaj swoją masę w kilogramach");
             m = Convert.ToDouble(Console.ReadLine());
             Console.WriteLine("Podaj swój wzrost w METRACH");
             w = Convert.ToDouble(Console.ReadLine());
             bmi = m / ( w * w );
             Console.WriteLine("Twoje BMI wynosi: " + bmi);

            Console.WriteLine("Zadanie 2.4 odpowiedź: a");
            Console.WriteLine("Zadanie 2.5 odpowiedź: d");
            Console.WriteLine("Zadanie 2.6 odpowiedź: 3");
            Console.WriteLine("Zadanie 2.7 odpowiedź: 7");
            Console.WriteLine("Zadanie 2.8 odpowiedź: a");

        }
    }
}