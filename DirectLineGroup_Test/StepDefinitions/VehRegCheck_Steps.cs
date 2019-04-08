using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Test_Automation.PageObjects;

namespace Test_Automation
{
    [Binding]
    class VehRegCheck_Steps
    {
        [Given(@"I am on insurance portal page")]
        public void GivenIAmOnInsutancePortalPage()
        {
            VegRegCheck_Page.NavigateToHomePage();
        }
        [When(@"I enter vehicle registration number ""(.*)""")]
        public void GivenIHaveVehicleRegistrationNumber(string Regnum)
        {
            VegRegCheck_Page.EnterVehicleRegNum(Regnum);
        }
        [When(@"I click on Find Vehicle")]
        public void WhenIClickOnFindVehicle()
        {
            VegRegCheck_Page.ClickOnFindVehicle();
        }
        [Then(@"I should able to see vehicle registration number ""(.*)""")]
        public void ThenIShouldAblToSeeVehicleRegistrationNum(string Regnum)
        {
            VegRegCheck_Page.VerifyVehRegnum(Regnum);
        }
    }
}
