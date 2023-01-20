using System;
using Data;
using System.Data;
using System.Data.SqlClient;

namespace UserProfile
{


    public class ViewProfile 
    {
        private string Connection = File.ReadAllText(@"C:\Users\SURYA\Training\sqlid.txt");

        public void ViewProfile1(int usid) 
        {
            using SqlConnection con = new SqlConnection(Connection);

            con.Open();
            string q = $"Select first_name,last_name,email_id,phone_no from project.[user] where user_id = {usid}";
            using SqlCommand cmd = new SqlCommand(q, con);
            using SqlDataReader reader = cmd.ExecuteReader();
            Console.WriteLine("**********ViewProfile**********");
            while (reader.Read())
            {
                Console.WriteLine($"First Name - {reader.GetString(0)}");
                Console.WriteLine($"Last Name - {reader.GetString(1)}");
                Console.WriteLine($"Email ID - {reader.GetString(2)}");
                Console.WriteLine($"Phone No - {reader.GetInt32(3)}");


            }
            reader.Close();
            con.Close();
        }

        public void ViewProfileEdu(int usid)
         {
            using SqlConnection conn = new SqlConnection(Connection);
            conn.Open();

            string q = $"Select * from project.edu where us_id = {usid}";
            using SqlCommand cmd1 = new SqlCommand(q, conn);
            using SqlDataReader reader1 = cmd1.ExecuteReader();
            Console.WriteLine("**********Education**********");
            int countt = 1;
            while (reader1.Read())
            {
                Console.WriteLine($"Education -{countt}");
                Console.WriteLine("");

                Console.WriteLine($"Institution - {reader1.GetString(1)}");
                Console.WriteLine($"Course Studied - {reader1.GetString(2)}");
                Console.WriteLine($"Course Studied from - {reader1.GetDateTime(3)} to {reader1.GetDateTime(4)}");
                Console.WriteLine($"CGPA score - {reader1.GetString(5)}");
                countt++;


                //Console.WriteLine($"Last Name - {reader.GetString(1)}");
                //Console.WriteLine($"Email ID - {reader.GetString(2)}");
                //Console.WriteLine($"Phone No - {reader.GetInt64(3)}");


            }
            reader1.Close();
            conn.Close();
        }

        public void ViewProfileExperience(int usid)
         {
            using SqlConnection conn = new SqlConnection(Connection);
            conn.Open();

            string q = $"Select * from project.comp where us_id = {usid}";
            using SqlCommand cmd1 = new SqlCommand(q, conn);
            using SqlDataReader reader1 = cmd1.ExecuteReader();
            int countt = 1;

            Console.WriteLine("*********Company Experience********");
            while (reader1.Read())
            {
                Console.WriteLine($"Work Experience  -{countt}");
                Console.WriteLine("");
                Console.WriteLine($"Job Role - {reader1.GetString(1)}");
                Console.WriteLine($"Company Name - {reader1.GetString(2)}");
                Console.WriteLine($"Worked from  {reader1.GetDateTime(3)} to {reader1.GetDateTime(4)}");
                countt++;


                //Console.WriteLine($"Last Name - {reader.GetString(1)}");
                //Console.WriteLine($"Email ID - {reader.GetString(2)}");
                //Console.WriteLine($"Phone No - {reader.GetInt64(3)}");


            }
            reader1.Close();
            conn.Close();
        }

        public void ViewProfileSkills(int usid)
         {
            using SqlConnection conn = new SqlConnection(Connection);
            conn.Open();

            string q = $"Select * from project.skills where us_id = {usid}";
            using SqlCommand cmd1 = new SqlCommand(q, conn);
            using SqlDataReader reader1 = cmd1.ExecuteReader();
            int countt = 1;

            Console.WriteLine("********Skills**********");
            while (reader1.Read())
            {
                Console.WriteLine($"{countt} skill - {reader1.GetString(1)}  Experience - {reader1.GetInt32(2) / 12f} Years");
                Console.WriteLine("");

                countt++;


                //Console.WriteLine($"Last Name - {reader.GetString(1)}");
                //Console.WriteLine($"Email ID - {reader.GetString(2)}");
                //Console.WriteLine($"Phone No - {reader.GetInt64(3)}");


            }

            reader1.Close();
            conn.Close();
        }



    }
}
