using NUnit.Framework;
using Tests.TestData;

namespace Tests
{
    [TestFixture]
    public class LogInTest : ATest
    {
        private static readonly object[] ValidUser =
        {
            new object[] {
            UserRepository.Get().DjinniUser() }
        };

        [Test, TestCaseSource(nameof(ValidUser))]
        public void LogInTest1(IUser user)
        {
            Pages.DjinniStartPageOperations.ClickLoginButton().LogInIntoSystem(user.LoginName, user.Password).
                VerifyUserEmailHeader(user.LoginName);
        }
    }
}
