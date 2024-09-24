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

                int num1 = 0;
                int num2 = 0;

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
                        //Metod för addition
                        break;

                    case 2:
                        //Metod för subtraktion
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
    }
}
