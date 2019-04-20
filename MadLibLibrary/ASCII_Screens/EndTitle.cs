using System;
using System.Globalization;
using System.Collections.Generic;

namespace Madlib
{
    public static class EndingGameScene
    {
        public static void EndTitle()
        {
            //Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.Title = "ASCII Art";
            Console.WriteLine(); // breakline
            Console.WriteLine(); // breakline
            Console.WriteLine(); // breakline
            string endTitle =
                @"
                               
                     
                                                        ███████╗██╗███╗   ██╗
                                                        ██╔════╝██║████╗  ██║
                                                        █████╗  ██║██╔██╗ ██║
                                                        ██╔══╝  ██║██║╚██╗██║
                                                        ██║     ██║██║ ╚████║
                                                        ╚═╝     ╚═╝╚═╝  ╚═══╝
                ";

            MainGame.typeWritter(endTitle);
            Console.ReadKey();
            Console.Clear();


        }
    }
}