using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading;

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

            //driver.Navigate().GoToUrl("https://www.youtube.com/");
            //driver.Manage().Window.Maximize();
            //IWebElement input2 = driver.FindElement(By.Name("search_query"));
            //input2.SendKeys("Rockstar Games");
            //IWebElement btnsearch2 = driver.FindElement(By.Id("search-icon-legacy"));
            //btnsearch2.Click();
            //IWebElement canal = driver.FindElement(By.Id("subscribe-button-shape"));
            //canal.Click();

            // Historial

            //driver.Navigate().GoToUrl("https://www.youtube.com/");
            //driver.Manage().Window.Maximize();
            //IWebElement input3 = driver.FindElement(By.Id("endpoint"));
            //input3.Click();
            //driver.Navigate().GoToUrl("https://www.youtube.com/feed/history");

            // Videos Favoritos

            //driver.Navigate().GoToUrl("https://www.youtube.com/");
            //driver.Manage().Window.Maximize();
            //IWebElement input3 = driver.FindElement(By.Id("endpoint"));
            //input3.Click();
            //driver.Navigate().GoToUrl("https://www.youtube.com/feed/you");


            // Contactanos

            //driver.Navigate().GoToUrl("http://localhost:3001/home");
            //driver.Manage().Window.Maximize();
            //Thread.Sleep(2000);
            //IWebElement btn = driver.FindElement(By.Id("btnxs"));
            //btn.Click();
            //Thread.Sleep(3000);
            //IWebElement inputne = driver.FindElement(By.Id("nameenterprise"));
            //inputne.SendKeys("Google");
            //Thread.Sleep(1000);
            //IWebElement inputna = driver.FindElement(By.Id("nameagent"));
            //inputna.SendKeys("Engel Rod");
            //Thread.Sleep(1000);
            //IWebElement inputtel = driver.FindElement(By.Id("telefono"));
            //inputtel.SendKeys("829-000-3342");
            //Thread.Sleep(1000);
            //IWebElement inputemail = driver.FindElement(By.Id("email"));
            //inputemail.SendKeys("engel.con@google.com");
            //Thread.Sleep(1000);
            //IWebElement inputcom = driver.FindElement(By.Id("commenta"));
            //inputcom.SendKeys("Estoy interesado");
            //Thread.Sleep(1000);
            //IWebElement btnenviar = driver.FindElement(By.Id("btnenviar"));
            //btnenviar.Click();
        }
    }
}
