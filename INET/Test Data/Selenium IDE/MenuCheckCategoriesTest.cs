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
public class MenuCheckCategoriesTest {
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
  public void menuCheckCategories() {
    driver.Navigate().GoToUrl("https://www.inet.se/");
    driver.Manage().Window.Size = new System.Drawing.Size(1800, 992);
    var elements = driver.FindElements(By.LinkText("Bildskärm"));
    Assert.True(elements.Count > 0);
    var elements = driver.FindElements(By.LinkText("Datorer"));
    Assert.True(elements.Count > 0);
    var elements = driver.FindElements(By.LinkText("Dator­komponenter"));
    Assert.True(elements.Count > 0);
    var elements = driver.FindElements(By.LinkText("Datortillbehör"));
    Assert.True(elements.Count > 0);
    var elements = driver.FindElements(By.LinkText("Extern Lagring"));
    Assert.True(elements.Count > 0);
    var elements = driver.FindElements(By.LinkText("Hem/Fritid/Hälsa"));
    Assert.True(elements.Count > 0);
    var elements = driver.FindElements(By.LinkText("Kablar/Adaptrar"));
    Assert.True(elements.Count > 0);
    var elements = driver.FindElements(By.LinkText("Ljud/Bild"));
    Assert.True(elements.Count > 0);
    var elements = driver.FindElements(By.LinkText("Mobiltelefon"));
    Assert.True(elements.Count > 0);
    var elements = driver.FindElements(By.LinkText("Nätverk"));
    Assert.True(elements.Count > 0);
    var elements = driver.FindElements(By.LinkText("Presentkort"));
    Assert.True(elements.Count > 0);
    var elements = driver.FindElements(By.LinkText("Programvara"));
    Assert.True(elements.Count > 0);
    var elements = driver.FindElements(By.LinkText("Skrivare/Scanner"));
    Assert.True(elements.Count > 0);
    var elements = driver.FindElements(By.LinkText("Smarta Hem"));
    Assert.True(elements.Count > 0);
    var elements = driver.FindElements(By.LinkText("Spel/Konsol/VR"));
    Assert.True(elements.Count > 0);
    var elements = driver.FindElements(By.LinkText("Surfplatta"));
    Assert.True(elements.Count > 0);
    var elements = driver.FindElements(By.LinkText("Kampanjer"));
    Assert.True(elements.Count > 0);
    var elements = driver.FindElements(By.LinkText("Fyndhörnan"));
    Assert.True(elements.Count > 0);
    var elements = driver.FindElements(By.LinkText("Tävlingar"));
    Assert.True(elements.Count > 0);
    var elements = driver.FindElements(By.Id("Servicetjänster"));
    Assert.True(elements.Count > 0);
    var elements = driver.FindElements(By.LinkText("Guider"));
    Assert.True(elements.Count > 0);
    var elements = driver.FindElements(By.LinkText("Datorbyggare"));
    Assert.True(elements.Count > 0);
  }
}