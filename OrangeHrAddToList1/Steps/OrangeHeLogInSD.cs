using NUnit.Framework;
using OrangeHrAddToList1.PageObject_Model;
using TechTalk.SpecFlow;

namespace OrangeHrAddToList1.Steps
{
    [Binding]
    public sealed class OrangeHeLogInSD
    {
        OrangeHrLogInPOM _pageLogIn = new OrangeHrLogInPOM(Environment.Driver);

        [Given(@"the user is on SiteUrl: ""(.*)""")]
        public void GivenTheUserIsOnSiteUrl(string webpage)
        {
        }

        [Given(@"he enters (.*)")]
        public void GivenHeEnters(string name)
        {
            _pageLogIn.txtUsername.SendKeys(name);
        }

        [Given(@"user enters (.*)")]
        public void GivenUserEnters(string password)
        {
            _pageLogIn.txtPassword.SendKeys(password);
        }


        [Given(@"click Login button")]
        public void GivenClickLoginButton()
        {
            _pageLogIn.btnLogin.Click();
        }

        [When(@"user is on page:""(.*)""")]
        public void WhenUserIsOnPage(string webpage)
        {
            Assert.AreEqual(webpage, Environment.Driver.Url);
        }


        [Given(@"the user is on page: ""(.*)""")]
        public void GivenTheUserIsOnPage(string webpage)
        {
            Environment.Driver.Navigate().GoToUrl(webpage);
        }


        [When(@"he enters ""(.*)"" as Username")]
        public void WhenHeEntersAsUsername(string name)
        {
            _pageLogIn.txtUsername.SendKeys(name);
        }

        [When(@"he enters ""(.*)"" as Password")]
        public void WhenHeEntersAsPassword(string password)
        {
            _pageLogIn.txtPassword.SendKeys(password);
        }

        [When(@"click Login button")]
        public void WhenClickLoginButton()
        {
            _pageLogIn.btnLogin.Click();
        }

        [Then(@"box ""(.*)"" is dysplayed")]
        public void ThenBoxIsDysplayed(string p0)
        {
            Assert.AreEqual(p0, Environment.Driver.Url);
        }

    }
}
