using System;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
//using AutoTests.Base;

namespace AutoTests
{
    class Program
    {
     //   private static startSession _startSession;

        static void Main(string[] args)
        {
            WindowsDriver<WindowsElement> ritaSession;
            AppiumOptions appOptions = new AppiumOptions();

            appOptions.AddAdditionalCapability("app", @"C:\Users\Daniel Morgan\Documents\Rita\Test\Test\PAMV4.exe");
            ritaSession = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), appOptions);
            ritaSession.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);





            //ritaSession.FindElementByName("OK").Click();
            //ritaSession.FindElementByName("Main").Click();

            //ritaSession.FindElementByName("Recent Calls").Click();
            //ritaSession.FindElementByName("OK").Click();

            //ritaSession.FindElementByName("Callers").Click();

            //ritaSession.FindElementByName("Reminders").Click();

            //ritaSession.FindElementByName("Related Docs").Click();

            //ritaSession.FindElementByName("Admin").Click();

            //ritaSession.FindElementByName("Merge...").Click();

            //ritaSession.FindElementByName("User Activity").Click();


        }
    }
}
