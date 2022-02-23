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
public class CheckpopcategoriesTest {
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
  public void checkpopcategories() {
    driver.Navigate().GoToUrl("https://www.inet.se/");
    {
      var element = driver.FindElement(By.CssSelector(".form-control"));
      Boolean isEditable = element.Enabled && element.GetAttribute("readonly") == null;
      Assert.True(isEditable);
    }
    Assert.That(driver.FindElement(By.CssSelector(".category-button:nth-child(1)")).Text, Is.EqualTo("Datorer"));
    Assert.That(driver.FindElement(By.CssSelector(".category-button:nth-child(2)")).Text, Is.EqualTo("Dator­komponenter"));
    Assert.That(driver.FindElement(By.CssSelector(".category-button:nth-child(3)")).Text, Is.EqualTo("Bildskärm"));
    Assert.That(driver.FindElement(By.CssSelector(".category-button:nth-child(4)")).Text, Is.EqualTo("Datortillbehör"));
    Assert.That(driver.FindElement(By.CssSelector(".category-button:nth-child(5)")).Text, Is.EqualTo("Smarta Hem"));
    Assert.That(driver.FindElement(By.CssSelector(".category-button:nth-child(6)")).Text, Is.EqualTo("Spel/Konsol/VR"));
  }
}
