using System.Net;
using Newtonsoft.Json.Linq;

namespace Aufgabe_20
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Wollen Sie nächsten Witz holen [y/n] ?");
                Console.WriteLine(" ");
                char input = Console.ReadKey().KeyChar;
                if (input == 'y')
                {
                    Console.WriteLine("This is a Joke IPA:");
                    Console.WriteLine(" ");
                    WebRequest request = WebRequest.Create("https://witzapi.de/api/joke/");
                    WebResponse response = request.GetResponse();

                    using Stream responseStream = response.GetResponseStream();
                    using StreamReader reader = new StreamReader(responseStream);
                    string json = reader.ReadToEnd();

                    JArray array = JArray.Parse(json);

                    foreach (var joke in array)
                    {
                        Console.WriteLine(joke["text"]);
                    } 
                    continue;
                }
                else if (input == 'n')
                {
                    Console.WriteLine("Der nächste Witz wäre bestimmt cool gewesen, aber Sie wollten es nicht lesen.");
                    Console.WriteLine(" ");
                    break;
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe. Geben Sie y / n");
                    Console.WriteLine(" ");
                    continue;
                }
            }
        }
    }
}