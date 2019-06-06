using System;
using System.Globalization;
using System.Collections.Generic;

namespace Madlib
{
    public static class MadLipOpeningScreen
    {
        
        
            public static void MadLipDisplayinRed()
            {

                Console.ForegroundColor = ConsoleColor.Red;

                Console.Title = "ASCII Art";
                Console.WriteLine(); // breakline
                string titleRed =
                     @"
                                       
                           
                      .         .                                                                                          
                     ,8.       ,8.                   .8.          8 888888888o.      8 8888          8 8888 8 888888888o   
                    ,888.     ,888.                 .888.         8 8888    `^888.   8 8888          8 8888 8 8888    `88. 
                   .`8888.   .`8888.               :88888.        8 8888        `88. 8 8888          8 8888 8 8888     `88 
                  ,8.`8888. ,8.`8888.             . `88888.       8 8888         `88 8 8888          8 8888 8 8888     ,88 
                 ,8'8.`8888,8^8.`8888.           .8. `88888.      8 8888          88 8 8888          8 8888 8 8888.   ,88' 
                ,8' `8.`8888' `8.`8888.         .8`8. `88888.     8 8888          88 8 8888          8 8888 8 888888888P'  
               ,8'   `8.`88'   `8.`8888.       .8' `8. `88888.    8 8888         ,88 8 8888          8 8888 8 8888         
              ,8'     `8.`'     `8.`8888.     .8'   `8. `88888.   8 8888        ,88' 8 8888          8 8888 8 8888         
             ,8'       `8        `8.`8888.   .888888888. `88888.  8 8888    ,o88P'   8 8888          8 8888 8 8888         
            ,8'         `         `8.`8888. .8'       `8. `88888. 8 888888888P'      8 888888888888  8 8888 8 8888         

               ";

            MainGame mainGame = new MainGame();
            mainGame.TypeWritter(titleRed);
                Console.WriteLine(); // breakline
                Console.ForegroundColor = ConsoleColor.Yellow;
                CenterText.centerText("Press enter to continue...");
                Console.ReadKey();
                Console.Clear();

        } // method end

        
    }

}