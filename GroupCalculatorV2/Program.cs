namespace GroupCalculatorV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool myBool = true;

            while (myBool)
            {
                Console.WriteLine("Hej");
                Console.WriteLine("Välkommen till miniräknaren!");
                Console.WriteLine("\nVälj din uträkningsmetod");
                Console.WriteLine("[1] Addera");
                Console.WriteLine("[2] Subtrahera");
                Console.WriteLine("[3] Multiplicera");
                Console.WriteLine("[4] Dividera");
                Console.WriteLine("[5] Avsluta programmet");

                int userInput = Convert.ToInt32(Console.ReadLine());

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

                switch (userInput)
                {
                    case 1:

                        Console.WriteLine($"Ditt svar blev: {Add(num1, num2)}");
                        break;

                    case 2:
                        Subtract(num1, num2);
                        break;
                    case 3:
                        //Metod för multiplikation

                        break;

                    case 4:
                        //Metod för division
                        break;

                    case 5:
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
    }
}

