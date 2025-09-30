namespace Aufgabe_15;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Geben Sie die länge der Linie ein: ");
        Console.WriteLine(" ");
        string input = Console.ReadLine();
        int intInput = Convert.ToInt32(input);
        
        string [,] stringArray = new string [intInput, intInput];

        for (int i = 0; i < intInput; i++)
        {
            stringArray[i,i] = " ";
        }
        
        for (int zeile = 0; zeile < stringArray.GetLength(0); zeile++)
        {
            for (int spalte = 0; spalte < stringArray.GetLength(1); spalte++)
            {
                Console.Write(stringArray[zeile, spalte] + "*");
            }
            Console.WriteLine();
        }
    }
}