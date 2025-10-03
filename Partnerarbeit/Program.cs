using System;

namespace Partnerarbeit;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("*********************");
        Console.WriteLine("* Kontakte erfassen *");
        Console.WriteLine("*********************");

        int numberKontakt = 1;
        int position = 0;
        
        string[,] array = new string[2^31, 3]; 

        while (true)
        {
            Console.WriteLine("Eingabe beenden? (y/n)");
            string input = Console.ReadLine();
            if (input == "n")
            {
                Console.WriteLine(numberKontakt + ". Kontakt");
                numberKontakt++;
                Console.Write("Vorname: ");
                string vorname = Console.ReadLine();
                Console.Write("Nachname: ");
                string nachname = Console.ReadLine();
                Console.Write("E-Mail: ");
                string email = Console.ReadLine();

                array[position, 0] = vorname;
                array[position, 1] = nachname;
                array[position, 2] = email;
                position++;
                continue;
            } 
            else if (input == "y")
            {
                Console.WriteLine("Wie sollen die Kontakte ausgegeben werden? Vor- oder Nachname zuerst? (v/n)");
                string inputVorNachname = Console.ReadLine();

                if (inputVorNachname == "v")
                {
                    for (int i = 0; i < position; i++)
                    {
                        Console.WriteLine($"{array[i, 0]}\t{array[i, 1]}\t{array[i, 2]}");
                    }
                } 
                else if (inputVorNachname == "n")
                {
                    for (int i = 0; i < position; i++)
                    {
                        Console.WriteLine($"{array[i, 1]}\t{array[i, 0]}\t{array[i, 2]}");
                    }
                }
                else
                {
                    Console.WriteLine("Eingabefehler!");
                    continue;
                }
                break;
            }
            else
            {
                Console.WriteLine("Eingabefehler!");
                continue;
            }
        }
    }
}
