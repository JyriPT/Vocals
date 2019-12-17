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

        //Vokaalien laskenta (vaihtoehto 2)
        static int count (string DATA)
        {
            //Määritellään vokaalit, luodaan muuttuja syötteen käsittelyä varten
            string vowels = "AEIOUYÄÖ";
            string process = DATA.ToUpper();

            //Käydään jokainen vokaali läpi ja poistetaan ne muokatusta syötteestä
            foreach (char vowel in vowels)
            {
                //Tarkistaa löytyykö kyseistä vokaalia, jos löytyy niin poistaa ja tarkistaa uudelleen
                int check = process.IndexOf(vowel);

                if (check >= 0)
                {
                    do
                    {
                        process = process.Remove(check, 1);

                        check = process.IndexOf(vowel);

                    } while (check >= 0);
                }
                
            }

            //Lasketaan vokaalien määrä (alkuperäisen syötteen pituus - muokatun lauseen pituus)
            int num = DATA.Length - process.Length;
            //Palautetaan tulos
            return num;
        }
    }
}
