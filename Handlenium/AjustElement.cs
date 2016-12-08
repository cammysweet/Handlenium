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
    public static class AjustElement
    {

        /// <summary>
        /// Retorna elemento web recuperado do StaleElementReferenceException 
        /// </summary>
        /// <param name="elementId">Id do elemento web</param>
        /// <param name="chromedriver">Instância de chromedriver ativa</param>
        /// <returns></returns>
        public static IWebElement AjustExceptionsById(string elementId, ChromeDriver chromedriver)
        {
            WebDriverWait wait = new WebDriverWait(chromedriver, TimeSpan.FromSeconds(30));
            IWebElement elementoAjustado;
            int countStale = 0;

            while (countStale < 4)
            {
                try
                {
                    elementoAjustado = wait.Until(ExpectedConditions.ElementIsVisible(By.Id(elementId)));
                    countStale = 4;
                    return elementoAjustado;
                }
                catch (StaleElementReferenceException)
                {
                    countStale++;
                }
            }
            return null;
        }

        /// <summary>
        /// Retorna elemento web recuperado do StaleElementReferenceException 
        /// </summary>
        /// <param name="elementName">Name do elemento web</param>
        /// <param name="chromedriver">Instância de chromedriver ativa</param>
        /// <returns></returns>
        public static IWebElement AjustExceptionsByName(string elementName, ChromeDriver chromedriver)
        {
            WebDriverWait wait = new WebDriverWait(chromedriver, TimeSpan.FromSeconds(30));
            IWebElement elementoAjustado;
            int countStale = 0;

            while (countStale < 4)
            {
                try
                {
                    elementoAjustado = wait.Until(ExpectedConditions.ElementIsVisible(By.Name(elementName)));
                    countStale = 4;
                    return elementoAjustado;
                }
                catch (StaleElementReferenceException)
                {
                    countStale++;
                }
            }
            return null;
        }

        /// <summary>
        /// Retorna elemento web recuperado do StaleElementReferenceException 
        /// </summary>
        /// <param name="elementXPath">XPath do Elemento Web</param>
        /// <param name="chromedriver">Instância ativa do chromedriver</param>
        /// <returns>IWebElement Ajustado</returns>
        public static IWebElement AjustExceptionsByXPath(string elementXPath, ChromeDriver chromedriver)
        {
            WebDriverWait wait = new WebDriverWait(chromedriver, TimeSpan.FromSeconds(30));
            IWebElement elementoAjustado;
            int countStale = 0;

            while (countStale < 4)
            {
                try
                {
                    elementoAjustado = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(elementXPath)));
                    countStale = 4;
                    return elementoAjustado;
                }
                catch (StaleElementReferenceException)
                {
                    countStale++;
                }
            }
            return null;
        }

        /// <summary>
        /// Retorna elemento web recuperado do StaleElementReferenceException 
        /// </summary>
        /// <param name="elementClassName">Class Name do elemento web</param>
        /// <param name="chromedriver">Instância de chromedriver ativa</param>
        /// <returns></returns>
        public static IWebElement AjustExceptionsByClassName(string elementClassName, ChromeDriver chromedriver)
        {
            WebDriverWait wait = new WebDriverWait(chromedriver, TimeSpan.FromSeconds(30));
            IWebElement elementoAjustado;
            int countStale = 0;

            while (countStale < 4)
            {
                try
                {
                    elementoAjustado = wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName(elementClassName)));
                    countStale = 4;
                    return elementoAjustado;
                }
                catch (StaleElementReferenceException)
                {
                    countStale++;
                }
            }
            return null;
        }

        /// <summary>
        /// Retorna elemento web recuperado do StaleElementReferenceException 
        /// </summary>
        /// <param name="elementTagName">Tag Name do elemento web</param>
        /// <param name="chromedriver">Instância de chromedriver ativa</param>
        /// <returns></returns>
        public static IWebElement AjustExceptionsByTagName(string elementTagName, ChromeDriver chromedriver)
        {
            WebDriverWait wait = new WebDriverWait(chromedriver, TimeSpan.FromSeconds(30));
            IWebElement elementoAjustado;
            int countStale = 0;

            while (countStale < 4)
            {
                try
                {
                    elementoAjustado = wait.Until(ExpectedConditions.ElementIsVisible(By.TagName(elementTagName)));
                    countStale = 4;
                    return elementoAjustado;
                }
                catch (StaleElementReferenceException)
                {
                    countStale++;
                }
            }
            return null;
        }

    }
}
