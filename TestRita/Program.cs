using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;

namespace TestRita
{
    class Program
    {
        static void Main(string[] args)
        {
        //    IWebDriver driver = new RemoteWebDriver();

            WindowsDriver<WindowsElement> ritaSession;
            AppiumOptions appOptions = new AppiumOptions();

            appOptions.AddAdditionalCapability("app", @"C:\Users\Daniel Morgan\Documents\Rita\Test\Test\PAMV4.exe");
            ritaSession = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), appOptions);

            ritaSession.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            ritaSession.FindElementByName("OK").Click();
            ritaSession.FindElementByName("Main").Click();

            ritaSession.FindElementByName("Recent Calls").Click();
            ritaSession.FindElementByName("OK").Click();

            ritaSession.FindElementByName("Callers").Click();

            ritaSession.FindElementByName("Reminders").Click();

            ritaSession.FindElementByName("Related Docs").Click();

            ritaSession.FindElementByName("Admin").Click();

            ritaSession.FindElementByName("Merge...").Click();

            ritaSession.FindElementByName("User Activity").Click();


        }
    }
}
