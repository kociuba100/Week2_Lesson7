namespace Week2_Lesson7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int a = 5;
            int b = 5;
            if(a==b)
            {
                Console.WriteLine("zminne 5 i 5 sa równe");
            }
            else
            {
                Console.WriteLine(  "zmienne nie sa równe");
            }
            */

            /*string Number;
            int OutNumber;
            Console.WriteLine("podaj liczbę");
            Number = Console.ReadLine();
            Int32.TryParse(Number, out OutNumber);

            if(OutNumber % 2 == 0)
            {
                Console.WriteLine("Podana liczba jest parzysta");
            }
            else
            {
                Console.WriteLine("podana liczba jest nieparzytsa");
            }
            */

            /*string Number;
            Console.WriteLine("Podaj liczbę całkowitą...");
            Number = Console.ReadLine();
            double OutNumber;
            Double.TryParse(Number, out OutNumber);
            if(OutNumber>0  )
            {
                Console.WriteLine("podana lliczba jest dodatnia");
            }
            else
            {
                Console.WriteLine("podana liczba jest ujemna");
            }
            */

            /*string Age;
            Console.WriteLine("podaj swójwiek");
            Age = Console.ReadLine();
            int OutAge;
            int.TryParse(Age, out OutAge);
            if(OutAge>=21)
            {
                Console.WriteLine("Twóf wiek uprawni, aby być psłem, senatorem, prezydentem");
            }
            else
            {
                Console.WriteLine("jestes za młody");
            }
            */
            /*
            string Heigh;
            Console.WriteLine("Podaj swój wzrost");
            Heigh = Console.ReadLine();
            int OutHeigh;
            int.TryParse(Heigh, out OutHeigh);
            if(OutHeigh>140)
            {
                Console.WriteLine("jesteś ponad hobbitem");
            }
            else
            {
                Console.WriteLine("jestes krasnoludem");
            }
            */

            string Number1, Number2, Number3;
            Console.WriteLine("podaj 3 cyfry"); ;
            Number1 = Console.ReadLine();
            Number2 = Console.ReadLine();
            Number3 = Console.ReadLine();

            int OutNumber1, OutNumber2, OutNumber3;
            int.TryParse(Number1, out OutNumber1);
            int.TryParse(Number2, out OutNumber2);
            int.TryParse(Number3, out OutNumber3);

            if((OutNumber1==OutNumber2) && (OutNumber1==OutNumber3))
            {
                Console.WriteLine("wszystkie cyfry sa jednakowe");
            }
            else
            {
                if((OutNumber1>OutNumber2) && (OutNumber1>OutNumber3))
                {
                    Console.WriteLine($"cyfra pierwsza { OutNumber1 }jest największa");
                }
                else
                {
                    if((OutNumber2>OutNumber1)&&(OutNumber2>OutNumber3))
                    {
                        Console.WriteLine($"cyfra druga {OutNumber2} jest największa");

                    }
                    else
                    {
                        Console.WriteLine($"cyfra trzecia {OutNumber3} jest najwieksza");
                    }
                }
            }


            Console.WriteLine("Hello, World!");
        }
    }
}