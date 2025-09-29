namespace Aufgabe_6;

class Program
{
    static void Main(string[] args)
    {
        int zeilenAbbruch = 10;
        for (int i = 1; i < 11; i++)
        {
            for (int n = 1; n < 11; n++)
            {
                int result = i * n;
                Console.Write(result + "\t");
                if (zeilenAbbruch == result)
                {
                    Console.WriteLine(" ");
                    zeilenAbbruch = zeilenAbbruch + 10;
                }
            }
        }
    }
}