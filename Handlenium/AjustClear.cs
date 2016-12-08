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
    public static class AjustClear
    {

        /// <summary>
        /// Limpa o texto do elemento web
        /// </summary>
        /// <param name="elementId">Id do elemento web</param>
        /// <param name="chromedriver">Instância do chromedriver ativa</param>
        public static void ClearById(string elementId, ChromeDriver chromedriver)
        {
            WebDriverWait wait = new WebDriverWait(chromedriver, TimeSpan.FromSeconds(30));

            int countStale = 0;

            IWebElement elementoAjustado = wait.Until(ExpectedConditions.ElementIsVisible(By.Id(elementId)));

            while (countStale < 4)
            {
                try
                {

                    elementoAjustado.Clear();

                    countStale = 4;
                }
                catch (StaleElementReferenceException e)
                {
                    Console.Write("Tentando recuperar elemento: " + e);
                    countStale++;
                }
            }
        }

        /// <summary>
        /// Limpa o texto do elemento web
        /// </summary>
        /// <param name="elementName">Name do elemento web</param>
        /// <param name="chromedriver">Instância do chromedriver ativa</param>
        public static void ClearByName(string elementName, ChromeDriver chromedriver)
        {
            WebDriverWait wait = new WebDriverWait(chromedriver, TimeSpan.FromSeconds(30));

            int countStale = 0;

            IWebElement elementoAjustado = wait.Until(ExpectedConditions.ElementIsVisible(By.Name(elementName)));

            while (countStale < 4)
            {
                try
                {

                    elementoAjustado.Clear();

                    countStale = 4;
                }
                catch (StaleElementReferenceException e)
                {
                    Console.Write("Tentando recuperar elemento: " + e);
                    countStale++;
                }
            }
        }

        /// <summary>
        /// Limpa o texto do elemento web
        /// </summary>
        /// <param name="elementXPath">XPath do elemento web</param>
        /// <param name="chromedriver">Instância do chromedriver ativa</param>
        public static void ClearByXPath(string elementXPath, ChromeDriver chromedriver)
        {
            WebDriverWait wait = new WebDriverWait(chromedriver, TimeSpan.FromSeconds(30));

            int countStale = 0;

            IWebElement elementoAjustado = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(elementXPath)));

            while (countStale < 4)
            {
                try
                {

                    elementoAjustado.Clear();

                    countStale = 4;
                }
                catch (StaleElementReferenceException e)
                {
                    Console.Write("Tentando recuperar elemento: " + e);
                    countStale++;
                }
            }
        }

        /// <summary>
        /// Limpa o texto do elemento web
        /// </summary>
        /// <param name="elementClassName">ClassName do elemento web</param>
        /// <param name="chromedriver">Instância do chromedriver ativa</param>
        public static void ClearByClassName(string elementClassName, ChromeDriver chromedriver)
        {
            WebDriverWait wait = new WebDriverWait(chromedriver, TimeSpan.FromSeconds(30));

            int countStale = 0;

            IWebElement elementoAjustado = wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName(elementClassName)));

            while (countStale < 4)
            {
                try
                {

                    elementoAjustado.Clear();

                    countStale = 4;
                }
                catch (StaleElementReferenceException e)
                {
                    Console.Write("Tentando recuperar elemento: " + e);
                    countStale++;
                }
            }
        }

        /// <summary>
        /// Limpa o texto do elemento web
        /// </summary>
        /// <param name="elementTagName">TagName do elemento web</param>
        /// <param name="chromedriver">Instância do chromedriver ativa</param>
        public static void ClearByTagName(string elementTagName, ChromeDriver chromedriver)
        {
            WebDriverWait wait = new WebDriverWait(chromedriver, TimeSpan.FromSeconds(30));

            int countStale = 0;

            IWebElement elementoAjustado = wait.Until(ExpectedConditions.ElementIsVisible(By.TagName(elementTagName)));

            while (countStale < 4)
            {
                try
                {

                    elementoAjustado.Clear();

                    countStale = 4;
                }
                catch (StaleElementReferenceException e)
                {
                    Console.Write("Tentando recuperar elemento: " + e);
                    countStale++;
                }
            }
        }


    }
}
