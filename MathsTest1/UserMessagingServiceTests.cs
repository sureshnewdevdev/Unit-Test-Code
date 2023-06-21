using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using DataServiceLib;

namespace MVCTests
{
    [TestClass()]
    public class UserMessagingServiceTests
    {
        UserMessagingService userMessagingService; // the class to be tested
        

        [TestInitialize]
        public void Init()
        {
            Mock<IDababaseConnector> mockDabaseConnector = new Mock<IDababaseConnector>();
            mockDabaseConnector.Setup(m => m.GetMessageFromMsgTble()).Returns(LocalGetMessageTestData);


            userMessagingService = new UserMessagingService(mockDabaseConnector.Object);
            
        }

        private string LocalGetMessageTestData()
        {
            return "This message is for testing data";
        }

        [TestMethod()]
        public void GetMessageFromDBTest()
        {
            string msg = userMessagingService.GetMessageFromDB();
            string expectedString = "This message is for testing data";
            Assert.AreEqual(expectedString, msg);
            Assert.IsTrue(msg.Count() > 0);
        }

        [TestMethod()]
        public void Welcome_User_Test_SuccessFull()
        {
            string msg = userMessagingService.GetWelcomeUserMsg("2");

            Assert.IsTrue(msg.Count() > 0);
        }

        [TestMethod()]
        public void Welcome_User_Test_SuccessFull_With_Any_Paramenter()
        {
            Mock<IDababaseConnector> mockDabaseConnector = new Mock<IDababaseConnector>();
            mockDabaseConnector.Setup(m => m.WelcomeMsg(It.IsAny<string>())).Returns("Common name");
            userMessagingService = new UserMessagingService(mockDabaseConnector.Object);

            string msg = userMessagingService.GetWelcomeUserMsg("rajee");

            Assert.IsTrue(msg.Count() > 0);
        }

        [TestMethod()]
        public void Welcome_User_Test_SuccessFull_With_Existing_UserId_As_Paramenter()
        {
            Mock<IDababaseConnector> mockDabaseConnector = new Mock<IDababaseConnector>();
            mockDabaseConnector.Setup(m => m.WelcomeMsg("1")).Returns("A");
            userMessagingService = new UserMessagingService(mockDabaseConnector.Object);
            string msg = userMessagingService.GetWelcomeUserMsg("1");

            Assert.AreEqual("A", msg);
            Assert.IsTrue(msg.Count() > 0);
        }

        [TestMethod()]
        public void Welcome_User_Test_SuccessFull_With_Existing_UserId_As_Empty()
        {
            Mock<IDababaseConnector> mockDabaseConnector = new Mock<IDababaseConnector>();
            mockDabaseConnector.Setup(m => m.WelcomeMsg("")).Returns("User not found");
            userMessagingService = new UserMessagingService(mockDabaseConnector.Object);
            string msg = userMessagingService.GetWelcomeUserMsg("1");

            Assert.AreEqual("User not found", msg);
            Assert.IsTrue(msg.Count() > 0);
        }

    }
}