using OpenQA.Selenium;
using RandomProject.Hooks;
using System.Diagnostics;
using System.Threading;

namespace RandomProject.PageObject
{
    class SearchPage
    {
        public IWebDriver driver;
        /*
        private By firstItem = By.XPath("//*[@id=\"main\"]/div[2]/ul/li[4]/div/a[2]");
        private By secondItem = By.XPath("//*[@id=\"main\"]/div[2]/ul/li[6]/div/a[2]");
        private By thridItem = By.XPath("//*[@id=\"main\"]/div[2]/ul/li[7]/div/a[2]");
        private By fourthItem = By.XPath("//a[@aria-label='Add “Ninja Silhouette” to your cart']");
        private By fifthItem = By.XPath("//a[@aria-label='Add “Flying Ninja” to your cart']");
        */
        private By vewCart = By.XPath("//a[normalize-space()='Cart']");
        
        public SearchPage() 
        {
            driver = BaseTest.driver;
        }
        public void ClickFourRandomItems()
        {
            Random random = new Random();

            // I defined the firstItem, secondItem, thirdItem, and fourthItem locators

            int itemCount = 4;

            for (int i = 0; i < itemCount; i++)
            {
                // Generate a random integer between a specified range

                int randomIndex = random.Next(1, 5); // Generate between 1 (lower boundary) and 4 (upper boundary)
                driver.FindElement(By.XPath("//*[@id=\"main\"]/div[2]/ul/li["+randomIndex+"]/div/a[2]")).Click();

                /*
                switch (randomIndex)
                {
                    case 1:
                        driver.FindElement(firstItem).Click();
                        break;
                    case 2:
                        driver.FindElement(secondItem).Click();
                        break;
                    case 3:
                        driver.FindElement(thridItem).Click();
                        break;
                    case 4:
                        driver.FindElement(fourthItem).Click();
                        break;
                    case 5:
                        driver.FindElement(fifthItem).Click();
                        break;
                    default:
                        // Handle the case when randomIndex is out of range
                        break;


                        //driver.FindElement(firstItem).Click();
                        //driver.FindElement(secondItem).Click();
                        //driver.FindElement(thridItem).Click();
                        //driver.FindElement(fourthItem).Click();

                }
                */
            }

        }

        public void VewMycart()
        {
            Thread.Sleep(2000);
            driver.FindElement(vewCart).Click();
        }
        public bool VerifyFouritemsinmycart()
        {
            return driver.Url.Contains("https://cms.demo.katalon.com/cart/");
        }
        
       

    }
}
