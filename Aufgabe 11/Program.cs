namespace Aufgabe_11;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Geben Sie erste Zahl ein: ");
        Console.WriteLine(" ");
        string input1 = Console.ReadLine();
        int userNumber1 = Convert.ToInt32(input1);
        
        Console.WriteLine("Geben Sie zweite Zahl ein: ");
        Console.WriteLine(" ");
        string input2 = Console.ReadLine();
        int userNumber2 = Convert.ToInt32(input2);

        if (userNumber1 > userNumber2)
        {
            int wechsel = userNumber1;
            userNumber1 = userNumber2;
            userNumber2 = wechsel;
        }
        
        for (int i = userNumber1; i < userNumber2 + 1; i++)
        {
            int sum2 = GetChecksum(i);
            if (i % sum2 == 0)
            {
                Console.WriteLine("Zahl, Quersumme, Zahl/Quersumme");
                Console.WriteLine(i + "\t" + sum2 + "\t" + i / sum2);
            }
        }
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