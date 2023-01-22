using System;
using UserProfile;

namespace User 
{
    public class UserCreationMenu
    {
        public UserCreationMenu(int usid,string name)
        {
            bool runner = true;

            while (runner)
            {
                Console.WriteLine($"Welcome Back {name}");
                Console.WriteLine("");
                Console.WriteLine("0 - LogOut");
                Console.WriteLine("1 - Education");
                Console.WriteLine("2 - Skills");
                Console.WriteLine("3 - Experience");
                Console.WriteLine("4 - My Profile");

                int num = Convert.ToInt32(Console.ReadLine());

                switch (num)
                {
                    case 0:
                        runner = false;
                        break;
                    case 1:
                        Console.WriteLine("Education");
                        EducationMenu em = new EducationMenu(usid);
                        break;
                    case 2:
                        Console.WriteLine("Skills");
                        SkillsMenu sk = new SkillsMenu(usid);
                        break;
                    case 3:
                        Console.WriteLine("Experience");
                        CompanyMenu ex = new CompanyMenu(usid);
                        break;
                    case 4:
                        Console.WriteLine("View Profile");
                        ViewProfile mp = new ViewProfile(); 
                        mp.ViewProfile1(usid);
                        mp.ViewProfileEdu(usid);
                        mp.ViewProfileExperience(usid);
                        mp.ViewProfileSkills(usid);
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Please enter a valid input");
                        break;

                }
            }



        }
    }
}