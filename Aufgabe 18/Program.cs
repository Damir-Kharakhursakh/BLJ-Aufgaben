namespace Aufgabe_18;

class Program
{
    static int a = 0;
    static int e = 0;
    static int i = 0;
    static int o = 0;
    static int u = 0;
    static int ä = 0;
    static int ö = 0;
    static int ü = 0;
    static int numberVokale;
    static void Main(string[] args)
    {
        string vokale = "aeiouäöüAEOUÄÖÜ";
        Console.WriteLine("Deine Eingabe: ");
        Console.WriteLine(" ");
        string kommentar = Console.ReadLine();
        string finalKommentar = kommentar.ToLower();
        int numberVokale = 0;
        
        
        VokaleFinden(finalKommentar, vokale);

        VokaleAusgeben();
    }

    static void VokaleFinden(string finalKommentar, string vokale)
    {
        foreach (char buchstabe in finalKommentar)
        {
            if (vokale.Contains(buchstabe))
            {
                if (buchstabe == 'a')
                {
                    a++;
                }
                if (buchstabe == 'e')
                {
                    e++;
                }
                if (buchstabe == 'i')
                {
                    i++;
                }
                if (buchstabe == 'o')
                {
                    o++;
                }
                if (buchstabe == 'u')
                {
                    u++;
                }
                if (buchstabe == 'ä')
                {
                    ä++;
                }
                if (buchstabe == 'ö')
                {
                    ö++;
                }
                if (buchstabe == 'ü')
                {
                    ü++;
                }
                numberVokale++;
            }
        }
    }

    static void VokaleAusgeben()
    {
        if (numberVokale > 0)
        {
            Console.WriteLine("Dein Kommentar enthält " + numberVokale + " Vokale" );
            if (a > 0)
            {
                Console.WriteLine("Der Buchstabe 'a' kommt " + a + " mal vor");
            }
            if (e > 0)
            {
                Console.WriteLine("Der Buchstabe 'e' kommt " + e + " mal vor");
            }
            if (i > 0)
            {
                Console.WriteLine("Der Buchstabe 'i' kommt " + i + " mal vor");
            }
            if (o > 0)
            {
                Console.WriteLine("Der Buchstabe 'o' kommt " + o + " mal vor");
            }
            if (u > 0)
            {
                Console.WriteLine("Der Buchstabe 'u' kommt " + u + " mal vor");
            }
            if (ä > 0)
            {
                Console.WriteLine("Der Buchstabe 'ä' kommt " + ä + " mal vor");
            }
            if (ö > 0)
            {
                Console.WriteLine("Der Buchstabe 'ö' kommt " + ö + " mal vor");
            }
            if (ü > 0)
            {
                Console.WriteLine("Der Buchstabe 'ü' kommt " + ü + " mal vor");
            }
        }
        else
        {
            Console.WriteLine("Dein Kommentar enthält keine Vokale.");
        }
    }
}