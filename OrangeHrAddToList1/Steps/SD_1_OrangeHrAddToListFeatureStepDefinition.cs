using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace OrangeHrAddToList1.Steps
{
    [Binding]
    public sealed class SD_1_OrangeHrAddToListFeatureStepDefinition
    {
        OrangeHrAddToListPOM _AddtoList = new OrangeHrAddToListPOM(Environment.Driver);

        [Given(@"user is on page:""(.*)""")]
        public void GivenUserIsOnPage(string p0)
        {
            Environment.Driver.Navigate().GoToUrl(p0);
        }

        [Given(@"click Add buttom")]
        public void GivenClickAddButtom()
        {
            _AddtoList.AddButton.Click();
        }

        [Given(@"goes on page: ""(.*)""")]
        public void GivenGoesOnPage(string p1)
        {
            Assert.AreEqual(p1, "admin/location");
        }
        [Given(@"user enter: ""(.*)"" as Name")]
        public void GivenUserEnterAsName(string p2)
        {
            _AddtoList.location_name.SendKeys(p2);
        }

        [Given(@"enter: ""(.*)"" as State")]
        public void GivenEnterAsState(string p3)
        {
            _AddtoList.location_province.SendKeys(p3);
        }

        [Given(@"enter: ""(.*)"" as City")]
        public void GivenEnterAsCity(string p4)
        {
            _AddtoList.location_city.SendKeys(p4);
        }

        [Given(@"enter:""(.*)"" as Adrres")]
        public void GivenEnterAsAdrres(string p5)
        {
            _AddtoList.location_city.SendKeys(p5);
        }

        [Given(@"enter: ""(.*)"" as Zip Code")]
        public void GivenEnterAsZipCode(string p6)
        {
            _AddtoList.location_zipCode.SendKeys(p6);
        }

        [Given(@"enter: ""(.*)"" as Phone")]
        public void GivenEnterAsPhone(int p7)
        {
            _AddtoList.location_phone.GetType();
        }

        [Given(@"enter: ""(.*)"" as  Fax")]
        public void GivenEnterAsFax(int p0)
        {
            _AddtoList.location_fax.GetType();
        }

        [Given(@"enter: ""(.*)"" as Notes")]
        public void GivenEnterAsNotes(string p8)
        {
            _AddtoList.location_notes.SendKeys(p8);
        }

        [Given(@"sellect ""(.*)"" in Country")]
        public void GivenSellectInCountry(string p9)
        {
            SelectElement select = new SelectElement(_AddtoList.location_country);
            select.SelectByText("Poland");
        }

        [Given(@"sellect ""(.*)"" in Time Zone")]
        public void GivenSellectInTimeZone(string p10)
        {
            SelectElement select = new SelectElement(_AddtoList.location_timeZone);
            select.SelectByText("Europe/Rome");
        }
        [When(@"click Save button")]
        public void WhenClickSaveButton()
        {
            _AddtoList.Savebutton.Click();
        }

        [Then(@"new location is added to list")]
        public void ThenNewLocationIsAddedToList()
        {
            //string location = "Jan Kowalski";
            //List<String> exp_options = new List<string>() { location };
            //Assert.AreEqual(true, location.Contains(location)); 

            //if(czy strona posiada "Already exists" w //*[@id="location_name-error"]) { false }
            // else { wyszukać i sprawdzić w gridzie }

            //IWrapsElement test = _AddtoList.incorrectmessage as IWrapsElement;

            //var test1 = Environment.Driver.FindElement(_AddtoList.incorrectmessage.GetAttribute())
            // _AddtoList.incorrectmessage


            IWebElement incorrectmessage = null;
            try
            {
                incorrectmessage = Environment.Driver.FindElement(By.CssSelector("#location_name-error"));
            }
            catch(Exception ex) { }

            if (incorrectmessage != null)
            {
                Assert.AreEqual(true, incorrectmessage.Text.Contains("Already exists"));
            }
            else
            {
                var gridElements = Environment.Driver.FindElements(By.CssSelector("#resultTable > tbody > tr > td:nth-child(2)"));

            }
        }
    }
}
