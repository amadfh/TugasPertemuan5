using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TugasLibrary;
using NUnit.Framework;

namespace TugasLibraryUnitTest
{
    class UserTest
    {
        
        private User user;

        [SetUp]
        public void Init()
        {
            user = new User();
        }

        [Test]
        public void IsValidUser()
        {
            //Assert.IsTrue(user.IsValidUser("admin", "admin"));
            Assert.IsTrue(user.IsValidUser("admin", "admin"));
            Assert.IsFalse(user.IsValidUser("admin", "paijo"));
        }
    }
}
