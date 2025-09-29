namespace Aufgabe_8;

class Program
{
    static void Main(string[] args)
    {
        string[] forbiddenWords = { "viagra", "sex", "porno", "fick", "schlampe", "arsch", "neger", "negger", "huereson", "huere son" };
        Console.WriteLine("Dein Kommentar: ");
        Console.WriteLine(" ");
        string kommentar = Console.ReadLine();
        string finalKommentar = kommentar.ToLower();
        int numberWords = 0;
        
        foreach (string wort in forbiddenWords)
        {
            if (finalKommentar.Contains(wort))
            {
                Console.WriteLine(wort);
                numberWords++;
            }
        }

        if (numberWords > 0)
        {
            Console.WriteLine("Dein Kommentar enthält " + numberWords + " verbotene Wörter" );
            Console.WriteLine("Es wird nicht veröffentlicht.");
        }
        else
        {
            Console.WriteLine("Vielen Dank für deinen Kommentar.");
        }
    }
}