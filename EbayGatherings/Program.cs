using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EbayGatherings
{
    class Program
    {
        static void Main(string[] args)
        {
            var options = new ChromeOptions();
            options.AddArguments("--disable-gpu");

            //create a chroe driver
            var chromeDriver = new ChromeDriver(options);

            //navigate to a url 
//
//            chromeDriver.Navigate().GoToUrl("https://www.ebay.com/");
//
//                        //Grab the name of input as the way to navigate to that element
//                        chromeDriver.FindElementByClassName("gh-tb").Click();
//            
//            
//                        //pass the string "test" to the element above
//                        chromeDriver.Keyboard.SendKeys("lenovo");
//                        //press enter
//                        chromeDriver.Keyboard.SendKeys(Keys.Enter);








           chromeDriver.Navigate().GoToUrl("https://www.ebay.com/sch/i.html?_from=R40&_trksid=p2380057.m570.l1313.TR0.TRC0.H0.Xlenovo.TRS0&_nkw=lenovo&_sacat=0");


            //populate titles for ebay
            var titles = chromeDriver.FindElements(by: By.ClassName("lvtitle"));
            

            foreach (var title in titles)
            {
                Console.WriteLine(title.Text);
            }


        }
    }
}
