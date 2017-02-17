using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHrAddToList1
{
    class OrangeHrAddToListPOM
    {
        private IWebDriver Driver { get; set; }
        public OrangeHrAddToListPOM(IWebDriver Driver)
        {

            PageFactory.InitElements(Driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//*[@id='btnAdd']")]
        public IWebElement AddButton { get; set; }
        [FindsBy(How = How.Id, Using = "location_name")]
        public IWebElement location_name { get; set; }
        [FindsBy(How = How.Id, Using = "location_province")]
        public IWebElement location_province { get; set; }
        [FindsBy(How = How.Id, Using = "location_country")]
        public IWebElement location_country { get; set; }
        [FindsBy(How = How.Id, Using = "location_timeZone")]
        public IWebElement location_timeZone { get; set; }
        [FindsBy(How = How.Id, Using = "location_city")]
        public IWebElement location_city { get; set; }
        [FindsBy(How =How.Id, Using = "location_address")]
        public IWebElement location_address { get; set; }
        [FindsBy(How = How.Id, Using = "location_zipCode")]
        public IWebElement location_zipCode { get; set; }
        [FindsBy(How = How.Id, Using = "location_phone")]
        public IWebElement location_phone { get; set; }
        [FindsBy(How = How.Id, Using = "location_fax")]
        public IWebElement location_fax { get; set; }
        [FindsBy(How = How.Id, Using = "location_notes")]
        public IWebElement location_notes { get; set; }
        [FindsBy(How = How.Id, Using = "btnSave")]
        public IWebElement Savebutton { get; set; }
        [FindsBy(How = How.Id, Using = "resultTable")]
        public IList <IWebElement> List { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='location_name - error']")]
        public IWebElement incorrectmessage { get; set; }
    }
}
