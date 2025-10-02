

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ausprobieren2
{
    class Program
    {
        const string Space = "  ";
        const string Welcome = 
            "MEMORY -> Hinter den '?' verstecken sich Symbole, die paarweise vorkommen. Finden Sie diese!\nZum Aufdecken wählen Sie zwei Positionen in der Form: Zeile1Spalte1Zeile2Spalte2.\nZ.Bsp.: 2142 deckt das Symbol in Zeile 2 u. Spalte 1 auf sowie das Symbol in Zeile 4 u. Spalte 2.";

        static char[,] memory;
        static char[,] gameState;
        static char[] symbols = { '☺', '#', '♦', '♠', '♥', '♣', '♫', '☼', '©', '☻', '▲', '►', '▼', '◄', '&', '§', '$', '£'};
        static int memorySize = 4; // gültige Werte: 2,4,6 (begrenzt durch Anzahl Symbole -> 18 Symbole reichen für ein 6x6 Memory) 
        static char[] input;
        static int countOfAttempts = 0;

        static void Main(string[] args)
        {
            Console.WriteLine(Welcome);

            InitializeMemory();
            InitializeGameState();
            DisplayGameState();
        
            while (!IsGameOver())
            {
                input = GetInputFromUser();
                Console.Clear();
                CheckSuccess(input);
            }

            Console.WriteLine("\nSie haben alle Karten aufgedeckt. Gratulation! Anzahl Versuche: " + countOfAttempts);
            Console.ReadKey();
        }

        static void InitializeGameState()
        {
            gameState = new char[memorySize, memorySize];

            for (int i = 0; i < gameState.GetLength(0); i++)
            {
                for (int k = 0; k < gameState.GetLength(1); k++)
                {
                    gameState[i, k] = '?';
                }
            }
        }
        static void InitializeMemory()
        {
            memory = new char[memorySize, memorySize];

            int[] helper = new int[(memorySize * memorySize) / 2]; // Grösse des Arrays entspricht der Anzahl benötigten Symbole 
            Random random = new Random();

            for (int i = 0; i < memorySize; i++)
            {
                for (int k = 0; k < memorySize; k++)
                {
                    int r = random.Next(0, helper.Length);
                    helper[r]++;

                    if (helper[r] < 3)
                    {
                        memory[i, k] = symbols[r];
                    }
                    else
                    {
                        k--;
                    }
                }
            }
        }

        static void DisplayGameState()
        {
            Console.WriteLine();

            // Abstand für Spaltenüberschriften schaffen 
            Console.Write(Space + " ");

            // Spaltenüberschriften ausgeben  
            for (int j = 0; j < gameState.GetLength(1); j++)
            {
                Console.Write((j + 1) + Space);
            }

            // Zeilenbeschriftungen und Daten ausgeben 
            for (int i = 0; i < gameState.GetLength(0); i++)
            {
                Console.WriteLine();
                Console.Write((i + 1) + Space);
                for (int j = 0; j < gameState.GetLength(1); j++)
                {
                    Console.Write(gameState[i, j] + Space);
                }
            }
        }

        static char[] GetInputFromUser()
        {
            Console.WriteLine();

            char memSizeAsChar = Convert.ToChar(memorySize.ToString());

            while (true)
            {
                char[] input = Console.ReadLine().ToCharArray();

                if (input.Length > 4 || input.Length < 4)
                {
                    // Die Eingabe muss genau 4 Zeichen lang sein 
                    Console.WriteLine("Ungültige Eingabe! Zu wenige/viele Zahlen. Es werden genau 4 Zahlen erwartet!");
                }

                else if ((input[0] == input[2]) && (input[1] == input[3]))
                {
                    // Es müssen zwei unterschiedliche Positionen eingegeben werden  
                    Console.WriteLine("Ungültige Eingabe! 2x gleiche Position.");

                }
                else if (input[0] > memSizeAsChar || input[0] < Convert.ToChar("1") || input[1] > memSizeAsChar || input[1] < Convert.ToChar("1")
                    || input[2] > memSizeAsChar || input[2] < Convert.ToChar("1") || input[3] > memSizeAsChar || input[3] < Convert.ToChar("1"))
                {
                    // Die Eingabe muss zwischen 1 und der Board-Grösse liegen

                    Console.WriteLine("Ungültige Eingabe! Zahlen müssen zwischen 1 und " + memorySize + " liegen)");
                }
                else
                {
                    // Eingabe OK, wir sind fertig.
                    return input;
                }
            }
        }

        static void CheckSuccess(char[] userInput)
        {
            int x1 = Convert.ToInt32(userInput[0].ToString()) - 1;
            int y1 = Convert.ToInt32(userInput[1].ToString()) - 1;
            int x2 = Convert.ToInt32(userInput[2].ToString()) - 1;
            int y2 = Convert.ToInt32(userInput[3].ToString()) - 1;

            
            if (gameState[x1, y1] == ' ' || gameState[x2, y2] == ' ')
            {
                // one or both symbols have successfully been uncovered before -> no success 
                Console.WriteLine(" > Ungültiger Versuch. Mindestens eines der Symbole wurde bereits aufgedeckt.");
                DisplayGameState();
                               
                return; 
            }

            char c1 = memory[x1, y1];
            char c2 = memory[x2, y2];

            gameState[x1, y1] = c1;
            gameState[x2, y2] = c2;

            DisplayGameState();
            
            Console.WriteLine();

            if (c1 != c2)
            {
                // different symbols -> no success 
                Console.WriteLine(" > Leider kein Treffer.");
               
                // zudecken
                gameState[x1, y1] = '?';
                gameState[x2, y2] = '?';
            }
            else
            {
                // success
                Console.WriteLine(" > Treffer!");
     
                // zudecken 
                gameState[x1, y1] = ' ';
                gameState[x2, y2] = ' ';
            }

            DisplayGameState();
            countOfAttempts++;
        }

        static bool IsGameOver()
        {
            for (int i = 0; i < memorySize; i++)
            {
                for (int j= 0; j < memorySize; j++)
                {
                    if (gameState[i, j] != ' ')
                        return false;
                }
            }

            return true;
        }
    }
}