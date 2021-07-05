using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumCsharpNetCore
{
    public class Tests
    {
        public IWebDriver Driver;

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setup");

            Driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");
            Driver.Manage().Window.Size = new System.Drawing.Size(1901, 1004);
            Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Tomat");
            Driver.FindElement(By.XPath("//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1']/following-sibling::div[text()='Celery']")).Click();


            //Driver.FindElement(By.XPath("//div[3]/section/section/div/div[1]/ul/li[3]/a")).Click();
            //Console.WriteLine("Test1");
            Assert.Pass();
        }
    }
}