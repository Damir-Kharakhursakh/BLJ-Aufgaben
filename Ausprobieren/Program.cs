using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bitte gib ein Geburtsdatum ein (TT.MM.JJJJ): ");
        Console.WriteLine(" ");
        string input = Console.ReadLine();

        if (DateTime.TryParseExact(input, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime geburtsdatum))
        {
            DateTime heute = DateTime.Today;
            
            if (geburtsdatum > heute)
            {
                Console.WriteLine("Das Geburtsdatum liegt in der Zukunft!");
                return;
            }

            // Alter in Jahren berechnen
            int jahre = heute.Year - geburtsdatum.Year;
            if (heute.Month < geburtsdatum.Month || (heute.Month == geburtsdatum.Month && heute.Day < geburtsdatum.Day))
            {
                jahre--;
            }

            // Alter in Monaten berechnen
            int monate = jahre * 12 + (heute.Month - geburtsdatum.Month);
            if (heute.Day < geburtsdatum.Day)
            {
                monate--;
            }

            // Alter in Tagen berechnen
            TimeSpan differenz = heute - geburtsdatum;
            int tage = (int)differenz.TotalDays;

            // Alter in Wochen berechnen
            int wochen = tage / 7;

            // Ausgabe
            Console.WriteLine($"Alter in Jahren: {jahre}");
            Console.WriteLine($"Alter in Monaten: {monate}");
            Console.WriteLine($"Alter in Wochen: {wochen}");
            Console.WriteLine($"Alter in Tagen: {tage}");
        }
        else
        {
            Console.WriteLine("Ungültiges Datum. Bitte im Format TT.MM.JJJJ eingeben.");
        }
    }
}