namespace Aufgabe_7;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Zahlen zwischen 1 und 30, die durch 5 und/oder 3 ohne Rest teilbar sind: ");
        for (int i = 1; i < 31; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                if (i == 30)
                {
                    Console.Write(i);
                }
                else
                {
                    Console.Write(i + ", ");
                }
            }
        }
    }
}