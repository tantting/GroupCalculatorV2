namespace GroupCalculatorV2
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

                Console.WriteLine("\nVälj din uträkningsmetod");
                Console.WriteLine("[1] Addera");
                Console.WriteLine("[2] Subtrahera");
                Console.WriteLine("[3] Multiplicera");
                Console.WriteLine("[4] Dividera");
                Console.WriteLine("[5] Avsluta programmet");

                int userInput;
                while (!Int32.TryParse(Console.ReadLine(), out userInput))
                {
                    Console.WriteLine("Felaktig input! Försök igen!");
                }

                int num1 = 0;
                int num2 = 0;

                if (userInput != 5)
                {
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
                }
                

                switch (userInput)
                {
                    case 1:

                        Console.WriteLine($"Ditt svar blev: {Add(num1, num2)}/n/nTryck valfri tangent för att komma vidare");
                        Console.ReadKey();
                        break;

                    case 2:
                        
                        Console.WriteLine($"Ditt svar blev: {Subtract(num1, num2)}/n/nTryck valfri tangent för att komma vidare");
                        Console.ReadKey();
                        break;
                        
                    case 3:
                        
                        Console.WriteLine($"Ditt svar blev: {Multiply(num1, num2)}/n/nTryck valfri tangent för att komma vidare");
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.WriteLine($"Ditt svar blev: {Division(num1, num2)}/n/nTryck valfri tangent för att komma vidare");
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
        static double Multiply(int x, int y)
        {
            double sum = x * y;
            return sum;
        }

        static float Division(int num1, int num2)
        {
            float quota = (float) (num1 / num2);
            return quota; 
        }
    }
}

