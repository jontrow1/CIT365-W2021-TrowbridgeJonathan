﻿using System;

namespace MyFirstConsoleApplication
{
    static class GlazerApp
    {
        public static void RunExample()
        {
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.Write("What is the width of the window? ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.Write("What is the height of the window? ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;

            glassArea = 2 * (width + height);

            Console.WriteLine("The length of the wood is " + woodLength + " feet.");
            Console.WriteLine("The area of the glass is " + glassArea + " square metres.");
        }
    }
}
