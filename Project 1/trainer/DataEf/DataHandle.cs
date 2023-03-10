using System;
using System.Linq;


namespace DataEf
{

    public class DataHandle
    {
        //using (var db = new UniContextEntities()) {
        //using (var db = new Entities.YugarajContext())


        public int id;
        public string name;

        //public DataHandle()
        //{
        //    using (var db = new Entities.YugarajContext())
        //    {
        //        var query = from b in db.Users select b;

        //        foreach (var item in query)
        //        {
        //            Console.WriteLine(item.EmailId);
        //        }
        //    }
        //}

        public LoginClass DataHandleLogin(string email, string pass)
        {
            using (var db = new Entities.YugarajContext())
            {
                var query = from b in db.Users where b.EmailId == email && b.Password == pass select b;


                foreach (var item in query)
                {
                    //Console.WriteLine(item.EmailId);
                    id = item.UserId;
                    name = item.FirstName;
                }

            }

            return new LoginClass(id, name);
        }

        public void DataHandleSignUp(string fname, string lname, string email, string pass, Int64 phone)
        {
            Entities.YugarajContext cnt = new Entities.YugarajContext();
            Entities.User user = new Entities.User();

            user.FirstName = fname;
            user.LastName = lname;
            user.EmailId = email;
            user.Password = pass;
            user.PhoneNo = phone;

            cnt.Users.Add(user);

            int i = cnt.SaveChanges();

            if (i > 0)
            {
                Console.WriteLine("User created success fully");
            }
            else
            {
                Console.WriteLine("Unable to create user");
            }

        }

        //Adding
        public void UserProfileAdd(DataEf.Entities.Edu ed)
        {
            Entities.YugarajContext cnt = new Entities.YugarajContext();
            Entities.Edu edu = new Entities.Edu();
            cnt.Edus.Add(ed);
            int j = cnt.SaveChanges();

            if (j > 0)
            {
                Console.WriteLine("Education Added Sucessfully");
            }
            else
            {
                Console.WriteLine("Unable to add");
            }
        }

        public void UserProfileAdd(DataEf.Entities.Comp cp)
        {
            Entities.YugarajContext cnt = new Entities.YugarajContext();
            Entities.Comp cert = new Entities.Comp();
            cnt.Comps.Add(cp);
            int j = cnt.SaveChanges();
            if (j > 0)
            {
                Console.WriteLine("Experience Added sucessfully");
            }
            else
            {
                Console.WriteLine("Unable to add");
            }

        }

        //Update
        public void UserProfileUpdate(DataEf.Entities.Edu edu)
        {
            Entities.YugarajContext cnt = new Entities.YugarajContext();
            Entities.Edu edu1 = new Entities.Edu();
            cnt.Edus.Update(edu);
            int j = cnt.SaveChanges();
            if (j > 0)
            {
                Console.WriteLine("Education updated successfully");
            }
            else
            {
                Console.WriteLine("Unable to update");
            }

        }


    }


}



