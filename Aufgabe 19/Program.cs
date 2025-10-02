namespace Aufgabe_19;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Einfacher Taschenrechner");
        Console.WriteLine("Erlaubte Operatoren: +  -  *  /");
        Console.WriteLine("Zum Beenden 'Q + Enter' eingeben.\n");

        while (true)
        {
            Console.Write("Make your calculation (or press Q + Enter to quit): ");
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                continue;
            }

            if (input.Trim().ToLower() == "q")
            {
                break;
            }

            try
            {
                
                input = input.Replace(" ", "");

                // Operator suchen (+ - * /)
                char op = '\0';
                int opI = -1;

                foreach (char c in new char[] { '+', '-', '*', '/' })
                {
                    opI = input.IndexOf(c, 1); 
                    // ab Index 1 suchen, damit Vorzeichen bei negativen Zahlen erlaubt sind
                    if (opI > 0)
                    {
                        op = c;
                        break;
                    }
                }

                if (opI == -1)
                {
                    Console.WriteLine("Ungültige Eingabe!");
                    continue;
                }

                // Zahlen vor und nach dem Operator
                string left = input.Substring(0, opI);
                string right = input.Substring(opI + 1);

                if (!double.TryParse(left, out double num1) || !double.TryParse(right, out double num2))
                {
                    Console.WriteLine("Ungültige Zahlen!");
                    continue;
                }

                double result = 0;

                switch (op)
                {
                    case '+':
                        result = num1 + num2;
                        break;
                    case '-':
                        result = num1 - num2;
                        break;
                    case '*':
                        result = num1 * num2;
                        break;
                    case '/':
                        if (num2 == 0)
                        {
                            Console.WriteLine("Fehler: Division durch 0 ist nicht erlaubt!");
                            continue;
                        }
                        result = num1 / num2;
                        break;
                }

                Console.WriteLine(result);
            }
            catch
            {
                Console.WriteLine("Fehlerhafte Eingabe!!!!!!!!!");
            }
        }
        Console.WriteLine("Programm stopt");
    }
}