﻿// http://programmingisfun.com/simple-csharp-madlib-part-one/

namespace Madlib
{
    class Program
    {
        static void Main()
        {
            // Madlip in ASCII 'broadway' font
            MadLipOpeningScreen.MadLipDisplayinRed();

            // "We need  some input" in ASCII font 
            InputScreen.InputDisplay();

            // init Game
            MainGame mainGame = new MainGame();
            mainGame.madlibRun();

            // End Title
            EndingGameScene.EndTitle();
   
        }
    }
}