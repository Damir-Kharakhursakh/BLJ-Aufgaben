namespace Aufgabe_15;

class Program
{
    static void Main(string[] args)
    {
        //Breite Stammes
        Console.WriteLine("Breite des Stammes: ");
        Console.WriteLine(" ");
        string breiteStammes = Console.ReadLine();
        int intBreiteStammes = Convert.ToInt32(breiteStammes);
        
        //Höhe Stammes
        Console.WriteLine("Höhe des Stammes: ");
        string höheStammes = Console.ReadLine();
        int intHöheStammes = Convert.ToInt32(höheStammes);
        
        // Höhe Krone
        Console.WriteLine("Höhe der Krone: ");
        string höheKrone = Console.ReadLine();
        int intHöheKrone = Convert.ToInt32(höheKrone);
        
        //Zeichnen
        int anzahlAbstände;
        anzahlAbstände = (intHöheKrone * 2 - 1 - intBreiteStammes) / 2;

        int anzahlAbständeKrone;
        anzahlAbständeKrone = (intHöheKrone - 1);

        int anzahlSterneKrone = 1;

        for (int a = 0; a < intHöheKrone; a++)
        {
            int zeileKrone = 1;
            for (zeileKrone = 1; zeileKrone <= anzahlAbständeKrone; zeileKrone++)
            {
                Console.Write(" ");
            }

            for (int zeileKrone2 = 1; zeileKrone2 <= anzahlSterneKrone; zeileKrone2++)
            {
                Console.Write("*");
            }
            anzahlSterneKrone = anzahlSterneKrone + 2;
            anzahlAbständeKrone--;
            Console.WriteLine();
        }
        
        
        for (int i = 0; i < intHöheStammes; i++)
        {
            int zeileStammes = 1;
            for (zeileStammes = 1; zeileStammes <= anzahlAbstände; zeileStammes++)
            {
                Console.Write(" ");
            }
            int zeileStammes2 = 1;
            for (zeileStammes2 = 1; zeileStammes2 <= intBreiteStammes; zeileStammes2++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}