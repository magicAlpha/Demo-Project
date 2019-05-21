using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using NUnitFramework.Common;
using NUnitFramework.Pages;
using NUnitFramework.Utils;

namespace NUnitFramework.Tests
{
    class GmailTest : TestBase
    {
        public GmailTest() : base()
        {

        }

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("This is to test");
        }

        [Test]
        public void GmailLogin()
        {
            string emailID;
            string password;
            bool testResult;
            emailID = TestData.GetData("User_14EmailAddress");
            password = TestData.GetData("GmailUser_Test1Password");
            //subject = TestData.GetData("GmailMailSubject_ConfirmYourWithdraw");
            GmailPage gmailObj = new GmailPage(TestProgressLogger);
            testResult = gmailObj.Gmail(emailID, password, "Withdraw");
            Assert.True(testResult);
        }

        [TearDown]
        public void End()
        {
            driver.Quit();
        }
    }
}
