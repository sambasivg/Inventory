using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Inventory.Common
{
  public   class CommonFunctions
    {
        public  static IWebDriver Driver;
        public static Boolean validBrowserType = true;
        public  object commonfun;

        
      public  enum LocatorName { Id, CssSelector, LinkText, Name, ClassName, PartialLinkText,TagName,Xpath };

        public static void WebPageStart(String webPageUrl, string BrowserType)
        {
            String driverPath = Directory.GetCurrentDirectory();

            String browserType = ConfigurationManager.AppSettings["BrowserType"];


            if (string.Equals(browserType, "IE"))
            {
                InternetExplorerOptions ieOptions = new InternetExplorerOptions();
                ieOptions.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
                Driver = new InternetExplorerDriver(driverPath, ieOptions, TimeSpan.FromSeconds(240));
            }
            else if (string.Equals(browserType, "Firefox"))
            {
                Driver = new FirefoxDriver(new FirefoxBinary("C:\\Program Files (x86)\\Mozilla Firefox\\Firefox.exe"), new FirefoxProfile(), TimeSpan.FromMinutes(30));
                Driver = new FirefoxDriver();
            }
            else if (string.Equals(browserType, "GoogleChrome"))
            {
                Driver = new ChromeDriver(driverPath);

            }
            else
            {
                validBrowserType = false;
            }


            Driver.Manage().Cookies.DeleteAllCookies();
            Driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl(webPageUrl);

        }
        public static IWebElement FindWebElelement(LocatorName Locname,String locatorval)
        {
            IWebElement WebElement= null;
            Boolean validLocatorName = true;
            switch (Locname)
            { 
               case LocatorName.Id:
                    WebElement = Driver.FindElement(By.Id(locatorval));
                    break;
                case LocatorName.Name:
                    WebElement = Driver.FindElement(By.Name(locatorval));
                    break;
                case LocatorName.ClassName:
                    WebElement = Driver.FindElement(By.ClassName(locatorval));
                    break;
                case LocatorName.Xpath:
                    WebElement = Driver.FindElement(By.XPath(locatorval));
                    break;
                default:
                    validLocatorName = false;
                    break;
            }
            return WebElement;
        }
        public static void EnterValueInTextBox(LocatorName Locname, string locatorval, string enterText)
        {
            var webElement = CommonFunctions.FindWebElelement(Locname, locatorval);
            webElement.Clear();
            Thread.Sleep(2000);
            webElement.SendKeys(enterText);
            Thread.Sleep(3000);
            
        }
        public static void SendKey(LocatorName Locname, string locatorval, string enterText)
        {
            var webElement = CommonFunctions.FindWebElelement(Locname, locatorval);
            if( string.Equals(enterText,"tab"))
                {
                webElement.SendKeys(Keys.Tab);
                }
            else
            {
                webElement.SendKeys(Keys.Enter);
            }

            Thread.Sleep(3000);
            
        }
        public static void selectAnOptionFromlistbox(LocatorName Locname, string locatorval, string optionToSelect)
        {
            var selectionListElement = FindWebElelement(Locname, locatorval);
            SelectElement selElement = new SelectElement(selectionListElement);
           //sel

            
                        selElement.SelectByText(optionToSelect);
          
        }
        public static void ClickButton(LocatorName Locname, string locatorval)
        {
            Thread.Sleep(4000);
            var webElement = CommonFunctions.FindWebElelement(Locname, locatorval);
            webElement.Click();
        }
        public static String GetWebElementText(LocatorName Locname, string locatorval)
        {
            var webElement = CommonFunctions.FindWebElelement(Locname, locatorval);
            Console.WriteLine("value:"+ webElement.Text);
            return webElement.Text;
        }
        public static String GetWebElementValue(LocatorName Locname, string locatorval)
        {
            var webElement = CommonFunctions.FindWebElelement(Locname, locatorval);
            Console.WriteLine("value:" + webElement.GetAttribute("value"));
            return webElement.GetAttribute("value");
        }
    }

          
    }

