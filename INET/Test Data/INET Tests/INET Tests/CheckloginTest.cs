// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
[TestFixture]
public class CheckloginTest {
  private IWebDriver driver;
  public IDictionary<string, object> vars {get; private set;}
  private IJavaScriptExecutor js;
  [SetUp]
  public void SetUp() {
    driver = new ChromeDriver();
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<string, object>();
  }
  [TearDown]
  protected void TearDown() {
    driver.Quit();
  }
  [Test]
  public void checklogin()
  {
        driver.Navigate().GoToUrl("https://www.inet.se/");
        driver.Manage().Window.Size = new System.Drawing.Size(1920, 1040);
        driver.FindElement(By.ClassName("agx7mup")).Click();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        driver.FindElement(By.CssSelector(".user > .text-nowrap")).Click();
        driver.FindElement(By.Id("login.email")).SendKeys("asdasd@test.com");
        driver.FindElement(By.Id("password")).SendKeys("asdasd");
        driver.FindElement(By.CssSelector("label > input")).Click();
        driver.FindElement(By.CssSelector(".x-modal-action-button")).Click();
    {
        string value = driver.FindElement(By.CssSelector("label > input")).GetAttribute("value");
        Assert.That(value, Is.EqualTo("on"));
    }
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        Assert.That(driver.FindElement(By.CssSelector(".alert")).Text, Is.EqualTo("Felaktigt användarnamn eller lösenord."));
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        driver.Navigate().GoToUrl("https://www.inet.se/");
        driver.FindElement(By.CssSelector(".user > .text-nowrap")).Click();
    {
            string value = driver.FindElement(By.CssSelector("label > input")).GetAttribute("value");
            Assert.That(value, Is.EqualTo("on"));
    }
        driver.FindElement(By.CssSelector(".x-modal-action-button")).Click();
        Assert.That(driver.FindElement(By.CssSelector(".t1cke9b5")).Text, Is.EqualTo("Logga in"));

        driver.FindElement(By.CssSelector(".fa-times")).Click();
        Assert.That(driver.FindElement(By.CssSelector(".user > .text-nowrap")).Text, Is.EqualTo("Min sida"));
  }

}
