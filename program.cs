using System;
using System.Collections.Generic;

namespace whatever
{
    class Program
    {
        static void Main(string[] args)
        {
            countries country1 = new countries();
            country1.code = "CA";
            country1.name = "CANADA";
            country1.capital = "OTTAWA";

            countries country2 = new countries();
            country2.code = "PK";
            country2.name = "PAKISTAN";
            country2.capital = "ISLAMABAD";

            countries country3 = new countries();
            country3.code = "IN";
            country3.name = "INDIA";
            country3.capital = "NEW DELHI";

            countries country4 = new countries();
            country4.code = "SE";
            country4.name = "SWEDEN";
            country4.capital = "STOCKHOLM";

            countries country5 = new countries();
            country5.code = "GB";
            country5.name = "UNITED KINGDOM";
            country5.capital = "LONDON";

            Dictionary<string, countries> dictionaryOfCountries = new Dictionary<string, countries>();
            dictionaryOfCountries.Add(country1.code, country1);
            dictionaryOfCountries.Add(country2.code, country2);
            dictionaryOfCountries.Add(country3.code, country3);
            dictionaryOfCountries.Add(country4.code, country4);
            dictionaryOfCountries.Add(country5.code, country5);

            string userAnswer = "";
            do
            {
                Console.WriteLine("Please enter the country code ");
                string userCode = Console.ReadLine().ToUpper();

                //looking up for a value using dic
                countries resultCountry = dictionaryOfCountries.ContainsKey(userCode) ? dictionaryOfCountries[userCode] : null;

                if (resultCountry == null)
                {
                    Console.WriteLine("Invalid code");
                }
                else
                {
                    Console.WriteLine("Code: {0}\nName: {1}\nCapital: {2}", resultCountry.code, resultCountry.name, resultCountry.capital);
                }
                do
                {
                    Console.WriteLine("Do you want to continue ? - YES or NO");
                    userAnswer = Console.ReadLine().ToUpper();
                }
                while (userAnswer != "YES" && userAnswer != "NO");
            }


            while (userAnswer == "YES");
           
            Console.ReadKey();
        }
    }

    class countries
    {
        public string code { get; set; }
        public string name { get; set; }
        public string capital { get; set; }
    }
}
