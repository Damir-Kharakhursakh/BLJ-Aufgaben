namespace Aufgabe_1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Dieses Programm berechnet die Summe von zwei Zahlen.");
        Console.WriteLine("Zahl 1: ");
        string zahlEins = Console.ReadLine();
        int zahlInt1 = Convert.ToInt32(zahlEins);
        Console.WriteLine("Zahl 2: ");
        string zahlZwei = Console.ReadLine();
        int zahlInt2 = Convert.ToInt32(zahlZwei);
        Console.WriteLine($"Die Summe ist: {zahlInt1 + zahlInt2}");
    }
}