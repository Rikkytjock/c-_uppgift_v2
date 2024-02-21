using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Statistics;

namespace StatisticsTest
{
    [TestClass]
    public class StatisticsTests
    {
        [TestMethod]
        public void Maximum_ReturnsMaximumValue()
        {

            int result = Statistics.Statistics.Maximum(testData);


            int expectedMaximumValue = 10;
            Assert.AreEqual(expectedMaximumValue, result);
        }

        [TestMethod]
        public void Minimum_ReturnsMinimumValue()
        {

            int result = Statistics.Statistics.Minimum(testData);


            int expectedMinimumValue = 2;
            Assert.AreEqual(expectedMinimumValue, result);
        }

        [TestMethod]
        public void Median_ReturnsMedianValue()
        {

            double result = Statistics.Statistics.Median(testData);

            double expectedMedianValue = 5.5; // Average of 5 and 6
            Assert.AreEqual(expectedMedianValue, result);
        }

        [TestMethod]
        public void Mode_ReturnsModeValue()
        {

            int[] result = Statistics.Statistics.Mode(testData);

            int[] expectedModeValue = { 7, 8 }; // Modes are 7 and 8
            CollectionAssert.AreEqual(expectedModeValue, result);
        }

        [TestMethod]
        public void Range_ReturnsRangeValue()
        {

            int result = Statistics.Statistics.Range(testData);

            int expectedRangeValue = 8; // Range is the difference between maximum and minimum values
            Assert.AreEqual(expectedRangeValue, result);
        }

        [TestMethod]
        public void StandardDeviation_ReturnsStandardDeviationValue()
        {
            double result = Statistics.Statistics.StandardDeviation(testData);

            double expectedStandardDeviationValue = 2.73; 
            Assert.AreEqual(expectedStandardDeviationValue, result, 0.01);
        }
    }
}

// Så detta är min test, jag har fått många fel och error under vägen :) 
// Jag hade stora problem med att koppla samman Statstics och Statsitcs test
// Men genom att lägga till koden här tillsammans med klasser och referensen så funka det
// Däremot kan jag fortfarande inte göra en komplett build, förmodligen för att jag inte lyckats koppla ihop
// Skulle jag vara på ett företag hade jag kollat med en senior dev. för att lyckas med detta, försökte så mycket på nätet och föreläsningarna som jag kunde

// Förbättringar skulle vara att:
// Förenkla/förbättra koden, jag är säker på att många ställe går det att skriva kod som beter sig på samma sätt än det som har skrivits men med mycket färre rader
// Nu fick jag lite errors och så, men kanske använda try-catch-block för att snappa upp om det blir några felmeddelande. Så inte hela applikationen bara krashar 
// Testa koden flera gånger innan det går live 
// CODE REVIEW! Något jag verkligen hade behövt, att någon på liknande nivå eller helst högre nivå kollar igenom koden för att se så allt är ok. I detta fallet hade det enkelt kunna fixat det som gick fel..
// Hoppas detta var ok! 

// **Random ändring eftersom jag tagit bort git filen i Statsitcs då det var en pil i mappen på github och det gjorde att det inte gick att gå in i mappen***