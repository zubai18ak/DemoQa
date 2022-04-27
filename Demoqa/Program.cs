using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Interactions;
//using OpenQA.Selenium.Support.UI.WebDriverWait;

namespace Demoqa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWebDriver Driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            Thread.Sleep(200);

            Driver.Navigate().GoToUrl("https://demoqa.com/");
            Thread.Sleep(200);
            Driver.Manage().Window.Maximize();
            Thread.Sleep(200);
            js.ExecuteScript("window.scrollBy(0,300)");

            #region Browser Window

            //Driver.FindElement(By.XPath("//h5[text()='Alerts, Frame & Windows']")).Click();
            ////Driver.FindElement(By.XPath("//*[@id='app']/div/div/div[2]/div/div[3]/div/div[2]")).Click();
            //Thread.Sleep(200);

            //js.ExecuteScript("window.scrollBy(0,400)");
            //Thread.Sleep(2000);
            //Driver.FindElement(By.XPath("//span[text()='Browser Windows']")).Click();

            //Thread.Sleep(2000);
            //Driver.FindElement(By.XPath("//button[@id='tabButton']")).Click();
            //Thread.Sleep(2000);
            //Driver.SwitchTo().Window(Driver.WindowHandles[1]);
            //Thread.Sleep(2000);
            //Driver.Close();

            //Thread.Sleep(2000);
            //Driver.SwitchTo().Window(Driver.WindowHandles[0]);
            //Thread.Sleep(2000);
            //Driver.FindElement(By.XPath("//button[text()='New Window']")).Click();
            //Thread.Sleep(2000);
            //Driver.SwitchTo().Window(Driver.WindowHandles[1]);
            //Thread.Sleep(2000);
            //Driver.Close();

            //Thread.Sleep(2000);
            //Driver.SwitchTo().Window(Driver.WindowHandles[0]);
            //Thread.Sleep(2000);
            //Driver.FindElement(By.XPath("//button[text()='New Window Message']")).Click();
            //Thread.Sleep(2000);
            //Driver.SwitchTo().Window(Driver.WindowHandles[1]);
            //Thread.Sleep(2000);
            //Driver.Close();

            #endregion

            #region Alert
            //Thread.Sleep(200);
            //Driver.FindElement(By.XPath("//h5[text()='Alerts, Frame & Windows']")).Click();
            //Thread.Sleep(200);
            //Driver.SwitchTo().Window(Driver.WindowHandles[0]);
            //Thread.Sleep(200);
            //js.ExecuteScript("window.scrollBy(0,200)");
            //Thread.Sleep(200);
            //Driver.FindElement(By.XPath("//span[text()='Alerts']")).Click();
            //Thread.Sleep(200);

            //Driver.FindElement(By.XPath("//button[@id='alertButton']")).Click();
            //Thread.Sleep(2000);
            //Driver.SwitchTo().Alert().Accept();

            #region TimerAlert
            //try
            //{
            //    Driver.FindElement(By.Id("timerAlertButton")).Click();
            //    WebDriverWait wait = new WebDriverWait(Driver, t);
            //    wait.Until(ExpectedConditions.alertIsPresent());
            //    Alert simpleAlert = Driver.SwitchTo().Alert();
            //    simpleAlert.accept();
            //    System.out.println("Unexpected alert accepted");
            //}
            //catch (Exception e)
            //{
            //    System.out.println("unexpected alert not present");
            //}

            //Driver.FindElement(By.XPath("//button[@id='timerAlertButton']")).Click();
            //Thread.Sleep(10000);
            //Driver.SwitchTo().Alert().Accept();
            #endregion

            //Driver.FindElement(By.XPath("//button[@id='confirmButton']")).Click();
            //Thread.Sleep(2000);
            //Driver.SwitchTo().Alert().Accept();

            //Driver.FindElement(By.XPath("//button[@id='confirmButton']")).Click();
            //Thread.Sleep(2000);
            //Driver.SwitchTo().Alert().Dismiss();

            //Driver.FindElement(By.XPath("//button[@id='promtButton']")).Click();
            //Thread.Sleep(2000);
            //Driver.SwitchTo().Alert().GetType();
            //Driver.SwitchTo().Alert().SendKeys("Zubair Ahmed");
            //Driver.SwitchTo().Alert().Accept();
            //Thread.Sleep(2000);

            #endregion

            #region Frame

            #endregion

            #region Modals

            //Thread.Sleep(200);
            //Driver.FindElement(By.XPath("//h5[text()='Alerts, Frame & Windows']")).Click();
            //Thread.Sleep(200);
            //Driver.SwitchTo().Window(Driver.WindowHandles[0]);
            //Thread.Sleep(200);
            //js.ExecuteScript("window.scrollBy(0,500)");
            //Thread.Sleep(200);
            //Driver.FindElement(By.XPath("//span[text()='Modal Dialogs']")).Click();
            //Thread.Sleep(200);

            //Thread.Sleep(200);
            //Driver.FindElement(By.Id("showSmallModal")).Click();
            //Thread.Sleep(200);

            //string sm1 = Driver.FindElement(By.ClassName("modal-header")).Text;
            //Console.WriteLine("Modal Header"+sm1);
            //Thread.Sleep(200);

            //string sm2 = Driver.FindElement(By.ClassName("modal-body")).Text;
            //Console.WriteLine("Modal Body"+sm2);
            //Thread.Sleep(200);

            //Thread.Sleep(200);
            //Driver.FindElement(By.XPath("//button[@id='closeSmallModal']")).Click();
            //Thread.Sleep(200);

            //Thread.Sleep(200);
            //Driver.FindElement(By.Id("showLargeModal")).Click();
            //Thread.Sleep(200);

            //string bm1 = Driver.FindElement(By.ClassName("modal-header")).Text;
            //Console.WriteLine("Modal Header"+bm1);
            //Thread.Sleep(200);

            //string bm2 = Driver.FindElement(By.ClassName("modal-body")).Text;
            //Console.WriteLine("Modal Body"+bm2);
            //Thread.Sleep(200);

            //Thread.Sleep(200);
            //Driver.FindElement(By.XPath("//button[@id='closeLargeModal']")).Click();
            //Thread.Sleep(200);


            #endregion

            #region Widgets

            #region Accordian
            //Thread.Sleep(200);
            //Driver.FindElement(By.XPath("//h5[text()='Widgets']")).Click();
            //Thread.Sleep(200);
            //Driver.SwitchTo().Window(Driver.WindowHandles[0]);
            //Thread.Sleep(200);
            //js.ExecuteScript("window.scrollBy(0,500)");
            //Thread.Sleep(200);
            //Driver.FindElement(By.XPath("//span[text()='Accordian']")).Click();
            //Thread.Sleep(200);
            //Driver.FindElement(By.XPath("//div[text()='What is Lorem Ipsum?']")).Click();
            //Thread.Sleep(2000);
            //js.ExecuteScript("window.scrollBy(0,200)");
            //Driver.FindElement(By.XPath("//div[text()='Where does it come from?']")).Click();
            //Thread.Sleep(2000);
            //Driver.FindElement(By.XPath("//div[text()='Where does it come from?']")).Click();
            //Thread.Sleep(2000);
            //Driver.FindElement(By.XPath("//div[text()='Why do we use it?']")).Click();
            //Thread.Sleep(2000);
            //Driver.FindElement(By.XPath("//div[text()='Why do we use it?']")).Click();
            //Thread.Sleep(2000);


            #endregion

            #region Auto Complete

            //Thread.Sleep(200);
            //Driver.FindElement(By.XPath("//h5[text()='Widgets']")).Click();
            //Thread.Sleep(200);
            //Driver.SwitchTo().Window(Driver.WindowHandles[0]);
            //Thread.Sleep(200);
            //js.ExecuteScript("window.scrollBy(0,500)");
            //Thread.Sleep(200);
            //Driver.FindElement(By.XPath("//span[text()='Auto Complete']")).Click();
            //Thread.Sleep(2000);
            //Driver.FindElement(By.XPath("//div[@id='autoCompleteMultipleContainer']")).Click();
            //Driver.FindElement(By.XPath("//div[@id='autoCompleteMultipleInput']")).SendKeys("a");
            //Thread.Sleep(200);
            #endregion

            #region Data Picker
            #endregion

            #region Slider

            //Driver.FindElement(By.XPath("//*[@id ='demo-tab-grid']")).Click();
            //Thread.Sleep(200);
            ////Driver.FindElement(By.XPath("//h5[text()='Widgets']")).Click();
            //Thread.Sleep(200);
            //Driver.SwitchTo().Window(Driver.WindowHandles[0]);
            //Thread.Sleep(200);
            //js.ExecuteScript("window.scrollBy(0,500)");
            //Thread.Sleep(200);
            //Driver.FindElement(By.XPath("//span[text()='Slider']")).Click();

            //Actions builder = new Actions(Driver);
            //Driver.FindElement(By.ClassName("range-slider__tooltip__label"));
            //Thread.Sleep(2000);
            //builder.MoveToElement(Driver.FindElement(By.Id("sliderContainer")));
            //Thread.Sleep(2000);


            #endregion




            #endregion

            //Actions action = new Actions(Driver);

            //action.ClickAndHold(Driver.FindElement(By.XPath("//*[@class= 'create-grid']//child::div[3]"))).MoveToElement(Driver.FindElement(By.XPath("//*[@class= 'create-grid']//child::div[7]"))).Release().Build().Perform();
            //action.MoveToElement(Driver.FindElement(By.XPath("")));


            // Drag and Drop

            Driver.Navigate().GoToUrl("https://demoqa.com/dragabble");
            Actions ac = new Actions(Driver);

            ac.ClickAndHold(Driver.FindElement(By.XPath("//div[@id='dragBox']"))).Build().Perform();
            Thread.Sleep(2000);

            ac.MoveByOffset(200, 150).Release().Perform();
            Thread.Sleep(2000);

            Thread.Sleep(3000);
            Driver.Close();
            Thread.Sleep(3000);
            Driver.Quit();


        }
    }

}