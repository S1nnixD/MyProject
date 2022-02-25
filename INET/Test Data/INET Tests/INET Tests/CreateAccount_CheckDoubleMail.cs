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
public class CreateaccountCheckdoublemailTest {
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
  public void createaccountCheckdoublemail() {
    driver.Navigate().GoToUrl("https://www.inet.se/");
    driver.Manage().Window.Size = new System.Drawing.Size(1811, 992);
    {
      var element = driver.FindElement(By.CssSelector("a:nth-child(2) > img"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    {
      var element = driver.FindElement(By.tagName("body"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element, 0, 0).Perform();
    }
    driver.FindElement(By.CssSelector(".user > .text-nowrap")).Click();
    driver.FindElement(By.LinkText("Skapa konto")).Click();
    driver.FindElement(By.Id("email")).Click();
    driver.FindElement(By.Id("email")).SendKeys("test@gmail.com");
    driver.FindElement(By.CssSelector(".btn-success")).Click();
    var elements = driver.FindElements(By.CssSelector(".row:nth-child(5) > .col-xs-12:nth-child(3)"));
    Assert.True(elements.Count > 0);
  }
}
