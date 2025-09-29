namespace Aufgabe_8._1;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Dein Kommentar: ");
        //string benutzereingabe = Console.ReadLine();
        //string[] forbiddenWords = { "viagra", "sex", "porno", "fick", "schlampe", "arsch", "neger", "negger", "huereson", "huere son" };
        //string[] eingabeSplit = kommentar.Split("");

        //foreach (string words in eingabeSplit)
        //{
        //    Console.WriteLine($"<{words}>");
        //}
        
        string[] forbiddenWords = { "viagra", "sex", "porno", "fick", "schlampe", "arsch", "neger", "negger", "huereson", "huere son" };
        Console.WriteLine("Dein Kommentar: ");
        Console.WriteLine(" ");
        string kommentar = Console.ReadLine();
        bool gefunden = false;

        foreach (string wort in forbiddenWords)
        {
            if (string.Equals(kommentar, wort, StringComparison.CurrentCultureIgnoreCase))
            {
                gefunden = true;
                break;
            }
        }
        
        if (gefunden)
        {
            Console.WriteLine($"Die Eingabe '{kommentar}' wurde im Array gefunden!");
        }
        else
        {
            Console.WriteLine($"Die Eingabe '{kommentar}' wurde nicht im Array gefunden.");
        }
    }
}