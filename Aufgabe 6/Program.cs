namespace Aufgabe_6;

class Program
{
    static void Main(string[] args)
    {
        int zeilenAbbruch = 10;
        for (int i = 1; i < 101; i++)
        {
            Console.Write(i + "\t");
            if (zeilenAbbruch == i)
            {
                Console.WriteLine(" ");
                zeilenAbbruch = zeilenAbbruch + 10;
            }
        }
    }
}