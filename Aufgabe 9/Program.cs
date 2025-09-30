namespace Aufgabe_9;

class Program
{
    static void Main(string[] args)
    {
        bool keypressed = false;

        while (keypressed == false)
        {
            string bin = (" ");
            string input;
            int userNumber;
            int rest;
            int value;

            Console.WriteLine("integer number (q + enter to Quit)");
            input = Console.ReadLine();



            if (input == "q")
            {
                keypressed = true; 
                Console.WriteLine("You pressed q which stopped the programm");
            }
            else
            {
                userNumber = Convert.ToInt32(input);
                keypressed = false;
                while (userNumber != 0)
                {
                    rest = userNumber % 2;
                    bin = rest + bin;
                    value = userNumber / 2;
                    userNumber = value;
                }

                if (userNumber == 0) ;
                {
                    Console.WriteLine(bin);
                }
            }
        }

    }
}