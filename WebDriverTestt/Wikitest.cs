using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

var driver=new ChromeDriver();
driver.Url="https:/wikipedia.org";
System.Console.WriteLine("Current Title: "+driver.Title);
var searchFild = driver.FindElement(By.Id("searchInput"));
searchFild.Click();
searchFild.SendKeys("QA");
searchFild.SendKeys(Keys.Enter);
System.Console.WriteLine("Title: "+driver.Title);
driver.Quit();
