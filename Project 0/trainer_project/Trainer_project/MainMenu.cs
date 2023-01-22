using System;
using System.Reflection.PortableExecutable;
using Data;
using System.Data.SqlClient;
using System.Data;
using datahandle;

namespace trainer
{
    public class MainMenu

    {

        public void MainMenuLoop()
        {
            //Program.MainLoop mp = new Program.MainLoop();
            Console.WriteLine("0 - Back");
            Console.WriteLine("1 - Signup");
            Console.WriteLine("2 - Login");
            Logging lg = new Logging();


            int inp = Convert.ToInt32(Console.ReadLine());

            switch (inp)
            {
                case 0:
                    lg.InformationWriter(":)----------Back----------:(");

                    Console.WriteLine("Back pressed");
                    Program.MainLoop = false;
                    break;
                case 1:
                    Console.Clear();
                    Console.WriteLine("Sing up menu");
                    SignUpForm sf = new SignUpForm();
                    //Program.MainLoop = false;
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Login menu");
                    LoginForm lf = new LoginForm();
                    //Program.MainLoop = false;
                    break;


                default:
                    Console.WriteLine("Wrong Input");
                    break;

            }




        }
    }
}