namespace Aufgabe_9;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Geben Sie eine Zahl, die Sie in Binäressystem umwandeln wollen: ");
        Console.WriteLine(" ");
        bool kayPress = false;
        
        while (kayPress == false)
        {
            string eingabe = Console.ReadLine();
            Console.WriteLine("Eingabe: " + eingabe);
            int zahl = Convert.ToInt32(eingabe);
            Console.WriteLine("Zahl: " + zahl);
            string bin = "";
            Console.WriteLine("Bin: " + bin);
            int rest = 0;
            int value = 0;
            

            while (zahl != 0)
            {
                rest = zahl % 2;
                bin = rest + bin;
                value = zahl / 2;
                zahl = value;
            }

            if (zahl == 0)
            {
                Console.WriteLine("Die binäre Darstellung von " + eingabe + " ist: " + bin);
            }

            ConsoleKeyInfo keyInfo = Console.ReadKey();
            if (keyInfo.KeyChar == 'q')
            {
                kayPress = true;
            }
            else
            {
                kayPress = false;
            }
        }
    }
}