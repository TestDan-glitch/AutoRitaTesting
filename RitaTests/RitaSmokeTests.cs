using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
using TestContext = Microsoft.VisualStudio.TestTools.UnitTesting.TestContext;

namespace RitaTests
{
    [TestClass]
    public class IntegrationTests
    {
        static WindowsDriver<WindowsElement> ritaSession;

        [ClassInitialize]
        public static void PrepareForRitaTesting(TestContext testContext)
        {
            Debug.WriteLine("ClassInitialize Open Rita");
            
            AppiumOptions appOptions = new AppiumOptions();
            appOptions.AddAdditionalCapability("app", @"C:\Users\Daniel Morgan\Documents\Rita\Test\Test\PAMV4.exe");
            ritaSession = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), appOptions);

            ritaSession.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            ritaSession.FindElementByName("OK").Click();
        }

        [TestInitialize]
        public void BeforeATest()
        {
            /********************** Reopens Rita before every single test ********************/
            //Debug.WriteLine("TestInitialize Before a test, calling TestInitialize");
            //AppiumOptions appOptions = new AppiumOptions();
            //appOptions.AddAdditionalCapability("app", @"C:\Users\Daniel Morgan\Documents\Rita\Test\Test\PAMV4.exe");
            //ritaSession = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), appOptions);
            //ritaSession.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(15);
            //ritaSession.FindElementByName("OK").Click();
        }

        [ClassCleanup]
        public static void CleanupAfterRitaTests()
        {
            Debug.WriteLine("ClassCleanup Close Rita");
            ritaSession.FindElementByName("Close").Click();
            ritaSession.FindElementByName("Yes").Click();
        }

        [TestCleanup]
        public void AfterATest()
        {
            /********************** Closes Rita after every single test ********************/
            //Debug.WriteLine("TestCleanup After a test, calling TestCleanup");
            //ritaSession.FindElementByName("Close").Click();
            //ritaSession.FindElementByName("Yes").Click();
        }

        [TestMethod]
        public void Main()
        {
            var btnMainTab = ritaSession.FindElementByAccessibilityId("MainTabItem");
            btnMainTab.Click();
            Assert.AreEqual("Main", btnMainTab.Text);

            ritaSession.FindElementByAccessibilityId("Btn_EmpListFilterAll").Click();
            ritaSession.FindElementByAccessibilityId("Txt_EmpListFirst").Click();
            ritaSession.FindElementByAccessibilityId("Txt_EmpListFirst").SendKeys("saturday & sunday" + Keys.Escape);
            ritaSession.FindElementByName("IT").Click();
            ritaSession.FindElementByName("Employees").Click();
            ritaSession.FindElementByAccessibilityId("Btn_EmpListFilterTypes").Click();
        }

        [TestMethod]
        public void RecentCalls()
        {
            Debug.WriteLine("Open Recent Calls Tab");
            var btnRecentCallsTab = ritaSession.FindElementByName("Recent Calls");
            btnRecentCallsTab.Click();
            ritaSession.FindElementByName("OK").Click();

           Assert.AreEqual("Recent Calls", btnRecentCallsTab.Text);

        }

        [TestMethod]
        public void Callers()
        {
            Debug.WriteLine("Callers Tab");
            var btnCallersTab = ritaSession.FindElementByName("Callers");
            btnCallersTab.Click();

            Assert.AreEqual("Callers", btnCallersTab.Text);
        }

        [TestMethod]
        public void Reminders()
        {
            Debug.WriteLine("Reminders Tab");
            var btnCallersTab = ritaSession.FindElementByName("Reminders");
            btnCallersTab.Click();

            Assert.AreEqual("Reminders", btnCallersTab.Text);
        }

        [TestMethod]
        public void RelatedDocs()
        {
            Debug.WriteLine("Related Docs");
            var btnRelatedDocsTab = ritaSession.FindElementByName("Related Docs");
            btnRelatedDocsTab.Click();

            Assert.AreEqual("Related Docs", btnRelatedDocsTab.Text);
        }

        [TestMethod]
        public void Admin()
        {
            Debug.WriteLine("Admin Tab");
            var btnAdminTab = ritaSession.FindElementByName("Admin");
            btnAdminTab.Click();

            Assert.AreEqual("Admin", btnAdminTab.Text);
        }

        [TestMethod]
        public void Merge()
        {
            Debug.WriteLine("Merge...Tab");
            var btnMergeTab = ritaSession.FindElementByName("Merge...");
            btnMergeTab.Click();

            Assert.AreEqual("Merge...", btnMergeTab.Text);
        }

        [TestMethod]
        public void UserActivity()
        {
            Debug.WriteLine("User Activity Tab");
            var btnUserActivityTab = ritaSession.FindElementByName("User Activity");
            btnUserActivityTab.Click();

            Assert.AreEqual("User Activity", btnUserActivityTab.Text);
        }
    }
}
