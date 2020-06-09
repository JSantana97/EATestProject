using EAAutoFramework.Base;
using EAAutoFramework.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace EAEmployeeTest.Pages
{
    internal class HomePage : BasePage
    {

        //Objects for the login page
        [FindsBy(How = How.LinkText, Using = "Iniciar sesión")]
        IWebElement lnkLogin { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='_5afe'])[3]")]
        IWebElement lnkMessenger { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='_5afe'])[1]")]
        IWebElement lnkLoggedInUser { get; set; }

        [FindsBy(How = How.XPath, Using = "(//*[@class='_5afe'])[4])")]
        IWebElement lnkWatch { get; set; }

        [FindsBy(How = How.XPath, Using = "(//div[contains(text(),'Messenger')])[1]")]
        IWebElement messengerexist { get; set; }

        internal void CheckInfMessengerExist()
        {
            messengerexist.AssertElementPresent();
        }

        public Messenger ClickMessenger()
        {
                DriverContext.Driver.WaitForPageLoaded();
            lnkMessenger.Click();
            return GetInstance<Messenger>();
        }
        
        internal string GetLoggedInUser()
        {
            return lnkLoggedInUser.GetLinkText();
        }
    }
}
