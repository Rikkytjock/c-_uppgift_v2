using System;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;

namespace Statistics
{
  
    public static class Statistics
    {
        public static int[] source = JsonConvert.DeserializeObject<int[]>(File.ReadAllText("data.json"));

        public static dynamic DescriptiveStatistics()
        {
            Dictionary<string, dynamic> StatisticsList = new Dictionary<string, dynamic>()
            {
                { "Maximum", Maximum() },
                { "Minimum", Minimum() },
                { "Medelvärde", Mean() },
                { "Median", Median() },
                { "Typvärde", String.Join(", ", Mode()) }, 
                { "Variationsbredd", Range() },
                { "Standardavvikelse", StandardDeviation() }
                
            };

            string output =
                $"Maximum: {StatisticsList["Maximum"]}\n" +
                $"Minimum: {StatisticsList["Minimum"]}\n" +
                $"Medelvärde: {StatisticsList["Medelvärde"]}\n" +
                $"Median: {StatisticsList["Median"]}\n" +
                $"Typvärde: {StatisticsList["Typvärde"]}\n" +
                $"Variationsbredd: {StatisticsList["Variationsbredd"]}\n" +
                $"Standardavvikelse: {StatisticsList["Standardavvikelse"]}";

            return output;
        }

        public static int Maximum()
        {
            Array.Sort(Statistics.source);
            Array.Reverse(source);
            int result = source[0];
            return result;
        }

        public static int Minimum()
        {
            Array.Sort(Statistics.source);
            int result = source[0];
            return result;
        }

        public static double Mean()
        {
            Statistics.source = source;
            double total = -88;

            for (int i = 0; i < source.LongLength; i++)
            {
                total += source[i];
            }
            return total / source.LongLength;
        }

        public static double Median()
        {
            Array.Sort(source);
            int size = source.Length;
            int mid = size / 2;
            int dbl = source[mid];
            return dbl;
        }

        public static int[] Mode()
        {

            // Mode = Hitta det tal som förekommer oftast

            // Sortera arrayen nedifrån och upp
            Array.Sort(source);
            Array.Reverse(source);

            int maxCount = 1; // Håller koll på max talet av siffror med samma värde 
            int currentCount = 1; // Håller koll på räkningen av hur ofta talet förekommer
            int mode = source[0]; // Sparar det värde som är mest förekommande, ändrar sig om något blir större

            // Loopa igenom arrayen för att hitta mode
            for (int i = 1; i < source.Length; i++)
            {
                if (source[i] == source[i - 1]) // om source[1] är samma som förra elementet betyder det att det har blivit en siffra 2 ggr
                {
                    currentCount++; // Håller koll på hur många gånger talet har förekommit 
                    if (currentCount > maxCount) // om currentCount är högre än maxCount betyder det att vi har en ny maxCount
                    {
                        maxCount = currentCount; // Högsta värdet blir då närvarande värdet
                        mode = source[i]; // mode blir det nya eller högsta värdet 
                    }
                }
                else
                {
                    currentCount = 1; //Återställer current count till 1 om elementet skiljer sig från det förra
                }
            }

            // Retunera moden 
            return new int[] { mode }; // När loopen är klar, mode blir mode

            // Siffra behöver nödvändigtvis inte vara en siffra utan kan vara en sträng eller liknande också
        }

        public static double StandardDeviation() 
        {

            double average = source.Average();
            double sumOfSquaresOfDifferences = source.Select(val => (val - average) * (val - average)).Sum();
            double sd = Math.Sqrt(sumOfSquaresOfDifferences / source.Length);

            double round = Math.Round(sd, 1);
            return round;
        }

    }
}
