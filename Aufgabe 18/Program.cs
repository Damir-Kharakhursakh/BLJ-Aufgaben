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
                Console.WriteLine("Der Buchstabe  kommt 'a' " + a + " mal vor");
            }
            if (e > 0)
            {
                Console.WriteLine("Der Buchstabe  kommt 'e' " + e + " mal vor");
            }
            if (i > 0)
            {
                Console.WriteLine("Der Buchstabe  kommt 'i' " + i + " mal vor");
            }
            if (o > 0)
            {
                Console.WriteLine("Der Buchstabe  kommt 'o' " + o + " mal vor");
            }
            if (u > 0)
            {
                Console.WriteLine("Der Buchstabe  kommt 'u' " + u + " mal vor");
            }
            if (ä > 0)
            {
                Console.WriteLine("Der Buchstabe  kommt 'ä' " + ä + " mal vor");
            }
            if (ö > 0)
            {
                Console.WriteLine("Der Buchstabe  kommt 'ö' " + ö + " mal vor");
            }
            if (ü > 0)
            {
                Console.WriteLine("Der Buchstabe  kommt 'ü' " + ü + " mal vor");
            }
        }
        else
        {
            Console.WriteLine("Dein Kommentar enthält keine Vokale.");
        }
    }
}