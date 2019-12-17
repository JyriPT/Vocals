using System;

namespace VocalCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pyydetään käyttäjältä syöttö tarkistettavaksi
            Console.WriteLine("Please provide an input:");
            string DATA = Console.ReadLine();

            //Tulostetaan vastaukset, tarkastetaan vokaalien määrä tulostuksen yhteydessä.
            Console.WriteLine($"Input: {DATA}");
            Console.WriteLine($"Output: Your input, ¨{DATA.ToUpper()}¨, contains {count(DATA)} vowels.");
        }

        static int count (string input)
        {
            string vowels = "AEIOUYÄÖ";
            string data = input.ToUpper();
            int num = 0;



            return num;
        }
    }
}
