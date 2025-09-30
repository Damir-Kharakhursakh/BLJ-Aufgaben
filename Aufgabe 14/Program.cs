namespace Aufgabe_14;

class Program
{
    static void Main(string[] args)
    {
        bool keypressed = false;

        while (keypressed == false)
        {
            string input;

            Console.WriteLine("Geben Sie das Jahr ein: (q + enter to Quit)");
            Console.WriteLine(" ");
            input = Console.ReadLine();
            
            if (input == "q")
            {
                keypressed = true; 
                Console.WriteLine("You pressed q which stopped the programm");
            }
            else
            {
                int userJahr = Convert.ToInt32(input);
                if (userJahr % 4 == 0)
                {
                    Console.WriteLine("Es ist ein Schaltjahr.");
                }
                else
                {
                    Console.WriteLine("Es ist KEIN Schaltjahr.");
                }
            }
        }
    }
}