namespace Aufgabe2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Dieses Programm berechnet die Anzahl Sekunden eines Monats. Geben Sie, bitte, ein, wie viele Tage ihr Monat hat: ");
        Console.WriteLine(" ");
        bool validZwischen2831 = true;
        bool valid = false;
        while (valid == false)
        {
            string anzahlTage = Console.ReadLine();
            int validator = 0;
            
            if (int.TryParse(anzahlTage, out validator) == true)
            {
                Console.WriteLine("Sie haben eine Zahl eingegeben");
                validZwischen2831 = false;
            }
            else
            {
                Console.WriteLine("Eingabefehler. Bitte geben Sie eine Zahl ein.");
            }
            
            while (validZwischen2831 == false)
            {
                int intAnzahlTage = Convert.ToInt32(anzahlTage);
                
                if (27 >= intAnzahlTage || intAnzahlTage >= 32)
                {
                    Console.WriteLine("Eingabefehler. Bitte geben Sie eine Zahl zwischen 28 und 31 ein.");
                    validZwischen2831 = true;
                }
                else
                {
                    Console.WriteLine($"Die Anzahl Sekunden ist: {intAnzahlTage * 24 * 60 * 60}");
                    return;
                }
            }
        }
    }
}