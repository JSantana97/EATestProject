using System;
using EAAutoFramework.Base;
using EAAutoFramework.Helpers;
using EAEmployeeTest.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using EAAutoFramework.Config;

namespace EAEmployeeTest
{
    [TestClass]
    public class UnitTest1 : HookInitialize
    {
        //string url = ConfigReader.InitializeTest();
        //private IWebDriver driver;

        //public void OpenBrowser(BrowserType browserType = BrowserType.Chrome)
        //{
            //switch (browserType)
            //{
                //case BrowserType.InternetExplorer:
                    //DriverContext.Driver = new InternetExplorerDriver();
                    //DriverContext.Browser = new Browser(DriverContext.Driver);
                    //break;
                //case BrowserType.FireFox:
                    //DriverContext.Driver = new FirefoxDriver();
                    //DriverContext.Browser = new Browser(DriverContext.Driver);
                    //break;
                //case BrowserType.Chrome:
                    //DriverContext.Driver = new ChromeDriver();
                    //DriverContext.Browser = new Browser(DriverContext.Driver);
                    //break;
                //default:
                    //DriverContext.Driver = new ChromeDriver();
                    //DriverContext.Browser = new Browser(DriverContext.Driver);
                    //break;
            //}
        //}

        [TestMethod]
        public void TestMethod1()
        {

            //ConfigReader.SetFrameworkSettings();
            
            //DriverContext.Driver = new ChromeDriver();
            //DriverContext.Driver.Navigate().GoToUrl(url);

            string fileName = @"C:\Users\Titanium\Documents\UdemyCJ\EATestProject\EAEmployeeTest\Data\Login.xlsx";

            ExcelHelpers.PopulateInCollection(fileName);           
            //LogHelpers.CreateLogFile();

            //ChromeOptions ops = new ChromeOptions();
            //ops.AddArguments("--disable-notifications");
            //System.Environment.SetEnvironmentVariable("webdriver.chrome.driver", @"C:\Users\Titanium\Documents\UdemyCJ\EATestProject\chromedriver.exe");
            //driver = new ChromeDriver(ops);

            //OpenBrowser(BrowserType.FireFox);
            //LogHelpers.Write("Opened the browser !!!");
            
            //DriverContext.Browser.GoToUrl(Settings.AUT);
            //LogHelpers.Write("Navigated to the page !!!");

            //LoginPage page = new LoginPage();
            //page.Login("", "");

            //Messenger messengerchat = page.ClickMessenger();
            //messengerchat.ClickProfile();

            //CurrentPage = page.ClickMessenger();
            //((Messenger)CurrentPage).ClickProfile();

            //Login();

            CurrentPage = GetInstance<LoginPage>();
            CurrentPage.As<LoginPage>().Login(ExcelHelpers.ReadData(1, "email"), ExcelHelpers.ReadData(1, "pass"));
            //driver.FindElement(By.XPath("//a[@href='https://www.facebook.com/messages/t/']"));
            //WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(10));
            //IWebElement firstResult = wait.Until(e => e.FindElement(By.XPath("//a[@href='https://www.facebook.com/messages/t/']")));
            //Messenger
            //Messenger messengerchat = page.ClickMessenger();
            CurrentPage = CurrentPage.As<LoginPage>().ClickMessenger();
            //CurrentPage.As<LoginPage>().CheckInfMessengerExist();
            CurrentPage.As<Messenger>().ClickProfile();
        }

        //public void Login()
        //{

            //_driver.FindElement(By.LinkText("Iniciar sesión")).Click();

            //UserName
            //_driver.FindElement(By.Id("email")).SendKeys("");
            //_driver.FindElement(By.Id("pass")).SendKeys("");

            //Click Login
            //_driver.FindElement(By.Id("loginbutton")).Submit();

            //LoginPage page = new LoginPage();

            //page.ClickLoginLink();
            //page.Login("", "");

            //Messenger messengerchat = page.ClickMessenger();
            //messengerchat.ClickNewmsg();
        //}
    }
}
