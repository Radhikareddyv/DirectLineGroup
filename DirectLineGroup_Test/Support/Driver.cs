using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Automation.Support
{
    class Driver
    {
        public static IWebDriver Instance { get; set; }

        public static string BaseAddress
        {
            get { return ConfigurationManager.AppSettings["Url"].ToString(); }
        }
        public static void Initialize()
        {
            Instance = new ChromeDriver();
            Instance.Manage().Window.Maximize();
            var chromeOptions = new ChromeOptions();
        }
        public static void Navigate()
        {
            Instance.Navigate().GoToUrl(BaseAddress);
        }
        public static void close()
        {
            Instance.Close();
            Instance.Quit();
            Instance.Dispose();
        }
        public static void WaitForPageToLoad()
        {
            Driver.Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
    }
 }
