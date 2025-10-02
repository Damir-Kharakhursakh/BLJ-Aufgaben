namespace Aufgabe_16;

class Program
{
    static void Main(string[] args)
    {
        bool neuStart = true;
        while (neuStart == true)
        {
            neuStart = false;
            int randomNumber;
            Random rnd = new Random();
            randomNumber = rnd.Next(1, 101);
            Console.WriteLine(randomNumber);
        
            Console.WriteLine("Raten Sie die Zahl von 1 bis 100");
            int whileEnd = -1;
            int versuche = 0;

            while (whileEnd != randomNumber)
            {
                versuche++;
                Console.WriteLine("Geben Sie die Zahl von 1 bis 100 ein: ");
                string userNumber = Console.ReadLine();
                int intUserNumber = Convert.ToInt32(userNumber);

                if (intUserNumber == randomNumber)
                {
                    Console.WriteLine("Du hast die Zahl erraten! Du hast total " + versuche + " Versuch/e gebraucht. " + "Die Zahl war: " + randomNumber);
                    bool y = false;
                    
                    while (y == false)
                    {
                        Console.WriteLine("Wollen Sie noch ein Mal spielen? [y/n]");
                        string input = Console.ReadLine();
                        if (input == "y")
                        {
                            Console.WriteLine("Sie haben das Spiel neugestartet. ");
                            whileEnd = randomNumber;
                            y = true;
                            neuStart = true;
                        } 
                        else if (input == "n")
                        {
                            Console.WriteLine("Danke, dass Sie das Spiel ausprobiert haben! ");
                            whileEnd = randomNumber;
                            y = true;
                            neuStart = false;
                        }
                        else
                        {
                            Console.WriteLine("Eingabefehler");
                            y =  false;
                        }
                    }
                }
                else if  (intUserNumber > randomNumber)
                {
                    Console.WriteLine("Korrekte Zahl ist kleiner! ");
                } 
                else if (intUserNumber < randomNumber)
                {
                    Console.WriteLine("Korrekte Zahl ist grösser! ");
                }
            }
        }
        
    }
}