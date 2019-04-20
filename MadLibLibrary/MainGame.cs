using System;

// http://programmingisfun.com/simple-csharp-madlib-part-one/

namespace Madlib
{
    public class MainGame
    {
        static string[] wordsDefault = new string[] { "creature", "luminous", "ghastly", "spectral", "countryman", "farrier", "farmer", "dreadful", "apparition", "hound" };
        static string[] promptsUserFor = new string[] { "noun", "adjective", "adjective", "adjective", "occupation", "occupation", "occupation", "adjective", "noun", "noun" };
        static string usersStory;

        public static void madlibRun() // main function to run story!
        {
            getWords();
            writeStory();
            
        }

        static void getWords()
        {
            // ask player to enter words
            for (int i = 0; i < wordsDefault.Length; i++)
            {
                typeWritter($"Please enter a/an {promptsUserFor[i]}" + ": ");
                //Console.Write($"Please enter a/an {promptsUserFor[i]}" + ": ");
                wordsDefault[i] = Console.ReadLine();
            }

            //clear the console window
            Console.Clear();
        }


        

        public static void typeWritter(string message)
        {
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                System.Threading.Thread.Sleep(2);
                
            }

        }





        static void writeStory()
        {


            //write out story
            Console.WriteLine();
            usersStory = $"They all agreed that it was a huge {wordsDefault[0]}, {wordsDefault[1]}, {wordsDefault[2]}, and {wordsDefault[3]}.\nI have cross-examined these men, one of them a hard-headed {wordsDefault[4]},\none a {wordsDefault[5]}, and one a moorland {wordsDefault[6]}, who all tell the same story\nof this {wordsDefault[7]} {wordsDefault[8]}, exactly corresponding to the {wordsDefault[9]} of the legend.";
            //Console.WriteLine(usersStory, wordsDefault[0], wordsDefault[1], wordsDefault[2], wordsDefault[3], wordsDefault[4], wordsDefault[5], wordsDefault[6], wordsDefault[7], wordsDefault[8], wordsDefault[9]);
            typeWritter(usersStory);
            Console.WriteLine(); // breakline
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(); // breakline
            Console.ReadKey();
            
        }




    } // class ends
}