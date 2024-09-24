﻿namespace GroupCalculatorV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool myBool = true;

            while (myBool)
            {

                Console.Clear();
                Console.WriteLine("Hej");
                Console.WriteLine("Välkommen till miniräknaren!");

                int num1;
                int num2;

                Console.WriteLine("Ange ett heltal");
                while (!Int32.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("Felaktig input!\n\nAnge ett heltal");
                }
                Console.WriteLine($"Ange ytterligare ett heltal");
                while (!Int32.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("Felaktig input!\n\nAnge ett heltal");
                }
                
                Console.WriteLine("\nVälj din uträkningsmetod");
                Console.WriteLine("[1] Addera");
                Console.WriteLine("[2] Subtrahera");
                Console.WriteLine("[3] Multiplicera");
                Console.WriteLine("[4] Dividera");
                Console.WriteLine("[5] Avsluta programmet");

                int userInput = Convert.ToInt32(Console.ReadLine());
                switch (userInput)
                {
                    case 1:

                        Console.WriteLine($"Ditt svar blev: {Add(num1, num2)}");
                        Console.ReadKey();
                        break;

                    case 2:
                        
                        Console.WriteLine($"Ditt svar blev: {Subtract(num1, num2)}");
                        Console.ReadKey();
                        
                        break;
                    case 3:
                        //Metod för multiplikation

                        break;

                    case 4:
                        float quota = Division(num1, num2);
                        Console.WriteLine($"{num1} / {num2} = {quota}");
                        Console.ReadKey();
                        break;

                    case 5:
                        Console.WriteLine("Tack för besöket, välkommen åter!");
                        myBool = false;
                        break;
                }

            }

        }

        static float Add(int no1, int no2)
        {

            float sum = no1 + no2;
            return sum;
           

        }

        static float Subtract(int num1, int num2)
        { 
            return num1 - num2; 
        }

        static float Division(int num1, int num2)
        {
            float quota = (float) (num1 / num2);
            return quota;
        }
    }
}

