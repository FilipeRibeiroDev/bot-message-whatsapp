using EasyAutomationFramework;
using Newtonsoft.Json.Bson;
using OpenQA.Selenium;
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

        public void SendMessageWithImage(string messsage, string pathImage, string to)
        {
            StartBrowser(TypeDriver.GoogleChorme, "C:\\Users\\Felipe Ribeiro\\AppData\\Local\\Google\\Chrome\\User Data");

            Navigate("https://web.whatsapp.com/");

            WaitForLoad();

            Thread.Sleep(TimeSpan.FromSeconds(4));

            //WaitForElement(TypeElement.Xpath, "//*[@id='side']/div[1]/div/div/div[2]/div/div[2]");

            var elemenSearch = AssignValue(TypeElement.Xpath, "//*[@id='side']/div[1]/div/div/div[2]/div/div[2]", to, 5);

            elemenSearch.element.SendKeys(OpenQA.Selenium.Keys.Enter);

            //Clicar no botão CLIP
            Click(TypeElement.Xpath, "//*[@id=\"main\"]/footer/div[1]/div/span[2]/div/div[1]/div[2]/div/div/span");

            //Adicionar o caminho da Imagem
            AssignValue(TypeElement.Xpath, "//*[@id=\"main\"]/footer/div[1]/div/span[2]/div/div[1]/div[2]/div/span/div/div/ul/li[1]/button/input", pathImage);

            var elementInput = AssignValue(TypeElement.Xpath, "//*[@id=\"app\"]/div/div/div[2]/div[2]/span/div/span/div/div/div[2]/div/div[1]/div[3]/div/div/div[2]/div[1]/div[1]/p", messsage);

            elementInput.element.SendKeys(OpenQA.Selenium.Keys.Enter);

            CloseBrowser();
        }

        public void SendMessageWithEmoji(string message, List<string> emojis, string to)
        {
            StartBrowser(TypeDriver.GoogleChorme, "C:\\Users\\Felipe Ribeiro\\AppData\\Local\\Google\\Chrome\\User Data");

            Navigate("https://web.whatsapp.com/");

            WaitForLoad();

            Thread.Sleep(TimeSpan.FromSeconds(4));

            //WaitForElement(TypeElement.Xpath, "//*[@id='side']/div[1]/div/div/div[2]/div/div[2]");

            var elemenSearch = AssignValue(TypeElement.Xpath, "//*[@id='side']/div[1]/div/div/div[2]/div/div[2]", to, 5);

            elemenSearch.element.SendKeys(OpenQA.Selenium.Keys.Enter);

            foreach (var emoji in emojis)
            {
                AssignValue(TypeElement.Xpath, "//*[@id=\"main\"]/footer/div[1]/div/span[2]/div/div[2]/div[1]/div/div[1]/p", ":");
                var element = AssignValue(TypeElement.Xpath, "//*[@id=\"main\"]/footer/div[1]/div/span[2]/div/div[2]/div[1]/div/div[1]/p", emoji);
                element.element.SendKeys(OpenQA.Selenium.Keys.Tab);
            }

            var elementInput = AssignValue(TypeElement.Xpath, "//*[@id=\"main\"]/footer/div[1]/div/span[2]/div/div[2]/div[1]/div/div[1]/p", message);
            elementInput.element.SendKeys(OpenQA.Selenium.Keys.Enter);

        } 

         

     

    




    }
}
