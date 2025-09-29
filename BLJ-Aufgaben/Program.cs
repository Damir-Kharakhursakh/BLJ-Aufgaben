namespace BLJ_Aufgaben;

class Program
{
    static void Main(string[] args)
    {
        int i = 1;
        while (true)
        {
            if (i == 10)
            {
                // beendet die Schleife
                break;
            }
            Console.WriteLine(i);
            i = i + 1;
        }
    }
}