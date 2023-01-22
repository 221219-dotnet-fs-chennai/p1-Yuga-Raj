using System;
using Data;
using datahandle;

namespace trainer
{
    public class Program
    {


        public static bool MainLoop = true;


        public static void Main()
        {
            Logging lg = new Logging();
            Console.WriteLine(":)----------Hi Boss,welcome----------:(");
            lg.InformationWriter(":)----------New Run started----------:(");
            MainMenu menu = new MainMenu();

            while (MainLoop)
            {
                menu.MainMenuLoop();

            }

        }

    }

}