using System;
using System.Data.SqlClient;
using System.IO;
using System.Data;

namespace Data
{
    public class SqlHandle
    {
        //private string connection = null;
        private string Connection = File.ReadAllText(@"C:\Users\SURYA\Training\sqlid.txt");
        public int UserId;
        public string SkillName;
        public string UserNameLogin;



        public int SqlQueryWriter(string q)
        {
            using SqlConnection con = new SqlConnection(Connection);

            con.Open();
            //Console.WriteLine(q);
            SqlCommand cmd = new SqlCommand(q, con);
            using SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                Console.WriteLine(reader.GetInt32(0));
                UserId = reader.GetInt32(0);

            }
            //Console.WriteLine(reader);
            con.Close();
            return UserId;
        }

        public string SqlQueryWriterName(string q)
        {
            using SqlConnection con = new SqlConnection(Connection);

            con.Open();
            //Console.WriteLine(q);
            SqlCommand cmd = new SqlCommand(q, con);
            using SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                UserNameLogin = reader.GetString(1);


            }
            return UserNameLogin;
        }

        public string SqlQueryWriterSkill(string q)
        {
            using SqlConnection con = new SqlConnection(Connection);

            con.Open();
            SqlCommand cmd = new SqlCommand(q, con);
            using SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {


                SkillName = reader.GetString(1);


            }

            return SkillName;
        }

        public DataTable SqlQeryWriterSkillUpdate(string q)
        {
            using SqlConnection con = new SqlConnection(Connection);

            con.Open();
            //Console.WriteLine(q);
            SqlCommand cmd = new SqlCommand(q, con);
            //SqlDataAdapter reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            using (SqlDataAdapter a = new SqlDataAdapter(cmd))
            {
                a.Fill(dt);
            }

            return dt;

        }


        public void sqlQueryDelete(string q)
        {
            using SqlConnection con = new SqlConnection(Connection);
            con.Open();
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            con.Close();


        }


    }


}