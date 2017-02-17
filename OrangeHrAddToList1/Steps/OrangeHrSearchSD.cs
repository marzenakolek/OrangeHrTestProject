using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OrangeHrAddToList1.PageObject_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace OrangeHrAddToList1.Steps
{
     [Binding]
    public sealed class OrangeHrSearchSD
    {
        OrangeHrSearchPOM _searchPage = new OrangeHrSearchPOM(Environment.Driver);
        private string itemDisplayTextExpect;

        [Given(@"Given the user is on SiteUrl: ""(.*)""")]
        public void GivenGivenTheUserIsOnSiteUrl(string p0)
        {
            Environment.Driver.Navigate().GoToUrl(p0);
        }
        [Given(@"Admin click on Admni button")]
        public void GivenAdminClickOnAdmniButton()
        {
            _searchPage.btnAdminModule.Click();
        }

        [Given(@"Admin clik on Organiztion dropdown")]
        public void GivenAdminClikOnOrganiztionDropdown()
        {
            _searchPage.btnOrganization.Click();
        }

        [Given(@"Admin sellect Locations")]
        public void GivenAdminSellectLocations()
        {
            _searchPage.btnLocation.Click();
        }

        [Given(@"He enters Location Name: ""(.*)""")]
        public void GivenHeEntersLocationName(string p0)
        {
            _searchPage.btnLocationbox.SendKeys(p0);
        }
        [When(@"he click search button")]
        public void WhenHeClickSearchButton()
        {
            _searchPage.btnSearch.Click();
        }

        [Then(@"he check if location is selected: ""(.*)""")]
        public void ThenHeCheckIfLocationIsSelected(string itemDisplayTextExpect)
        {
            Assert.AreEqual(true, _searchPage.Location.Any((item) => item.Text.Contains(itemDisplayTextExpect)));
        }

    }
}
