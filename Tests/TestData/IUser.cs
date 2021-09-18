using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.TestData
{
    public interface IUser
    {
        string LoginName { get; }
        string Password { get; }
    }
}
