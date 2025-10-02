using System;

class Program
{
    static void Main(string[] args)
    {
        
        bool keypressed = false;

        while (keypressed == false)
        {
            Console.WriteLine("Make your calculation (or press Q to quit): ");
            Console.WriteLine(" ");
            string userEingabe = Console.ReadLine();
            string replaceUserEingabe = userEingabe.Replace(" ", "");
            Console.WriteLine(replaceUserEingabe);
            string[] splitUserEingabe = replaceUserEingabe.Split('+', '*', '/', '-');


            double zahl1 = Convert.ToDouble(splitUserEingabe[0]);
            double zahl2 = Convert.ToDouble(splitUserEingabe[1]);

            Console.WriteLine("replaceUserEingabe: " + replaceUserEingabe);
            char[] userEingabeArray = replaceUserEingabe.ToCharArray();


            for (int i = 0; i < userEingabeArray.Length; i++)
            {
                switch (userEingabeArray[i])
                {
                    case '*':
                        Console.WriteLine((zahl1) + " * " + (zahl2) + " ist: " + (zahl1 * zahl2));
                        break;
                    case '+':
                        Console.WriteLine((zahl1) + " + " + (zahl2) + " ist: " + (zahl1 + zahl2));
                        break;
                    case '-':
                        Console.WriteLine((zahl1) + " - " + (zahl2) + " ist: " + (zahl1 - zahl2));
                        break;
                    case '/':
                        Console.WriteLine((zahl1) + " / " + (zahl2) + " ist: " + (zahl1 / zahl2));
                        break;
                }
            }
        }
    }

    static void Second()
    {
        bool quit = false;
        while (quit == false)
        { 
            Console.WriteLine("make your calculation (or press q + Enter to quit): ");
            Console.WriteLine(" ");
            string input = Console.ReadLine();
            string replacedInput = input.Replace(" ", "");
            int intInput = int.Parse(replacedInput);
            Console.WriteLine("Int Input: " + intInput);
            char[] replacedInputArray = replacedInput.ToCharArray();
            foreach (char name in replacedInputArray)
            {
                Console.WriteLine("ReplacedInputArray: " + name);
            }
            
            if (input == "q")
            {
                quit = true; 
            }
            else
            {
                Console.WriteLine("ReplacedInput" + replacedInput);
            }
        }

    }
}