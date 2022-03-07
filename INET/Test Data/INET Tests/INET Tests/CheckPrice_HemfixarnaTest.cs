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
public class HemfixarnaTest {
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
  public void hemfixarna() {
    driver.Navigate().GoToUrl("https://www.inet.se/");
    driver.Manage().Window.Size = new System.Drawing.Size(1811, 992);
    driver.FindElement(By.ClassName("agx7mup")).Click();
    driver.FindElement(By.CssSelector("li:nth-child(20) .name")).Click();
    driver.FindElement(By.CssSelector(".column:nth-child(2) .buttonimg")).Click();
    driver.FindElement(By.Id("hideshow")).Click();
    driver.SwitchTo().Frame(0);
    driver.FindElement(By.Id("wpforms-4775-field_23")).Click();
    {
      var dropdown1 = driver.FindElement(By.Id("wpforms-4775-field_23"));
      dropdown1.FindElement(By.CssSelector("*:nth-child(1)")).Click();
    }
    {
      var element = driver.FindElement(By.Id("wpforms-4775-field_23"));
      //string value = element.GetAttribute("value");
      //string locator = string.Format("option[@value='%s']", value);
      string selectedText = element.FindElement(By.Id("wpforms-4775-field_23")).Text;
      Assert.That(selectedText, Is.EqualTo("Installation av dator – 699 kr "));
    }
    {
      var dropdown = driver.FindElement(By.Id("wpforms-4775-field_23"));
      dropdown.FindElement(By.CssSelector("*:nth-child(2)")).Click();
    }
    {
      var element = driver.FindElement(By.Id("wpforms-4775-field_23"));
      string value = element.GetAttribute("value");
      string locator = string.Format("option[@value='%s']", value);
      string selectedText = element.FindElement(By.XPath(locator)).Text;
      Assert.That(selectedText, Is.EqualTo("Installation av väggfäste – 799 kr "));
    }
    {
      var dropdown = driver.FindElement(By.Id("wpforms-4775-field_23"));
      dropdown.FindElement(By.CssSelector("*:nth-child(3)")).Click();
    }
    {
      var element = driver.FindElement(By.Id("wpforms-4775-field_23"));
      string value = element.GetAttribute("value");
      string locator = string.Format("option[@value='%s']", value);
      string selectedText = element.FindElement(By.XPath(locator)).Text;
      Assert.That(selectedText, Is.EqualTo("Installation av ny mobil – 599 kr "));
    }
    {
      var dropdown = driver.FindElement(By.Id("wpforms-4775-field_23"));
      dropdown.FindElement(By.CssSelector("*:nth-child(4)")).Click();
    }
    {
      var element = driver.FindElement(By.Id("wpforms-4775-field_23"));
      string value = element.GetAttribute("value");
      string locator = string.Format("option[@value='%s']", value);
      string selectedText = element.FindElement(By.XPath(locator)).Text;
      Assert.That(selectedText, Is.EqualTo("Installation av router – 599 kr "));
    }
    {
      var dropdown = driver.FindElement(By.Id("wpforms-4775-field_23"));
      dropdown.FindElement(By.CssSelector("*:nth-child(5)")).Click();
    }
    {
      var element = driver.FindElement(By.Id("wpforms-4775-field_23"));
      string value = element.GetAttribute("value");
      string locator = string.Format("option[@value='%s']", value);
      string selectedText = element.FindElement(By.XPath(locator)).Text;
      Assert.That(selectedText, Is.EqualTo("Installation av skrivare – 599 kr "));
    }
    {
      var dropdown = driver.FindElement(By.Id("wpforms-4775-field_23"));
      dropdown.FindElement(By.CssSelector("*:nth-child(6)")).Click();
    }
    {
      var element = driver.FindElement(By.Id("wpforms-4775-field_23"));
      string value = element.GetAttribute("value");
      string locator = string.Format("option[@value='%s']", value);
      string selectedText = element.FindElement(By.XPath(locator)).Text;
      Assert.That(selectedText, Is.EqualTo("Optimering av trådlöst nätverk – 699 kr "));
    }
    {
      var dropdown = driver.FindElement(By.Id("wpforms-4775-field_23"));
      dropdown.FindElement(By.CssSelector("*:nth-child(7)")).Click();
    }
    {
      var element = driver.FindElement(By.Id("wpforms-4775-field_23"));
      string value = element.GetAttribute("value");
      string locator = string.Format("option[@value='%s']", value);
      string selectedText = element.FindElement(By.XPath(locator)).Text;
      Assert.That(selectedText, Is.EqualTo("Felsökning av nätverk – 499 kr/h "));
    }
    {
      var dropdown = driver.FindElement(By.Id("wpforms-4775-field_23"));
      dropdown.FindElement(By.CssSelector("*:nth-child(8)")).Click();
    }
    {
      var element = driver.FindElement(By.Id("wpforms-4775-field_23"));
      string value = element.GetAttribute("value");
      string locator = string.Format("option[@value='%s']", value);
      string selectedText = element.FindElement(By.XPath(locator)).Text;
      Assert.That(selectedText, Is.EqualTo("Felsökning av skrivare – 499 kr/h "));
    }
    {
      var dropdown = driver.FindElement(By.Id("wpforms-4775-field_23"));
      dropdown.FindElement(By.CssSelector("*:nth-child(9)")).Click();
    }
    {
      var element = driver.FindElement(By.Id("wpforms-4775-field_23"));
      string value = element.GetAttribute("value");
      string locator = string.Format("option[@value='%s']", value);
      string selectedText = element.FindElement(By.XPath(locator)).Text;
      Assert.That(selectedText, Is.EqualTo("Övrig installation/felsökning – 499 kr/h "));
    }
  }
}
