using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            // Barra de Búsqueda Test

            //driver.Navigate().GoToUrl("https://www.youtube.com/");
            //driver.Manage().Window.Maximize();

            //IWebElement input = driver.FindElement(By.Name("search_query"));
            //input.SendKeys("Julio Profe");
            //IWebElement btnsearch = driver.FindElement(By.Id("search-icon-legacy"));
            //btnsearch.Click();

            // Subscribirme

            driver.Navigate().GoToUrl("https://www.youtube.com/");
            driver.Manage().Window.Maximize();

            IWebElement input2 = driver.FindElement(By.Name("search_query"));
            input2.SendKeys("Rockstar Games");
            IWebElement btnsearch2 = driver.FindElement(By.Id("search-icon-legacy"));
            btnsearch2.Click();
            IWebElement canal = driver.FindElement(By.Id("subscribe-button-shape"));
            canal.Click();

            //
        }
    }
}
