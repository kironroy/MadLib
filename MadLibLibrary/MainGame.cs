using System;
using System.Collections.Generic;

// http://programmingisfun.com/simple-csharp-madlib-part-one/

namespace Madlib
{
    public class MainGame
    {
        List<string> wordsDefault = new List<string> { "creature", "luminous", "ghastly", "spectral", "countryman", "farrier", "farmer", "dreadful", "apparition", "hound" };
        List<string> promptsUserFor = new List<string> { "noun", "adjective", "adjective", "adjective", "occupation", "occupation", "occupation", "adjective", "noun", "noun" };
        string usersStory;

        public void madlibRun() // main function to run story
        {
            GetWords();
            WriteStory();
            
        }

        public void GetWords()
        {
            // ask player to enter words
            for (int i = 0; i < wordsDefault.Count; i++)
            {
                TypeWritter($"Please enter a/an {promptsUserFor[i]}" + ": ");
                wordsDefault[i] = Console.ReadLine();
            }

            //clear the console window
            Console.Clear();
        }

        public void TypeWritter(string message)
        {
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                System.Threading.Thread.Sleep(2);
                
            }

        }

        public void WriteStory()
        {

            //write out story
            Console.WriteLine();

            usersStory = $"They all agreed that it was a huge {wordsDefault[0]}, {wordsDefault[1]}, {wordsDefault[2]}, " +
                $"and {wordsDefault[3]}.\n" +
                $"I have cross-examined these men, one of them a hard-headed {wordsDefault[4]},\none a {wordsDefault[5]}, " +
                $"and one a moorland {wordsDefault[6]}, " +
                $"who all tell the same story\nof this {wordsDefault[7]} {wordsDefault[8]}, " +
                $"exactly corresponding to the {wordsDefault[9]} of the legend.";

            TypeWritter(usersStory);
            Console.WriteLine(); // breakline
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(); // breakline
            Console.ReadKey();
            
        }

    } 
}



        







