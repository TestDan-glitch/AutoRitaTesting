using System;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Windows;

namespace AutoTests
{
    public class appSesssion
    {

            //    IWebDriver driver = new RemoteWebDriver();
            public static void startSession()
            { 
                WindowsDriver<WindowsElement> ritaSession;
                AppiumOptions appOptions = new AppiumOptions();

                appOptions.AddAdditionalCapability("app", @"C:\Users\Daniel Morgan\Documents\Rita\Test\Test\PAMV4.exe");
                ritaSession = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723"), appOptions);


                ritaSession.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


                ritaSession.FindElementByName("OK").Click();

            }
    }
}