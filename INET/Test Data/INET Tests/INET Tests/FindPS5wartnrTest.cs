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
public class FindPS5wartnrTest {
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
  public void findPS5wartnr() {
    driver.Navigate().GoToUrl("https://www.inet.se/");
    driver.Manage().Window.Size = new System.Drawing.Size(1861, 1050);
    driver.FindElement(By.CssSelector(".form-control")).Click();
    driver.FindElement(By.CssSelector(".form-control")).SendKeys("6609862");
    driver.FindElement(By.CssSelector(".form-control")).SendKeys(Keys.Enter);
    Assert.That(driver.FindElement(By.CssSelector(".product-page > .box h1")).Text, Is.EqualTo("Sony Playstation 5 Digital Edition"));
  }
}
