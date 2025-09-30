namespace Aufgabe_10;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Gebe Sie eine Zahl ein: ");
        Console.WriteLine(" ");
        string input = Console.ReadLine();
        int userNumber = Convert.ToInt32(input);
        int sum = GetChecksum(userNumber);
        Console.WriteLine(sum);
    }

    static int GetChecksum(int zahl) 
    {
        int sum = 0;
        while (zahl != 0) 
        {
            sum += zahl % 10;
            zahl /= 10;
        }
        return sum;
    }
}