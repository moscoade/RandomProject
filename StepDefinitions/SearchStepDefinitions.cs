using OpenQA.Selenium;
using RandomProject.Hooks;
using RandomProject.PageObject;
using TechTalk.SpecFlow;

namespace CatalogueProject.StepDefinitions
{
    [Binding]
    public class SearchStepDefinitions
    {
        public IWebDriver driver = BaseTest.driver;
        SearchPage searchPage = new SearchPage();

        [Given(@"I navigate to the website ""([^""]*)""")]
        public void GivenINavigateToTheWebsite(string Url)
        {
            driver.Navigate().GoToUrl(Url);
        }

        [When(@"I add three random items to my cart")]
        public void WhenIAddThreeRandomItemsToMyCart()
        {
            searchPage.ClickFourRandomItems();
        }

        

        [When(@"I view my cart")]
        public void WhenIViewMyCart()
        {
            searchPage.VewMycart(); 
        }

        [Then(@"I am able to verify three items in my cart")]
        public void ThenIAmAbleToVerifyThreeItemsInMyCart()
        {
            searchPage.VerifyFouritemsinmycart();
        }
    }
}
