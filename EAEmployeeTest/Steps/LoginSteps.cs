using System;
using TechTalk.SpecFlow;
using EAAutoFramework.Base;
using EAEmployeeTest.Pages;
using TechTalk.SpecFlow.Assist;

namespace EAEmployeeTest.Steps
{
    [Binding]
    public class LoginSteps : BaseStep
    {
        [Given(@"I have navigated to the application")]
        public void GivenIHaveNavigatedToTheApplication()
        {
            NavigateSite();
            CurrentPage = GetInstance<HomePage>();
        }
        
        [Given(@"I see application opened")]
        public void GivenISeeApplicationOpened()
        {
            CurrentPage.As<HomePage>().CheckInfMessengerExist();
        }
        
        [When(@"I enter UserName and Password")]
        public void WhenIEnterUserNameAndPassword(Table table)
        {
            dynamic data = table.CreateDynamicInstance();
            CurrentPage.As<LoginPage>().Login(data.email, data.pass);
        }
        
        [Then(@"I click login button")]
        public void ThenIClickLoginButton()
        {
            CurrentPage = CurrentPage.As<LoginPage>().ClickLoginButton();
        }
        
        [Then(@"I should see the Messenger to the left of the screen")]
        public void ThenIShouldSeeTheMessengerToTheLeftOfTheScreen()
        {
            if (CurrentPage.As<HomePage>().GetLoggedInUser().Contains("Messenger"))
                System.Console.WriteLine("Success Login");
            else
                System.Console.WriteLine("Unsuccessful Login");
        }
    }
}
