namespace Aufgabe_4;

class Program
{
    static void Main(string[] args)
    {
        
        
        Console.WriteLine("Bitte geben Sie eine Zahl ein, um Monat zu bekommen: ");
        Console.WriteLine(" ");
        bool validZwischen1und12 = true;
        bool valid = false;
        while (valid == false)
        {
            string zahlVonMonat = Console.ReadLine();
            int validator = 0;
            
            if (int.TryParse(zahlVonMonat, out validator) == true)
            {
                Console.WriteLine("Sie haben eine Zahl eingegeben");
                validZwischen1und12 = false;
            }
            else
            {
                Console.WriteLine("Eingabefehler. Bitte geben Sie eine Zahl ein.");
            }
            
            while (validZwischen1und12 == false)
            {
                int convertedToZahl = Convert.ToInt32(zahlVonMonat);
                
                if (0 >= convertedToZahl || convertedToZahl >= 13)
                {
                    Console.WriteLine("Eingabefehler. Bitte geben Sie eine Zahl zwischen 1 und 12 ein.");
                    validZwischen1und12 = true;
                }
                else
                {
                    string[] a = new string[13]; 
                    a[0] = "nichts";
                    a[1] = "Januar";
                    a[2] = "Februar";
                    a[3] = "März";
                    a[4] = "April";
                    a[5] = "Mai";
                    a[6] = "Juni";
                    a[7] = "Juli";
                    a[8] = "August";
                    a[9] = "September";
                    a[10] = "October";
                    a[11] = "November";
                    a[12] = "December";
                    
                    Console.Write(convertedToZahl + ".Monat im Jahr ist: ");
                    Console.Write(a[convertedToZahl]);
                    return;
                }
            }
        }
    }
}