namespace Aufgabe_12;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Geben Sie die zu summierenden Ganzzahlen mit Komma getrennt ein: ");
        Console.WriteLine(" ");
        string input = Console.ReadLine();
        string[] stringArray  = input.Split(',');
        int[] intArray = Array.ConvertAll(stringArray, int.Parse);
        
        SumUp(intArray);
        
    }
    
    static int[] SumUp(int[] intArray) 
    {    
        //Rückgabe-Array initialisieren 
        int[] result = new int[intArray.Length]; 
        
        int sum = 0;
        
        for (int i = 0; i < intArray.Length; i++)
        {
            while (i <= intArray.Length - 1)
            {
                sum = intArray[i] + sum;
                
                if (i == intArray.Length - 1)
                {
                    Console.Write("[" + i + "]" + " -> " + sum);
                    i++;
                }
                else
                {
                    Console.Write("[" + i + "]" + " -> " + sum + ", ");
                    i++;
                }
            }
        }

        return result;
    }
}