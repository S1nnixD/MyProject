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
public class TestloginTest {
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
  public void testlogin() {
    driver.Navigate().GoToUrl("https://boardgamegeek.com/");
    driver.Manage().Window.Size = new System.Drawing.Size(1861, 1050);
        //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        Assert.That(driver.FindElement(By.LinkText("Sign In")).Text, Is.EqualTo("Sign In"));
  }
}
