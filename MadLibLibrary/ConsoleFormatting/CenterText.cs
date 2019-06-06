using System;


namespace Madlib
{
    class CenterText
    {
        public static void centerText(string message)
        {
            int screenWidth = Console.WindowWidth;
            int stringWidth = message.Length;
            int spaces = (screenWidth / 2) + (stringWidth / 2);

            Console.WriteLine("\n");


            Console.WriteLine(message.PadLeft(spaces));
        }

    }
}