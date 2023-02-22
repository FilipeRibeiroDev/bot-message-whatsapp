using EasyAutomationFramework;
using Newtonsoft.Json.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatsAppProject
{
    public class WhatsAppSendMessage : Web
    {
        public void SendMessage(string message, string to)
        {
            StartBrowser(TypeDriver.GoogleChorme, "C:\\Users\\Felipe Ribeiro\\AppData\\Local\\Google\\Chrome\\User Data");

            Navigate("https://web.whatsapp.com/");

            WaitForLoad();

            Thread.Sleep(TimeSpan.FromSeconds(4));

            //WaitForElement(TypeElement.Xpath, "//*[@id='side']/div[1]/div/div/div[2]/div/div[2]");

            var elemenSearch = AssignValue(TypeElement.Xpath, "//*[@id='side']/div[1]/div/div/div[2]/div/div[2]", to, 5);

            elemenSearch.element.SendKeys(OpenQA.Selenium.Keys.Enter);

            var elementMessage = AssignValue(TypeElement.Xpath, "/html/body/div[1]/div/div/div[4]/div/footer/div[1]/div/span[2]/div/div[2]/div[1]/div/div[1]/p", message);

            elementMessage.element.SendKeys(OpenQA.Selenium.Keys.Enter);

            CloseBrowser();
        }
    }
}
