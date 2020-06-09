using EAAutoFramework.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using EAAutoFramework.Extensions;
using System;

namespace EAEmployeeTest.Pages
{
    class LoginPage : BasePage
    {

        [FindsBy(How = How.Id, Using = "email")]
        IWebElement txtemail { get; set; }

        [FindsBy(How = How.Id, Using = "pass")]
        IWebElement txtpassword { get; set; }

        [FindsBy(How = How.Id, Using = "loginbutton")]
        IWebElement loginbutton { get; set; }

        public void Login (string email, string pass)
        {
            txtemail.SendKeys(email);
            txtpassword.SendKeys(pass);
        }

        public HomePage ClickLoginButton()
        {
            loginbutton.Submit();
            return GetInstance<HomePage>();
        }
    }
}
