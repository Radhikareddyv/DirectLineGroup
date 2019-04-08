using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Test_Automation.Support
{
    [Binding]
    class TestHooks
    {
        [BeforeFeature]
        public static void FeatureSetup()
        {
            Driver.Initialize();
        }
        [AfterFeature]
        public static void FeatureTeardown()
        {
            Driver.close();
        }
    }
}

