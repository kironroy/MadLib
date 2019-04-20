using System;
namespace Madlib
{
    public static class InputScreen
    {
        public static void InputDisplay()
        {

            Console.ForegroundColor = ConsoleColor.Blue;

            Console.Title = "ASCII Art";
            Console.WriteLine(); // breakline
            string titleBlue =
                 @"
                                            ╦ ╦┌─┐  ┌┐┌┌─┐┌─┐┌┬┐  ┌─┐┌─┐┌┬┐┌─┐  ┬┌┐┌┌─┐┬ ┬┌┬┐
                                            ║║║├┤   │││├┤ ├┤  ││  └─┐│ ││││├┤   ││││├─┘│ │ │ 
                                            ╚╩╝└─┘  ┘└┘└─┘└─┘─┴┘  └─┘└─┘┴ ┴└─┘  ┴┘└┘┴  └─┘ ┴ 
                 ";

            MainGame.typeWritter(titleBlue);
            Console.WriteLine(); // breakline
            Console.ForegroundColor = ConsoleColor.Yellow;
            //CenterText.centerText("Press enter to continue...");
            //Console.ReadKey();
            //Console.Clear();

        } // method end

    }
}