using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handlenium
{
    public static class AjustSendKeys
    {
        /// <summary>
        /// SendKeys no elemento web
        /// </summary>
        /// <param name="elementId">Id do elemento web a ser enviado o texto</param>
        /// <param name="text">Texto a ser enviado para o elemento</param>
        /// <param name="chromedriver">Instância ativa do chromedriver</param>
        public static void SendKeysById(string elementId, string text, ChromeDriver chromedriver)
        {
            WebDriverWait wait = new WebDriverWait(chromedriver, TimeSpan.FromSeconds(30));

            int countStale = 0;

            IWebElement elementoAjustado = wait.Until(ExpectedConditions.ElementIsVisible(By.Id(elementId)));

            while (countStale < 4)
            {
                try
                {
                    elementoAjustado.SendKeys(text);
                    elementoAjustado.SendKeys(Keys.Null);
                    countStale = 4;
                }
                catch (StaleElementReferenceException e)
                {
                    Console.WriteLine("Tentando recuperar elemento: " + e);
                    countStale++;
                }
            }
        }

        /// <summary>
        /// SendKeys no elemento web
        /// </summary>
        /// <param name="elementName">Name do elemento web a ser enviado o texto</param>
        /// <param name="text">Texto a ser enviado para o elemento</param>
        /// <param name="chromedriver">Instância ativa do chromedriver</param>
        public static void SendKeysByName(string elementName, string text, ChromeDriver chromedriver)
        {
            WebDriverWait wait = new WebDriverWait(chromedriver, TimeSpan.FromSeconds(30));

            int countStale = 0;

            IWebElement elementoAjustado = wait.Until(ExpectedConditions.ElementIsVisible(By.Name(elementName)));

            while (countStale < 4)
            {
                try
                {
                    elementoAjustado.SendKeys(text);
                    elementoAjustado.SendKeys(Keys.Null);
                    countStale = 4;
                }
                catch (StaleElementReferenceException e)
                {
                    Console.WriteLine("Tentando recuperar elemento: " + e);
                    countStale++;
                }
            }
        }

        /// <summary>
        /// SendKeys no elemento web
        /// </summary>
        /// <param name="elementXPath">XPath do elemento web a ser enviado o texto</param>
        /// <param name="text">Texto a ser enviado para o elemento</param>
        /// <param name="chromedriver">Instância ativa do chromedriver</param>
        public static void SendKeysByXPath(string elementXPath, string text, ChromeDriver chromedriver)
        {
            WebDriverWait wait = new WebDriverWait(chromedriver, TimeSpan.FromSeconds(30));

            int countStale = 0;

            IWebElement elementoAjustado = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(elementXPath)));

            while (countStale < 4)
            {
                try
                {
                    elementoAjustado.SendKeys(text);
                    elementoAjustado.SendKeys(Keys.Null);
                    countStale = 4;
                }
                catch (StaleElementReferenceException e)
                {
                    Console.WriteLine("Tentando recuperar elemento: " + e);
                    countStale++;
                }
            }
        }

        /// <summary>
        /// SendKeys no elemento web
        /// </summary>
        /// <param name="elementClassName">ClassName do elemento web a ser enviado o texto</param>
        /// <param name="text">Texto a ser enviado para o elemento</param>
        /// <param name="chromedriver">Instância ativa do chromedriver</param>
        public static void SendKeysByClassName(string elementClassName, string text, ChromeDriver chromedriver)
        {
            WebDriverWait wait = new WebDriverWait(chromedriver, TimeSpan.FromSeconds(30));

            int countStale = 0;

            IWebElement elementoAjustado = wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName(elementClassName)));

            while (countStale < 4)
            {
                try
                {
                    elementoAjustado.SendKeys(text);
                    elementoAjustado.SendKeys(Keys.Null);
                    countStale = 4;
                }
                catch (StaleElementReferenceException e)
                {
                    Console.WriteLine("Tentando recuperar elemento: " + e);
                    countStale++;
                }
            }
        }

        /// <summary>
        /// SendKeys no elemento web
        /// </summary>
        /// <param name="elementTagName">TagName do elemento web a ser enviado o texto</param>
        /// <param name="text">Texto a ser enviado para o elemento</param>
        /// <param name="chromedriver">Instância ativa do chromedriver</param>
        public static void SendKeysByTagName(string elementTagName, string text, ChromeDriver chromedriver)
        {
            WebDriverWait wait = new WebDriverWait(chromedriver, TimeSpan.FromSeconds(30));

            int countStale = 0;

            IWebElement elementoAjustado = wait.Until(ExpectedConditions.ElementIsVisible(By.TagName(elementTagName)));

            while (countStale < 4)
            {
                try
                {
                    elementoAjustado.SendKeys(text);
                    elementoAjustado.SendKeys(Keys.Null);
                    countStale = 4;
                }
                catch (StaleElementReferenceException e)
                {
                    Console.WriteLine("Tentando recuperar elemento: " + e);
                    countStale++;
                }
            }
        }

    }
}
