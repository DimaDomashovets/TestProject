using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.TestData
{
    public sealed class UserRepository
    {
        private static UserRepository instance;
        private static object lockingObject = new object();

        public static UserRepository Get()
        {
            if(instance == null)
            {
                lock (lockingObject)
                {
                    if(instance == null)
                    {
                        instance = new UserRepository();
                    }
                }
            }
            return instance;
        }

        public IUser DjinniUser()
        {
            return User.Get().
                SetLoginName("ddomashovets@ukr.net").
                SetPassword("123456789qwe");
        }
    }
}
