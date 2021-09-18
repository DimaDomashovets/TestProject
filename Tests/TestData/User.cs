using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.TestData
{

    public interface ILoginName
    {
        IPassword SetLoginName(string loginName);
    }

    public interface IPassword
    {
        User SetPassword(string password);
    }

    public class User: ILoginName, IPassword, IUser
    {
        public string LoginName { get; set; }
        public string Password { get; set; }

        public static ILoginName Get()
        {
            return new User();
        }


        public IPassword SetLoginName(string loginName)
        {
            LoginName = loginName;
            return this;
        }

        public User SetPassword(string password)
        {
            Password = password;
            return this;
        }

        public IUser Build()
        {
            return this;
        }
    }
}
