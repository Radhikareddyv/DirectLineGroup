using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Test_Automation.Support;

namespace Test_Automation.PageObjects
{
    public class VegRegCheck_Page
    {
        public static void NavigateToHomePage()
        {
            Driver.Instance.Navigate().GoToUrl(Driver.BaseAddress);
            
        }
        public  static void EnterVehicleRegNum(string Regnum)
        {
            VegRegChech_PageObjects.EnterValueObject().SendKeys(Regnum);
        }

        public static void ClickOnFindVehicle()
        {
            VegRegChech_PageObjects.ClickOnVehicle().Click();
        }

        public static void VerifyVehRegnum(string Regnum)
        {
            Driver.WaitForPageToLoad();
           Assert.IsTrue(VegRegChech_PageObjects.VerifyResultObject(Regnum).Displayed);
        }

       
    }
}
