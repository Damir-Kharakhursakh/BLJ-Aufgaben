namespace Ausprobieren;

class Program
{
    static void Main(string[] args)
    {
        int i = 0;
        int a = 11;
        while (i < 10)
        {
            Console.WriteLine(i);
            i++;
            while (a < 21)
            {
                Console.WriteLine(a);
                a++;
            }
        }
        Console.WriteLine("Wird a zuerst ausgegeben?");
    }
}