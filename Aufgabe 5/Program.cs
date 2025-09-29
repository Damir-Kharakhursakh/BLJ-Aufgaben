namespace Aufgabe_5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Wie viele Kilometer möchtest du rennen? ");
        Console.WriteLine(" ");
        bool validBis42 = true;
        bool valid = false;
        bool bereit = false;
        while (valid == false)
        {
            string anzahlKm = Console.ReadLine();
            int validator = 0;
            
            if (int.TryParse(anzahlKm, out validator) == true)
            {
                Console.WriteLine("Sie haben eine Zahl eingegeben");
                validBis42 = false;
            }
            else
            {
                Console.WriteLine("Eingabefehler. Bitte geben Sie eine Zahl ein.");
            }
            
            while (validBis42 == false)
            {
                int convertedInt = Convert.ToInt32(anzahlKm);
                
                if (42 < convertedInt)
                {
                    Console.WriteLine("Bro, du schaffst das nicht!");
                    validBis42 = true;
                }

                if (0 >= convertedInt)
                {
                    Console.WriteLine("Bro, es ist viel zu wenig!");
                    validBis42 = true;
                }

                if (0 < convertedInt && convertedInt < 43)
                {
                    double anzahlRunden = (double)convertedInt * 1000.00 / 400.00;
                    Console.WriteLine($"Super! Jetzt muss du " + (double)convertedInt * 1000.00 / 400.00 + " Runden rennen!");
                    validBis42 = true;
                    Console.WriteLine("Bist du beret? y / n");
                    string parat =  Console.ReadLine();
                    if (parat == "y")
                    {
                        Console.WriteLine("Super!");
                        bereit = true;
                        while (bereit == true)
                        {
                            for (int i = 1; i <= anzahlRunden; i++)
                            {
                                Console.WriteLine("Du rennst die Runde " + i + "!");
                            }
                            Console.WriteLine("Du hast es geschafft!");
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Schade, dass du so ein Angsthase bist");
                        return;
                    }
                }
            }

            
        }
    }
}