using System.Numerics;
using System.Xml.Linq;
using DataEf;
using Models;
using static Azure.Core.HttpHeader;
using System.Collections.Generic;


namespace BusinessLogic;
public class Login
{

    public int LoginSubmit(string EmailID, string Password)
    {
        int usid = 0;
        DataEf.Entities.YugarajContext yugarajContext = new DataEf.Entities.YugarajContext();

        var query = from b in yugarajContext.Users where b.EmailId == EmailID && b.Password == Password select b;

        foreach (var q in query)
        {
            usid = q.UserId;

        }

        if (usid > 0)
        {
            return usid;
        }

        else
        {
            return usid;
        }
    }


    public int SignUpSubmit(UserModel user)
    {
        DataEf.Entities.YugarajContext yugarajContext = new DataEf.Entities.YugarajContext();
        DataEf.Entities.User user1 = new DataEf.Entities.User();

        user1.FirstName = user.FirstName;
        user1.LastName = user.LastName;
        user1.EmailId = user.EmailId;
        user1.Password = user.Password;
        user1.PhoneNo = user.PhoneNo;

        yugarajContext.Users.Add(user1);
        int i = yugarajContext.SaveChanges();
        return i;
    }

    public IQueryable<DataEf.Entities.User> SignUpUser()
    {
        DataEf.Entities.YugarajContext yugarajContext = new DataEf.Entities.YugarajContext();

        var query = from b in yugarajContext.Users select b;

        return query;

    }
}








public class LoginClass
{
    public string EmailID { get; set; }
    public string Password { get; set; }

}

