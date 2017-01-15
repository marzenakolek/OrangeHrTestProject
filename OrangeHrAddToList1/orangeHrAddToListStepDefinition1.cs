using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace OrangeHrAddToList1
{
    [Binding]
    public sealed class orangeHrAddToListStepDefinition1
    {
        [Given(@"user is on page:""(.*)""")]
        public void GivenUserIsOnPage(string siteUrl)
        {
            Environment.Driver.Navigate().GoToUrl($"{Utils.Utils.SiteUrl}{siteUrl}");
        }

        [When(@"click Add buttom")]
        public void WhenClickAddButtom()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"goes on page: ""(.*)""")]
        public void ThenGoesOnPage(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"user enters valid credentials:")]
        public void WhenUserEntersValidCredentials(Table table)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"sellect (.*)")]
        public void WhenSellect(string p0)
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"click Save button")]
        public void WhenClickSaveButton()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"new location is added to list")]
        public void ThenNewLocationIsAddedToList()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
