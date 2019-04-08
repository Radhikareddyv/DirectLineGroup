using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Automation.Support;

namespace Test_Automation.PageObjects
{
    public class VegRegChech_PageObjects
    {
        public static IWebElement EnterValueObject()
        {
            IWebElement element = Driver.Instance.FindElement(By.XPath("//input[@id='vehicleReg']"));
            return element;
        }
        public  static IWebElement ClickOnVehicle()
        {
            IWebElement element = Driver.Instance.FindElement(By.XPath("//button[@name='btnfind']"));
            return element;
        }
        public static IWebElement VerifyResultObject(string num)
        {
            IWebElement element = Driver.Instance.FindElement(By.XPath("//div[@class='result']"));
            return element;
        }

       
    }
}
