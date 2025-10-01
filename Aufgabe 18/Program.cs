namespace Aufgabe_18;

class Program
{
    static void Main(string[] args)
    {
        string[] forbiddenWords = { "a", "e", "i","o", "u", "ä", "ö", "ü", "A", "E", "O", "U", "Ä", "Ö", "Ü",};
        Console.WriteLine("Deine Eingabe: ");
        Console.WriteLine(" ");
        string kommentar = Console.ReadLine();
        string finalKommentar = kommentar.ToLower();
        int numberWords = 0;
        
        foreach (string buchstabe in forbiddenWords)
        {
            if (finalKommentar.Contains(buchstabe))
            {
                Console.WriteLine(buchstabe);
                numberWords++;
            }
            else
            {
                numberWords++;
            }
        }

        if (numberWords > 0)
        {
            Console.WriteLine("Dein Kommentar enthält " + numberWords + " Vokale" );
            Console.WriteLine("Es wird nicht veröffentlicht.");
        }
        else
        {
            Console.WriteLine("Vielen Dank für deinen Kommentar.");
        }
    }
}