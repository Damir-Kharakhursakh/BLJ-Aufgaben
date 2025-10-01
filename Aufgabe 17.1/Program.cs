namespace Aufgabe_17._1;

class Program
{
    static void Main(string[] args)
    {
        DateTime today = DateTime.Today;
        Console.WriteLine(today);


        DateTime tomorrow = today.AddDays(1);
        Console.WriteLine(tomorrow);

        Console.WriteLine("Bitte gib ein Geburtsdatum ein: ");
        string eingabeString = Console.ReadLine();

        DateTime eingabeDate = DateTime.Parse(eingabeString);


        JahrenBerechnung(eingabeDate, DateTime.Today, eingabeString);

    }

    static void JahrenBerechnung(DateTime eingabeDate, DateTime today, string eingabeString)
    {

        //Today Jahr zu int konvertieren
        string todayString = today.ToString("dd.MM.yyyy");
        string[] teileToday = todayString.Split('.');
        string jahrTodayString = teileToday[2];
        int jahrTodayInt = Convert.ToInt32(jahrTodayString);
        Console.WriteLine("JahrTodayInt: " + jahrTodayInt);

        //Eingabe Jahr zu int konvertieren
        string[] teile = eingabeString.Split('.');
        string jahrString = teile[2];
        int jahrEingabeInt = Convert.ToInt32(jahrString);
        Console.WriteLine("JahrEingabeInt " + jahrEingabeInt);

        //Wie viele Tage zwischen den Daten sind
        TimeSpan interval = today - eingabeDate;
        Console.WriteLine("Tage vergangen: " + interval.Days);
        int tage = Convert.ToInt32(interval.Days);

        //Jahr berechne
        int wieVielJahre = 0;
        for (int i = jahrEingabeInt; i < jahrTodayInt; i++)
        {
            if (tage < 0)
            {
                wieVielJahre--;
            }
            else
            {
                if (jahrEingabeInt % 4 == 0)
                {
                    if (jahrEingabeInt % 100 == 0)
                    {
                        if (jahrEingabeInt % 400 == 0)
                        {
                            tage = tage - 366;
                            wieVielJahre++;
                        }
                        else
                        { 
                            tage = tage - 365;
                            wieVielJahre++;
                        }
                    }
                    else
                    { 
                        tage = tage - 366;
                        wieVielJahre++;
                    }
                }
                else
                {
                    tage = tage - 365;
                    wieVielJahre++;
                }
            }
        }
        
        Console.WriteLine("WieVielJahre: " + wieVielJahre);

        //Überprüfung von Schaltjahr 
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
                    if (jahrEingabeInt % 4 == 0)
                    {
                        if (jahrEingabeInt % 100 == 0)
                        {
                            if (jahrEingabeInt % 400 == 0)
                            {
                                Console.WriteLine("Es ist ein Schaltjahr.");
                            }
                            else
                            {
                                Console.WriteLine("Es ist KEIN Schaltjahr.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Es ist ein Schaltjahr.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("WieVieleJahre: " + wieVielJahre);
                    }
                }
            }
        }
    }
}