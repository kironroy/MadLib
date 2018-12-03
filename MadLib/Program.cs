using System;

// http://programmingisfun.com/simple-csharp-madlib-part-one/

namespace Madlib
{

    class Program
    {
        static void Main()
        {

            //declare variables
            string creature;
            string luminous;
            string ghastly;
            string spectral;
            string countryMan;
            string farrier;
            string farmer;
            string dreadful;
            string apparition;
            string hound;
            string story;

            //write header and instructions

            MadLipOpeningScreen.MadLipDisplayinRed();
            Console.Clear();

            InputScreen.InputDisplay();
           

            //ask player to enter words
            Console.WriteLine(" Please enter a noun: ");
            creature = Console.ReadLine();

            Console.Write(" Please enter an adjective: ");
            luminous = Console.ReadLine();

            Console.Write(" Please enter an adjective: ");
            ghastly = Console.ReadLine();

            Console.Write(" Please enter an adjective: ");
            spectral = Console.ReadLine();

            Console.Write(" Please enter an occupation: ");
            countryMan = Console.ReadLine();

            Console.Write(" Please enter an occupation: ");
            farrier = Console.ReadLine();

            Console.Write(" Please enter an occupation: ");
            farmer = Console.ReadLine();

            Console.Write(" Please enter an adjective: ");
            dreadful = Console.ReadLine();

            Console.Write(" Please enter a noun: ");
            apparition = Console.ReadLine();

            Console.Write(" Please enter a noun: ");
            hound = Console.ReadLine();

            //write out story
            story = $"They all agreed that it was a huge {creature} {luminous} {ghastly} and {spectral} I have cross-examined these men, one of them a hard-headed {countryMan} one a {farrier} and one a moorland {farmer} who all tell the same story of this {dreadful} {apparition} exactly corresponding to the {hound} of the legend.";

            CenterText.centerText(story);

            //keep window open and prompt for exit
            CenterText.centerText("Press enter to exit");
            Console.ReadKey();
        }
    }
}