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
    public static class AjustClick
    {

        /// <summary>
        /// Clica no elemento recuperado pelo Id
        /// </summary>
        /// <param name="elementId">Id do elemento web a ser clicado</param>
        /// <param name="chromedriver">Instância ativa do chromedriver</param>
        public static void ClickById(string elementId, ChromeDriver chromedriver)
        {
            WebDriverWait wait = new WebDriverWait(chromedriver, TimeSpan.FromSeconds(30));

            int countStale = 0;
            int countInvalid = 0;
            IWebElement elementoAjustado = wait.Until(ExpectedConditions.ElementIsVisible(By.Id(elementId)));

            while (countStale < 4)
            {
                try
                {
                    while (countInvalid < 4)
                    {
                        try
                        {
                            elementoAjustado = wait.Until(ExpectedConditions.ElementIsVisible(By.Id(elementId)));
                            elementoAjustado.Click();
                            countInvalid = 4;
                        }
                        catch (InvalidOperationException e)
                        {
                            Console.Write("Tentando ajustar InvalidOperationException :" + e);
                            countInvalid++;
                        }
                        catch (WebDriverException e)
                        {
                            Console.Write("Tentando ajustar WebDriverException :" + e);
                            countInvalid++;
                        }
                    }

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
        /// Clica no elemento recuperado pelo name
        /// </summary>
        /// <param name="elementName">Name do elemento web a ser clicado</param>
        /// <param name="chromedriver">Instância ativa do chromedriver</param>
        public static void ClickByName(string elementName, ChromeDriver chromedriver)
        {
            WebDriverWait wait = new WebDriverWait(chromedriver, TimeSpan.FromSeconds(30));

            int countStale = 0;
            int countInvalid = 0;
            IWebElement elementoAjustado = wait.Until(ExpectedConditions.ElementIsVisible(By.Name(elementName)));

            while (countStale < 4)
            {
                try
                {
                    while (countInvalid < 4)
                    {
                        try
                        {
                            elementoAjustado = wait.Until(ExpectedConditions.ElementIsVisible(By.Name(elementName)));
                            elementoAjustado.Click();
                            countInvalid = 4;
                        }
                        catch (InvalidOperationException e)
                        {
                            Console.Write("Tentando ajustar InvalidOperationException :" + e);
                            countInvalid++;
                        }
                        catch (WebDriverException e)
                        {
                            Console.Write("Tentando ajustar WebDriverException :" + e);
                            countInvalid++;
                        }
                    }

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
        /// Clica no elemento recuperado pelo XPath
        /// </summary>
        /// <param name="elementXPath">XPath do elemento web a ser clicado</param>
        /// <param name="chromedriver">Instância ativa do chromedriver</param>
        public static void ClickByXPath(string elementXPath, ChromeDriver chromedriver)
        {
            WebDriverWait wait = new WebDriverWait(chromedriver, TimeSpan.FromSeconds(30));

            int countStale = 0;
            int countInvalid = 0;
            IWebElement elementoAjustado = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(elementXPath)));

            while (countStale < 4)
            {
                try
                {
                    while (countInvalid < 4)
                    {
                        try
                        {
                            elementoAjustado = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(elementXPath)));
                            elementoAjustado.Click();
                            countInvalid = 4;
                        }
                        catch (InvalidOperationException e)
                        {
                            Console.Write("Tentando ajustar InvalidOperationException :" + e);
                            countInvalid++;
                        }
                        catch (WebDriverException e)
                        {
                            Console.Write("Tentando ajustar WebDriverException :" + e);
                            countInvalid++;
                        }
                    }

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
        /// Clica no elemento recuperado pelo ClassName
        /// </summary>
        /// <param name="elementClassName">ClassName do elemento web a ser clicado</param>
        /// <param name="chromedriver">Instância ativa do chromedriver</param>
        public static void ClickByClassName(string elementClassName, ChromeDriver chromedriver)
        {
            WebDriverWait wait = new WebDriverWait(chromedriver, TimeSpan.FromSeconds(30));

            int countStale = 0;
            int countInvalid = 0;
            IWebElement elementoAjustado = wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName(elementClassName)));

            while (countStale < 4)
            {
                try
                {
                    while (countInvalid < 4)
                    {
                        try
                        {
                            elementoAjustado = wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName(elementClassName)));
                            elementoAjustado.Click();
                            countInvalid = 4;
                        }
                        catch (InvalidOperationException e)
                        {
                            Console.Write("Tentando ajustar InvalidOperationException :" + e);
                            countInvalid++;
                        }
                        catch (WebDriverException e)
                        {
                            Console.Write("Tentando ajustar WebDriverException :" + e);
                            countInvalid++;
                        }
                    }

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
        /// Clica no elemento recuperado pelo TagName
        /// </summary>
        /// <param name="elementTagName">TagName do elemento web a ser clicado</param>
        /// <param name="chromedriver">Instância ativa do chromedriver</param>
        public static void ClickByTagName(string elementTagName, ChromeDriver chromedriver)
        {
            WebDriverWait wait = new WebDriverWait(chromedriver, TimeSpan.FromSeconds(30));

            int countStale = 0;
            int countInvalid = 0;
            IWebElement elementoAjustado = wait.Until(ExpectedConditions.ElementIsVisible(By.TagName(elementTagName)));

            while (countStale < 4)
            {
                try
                {
                    while (countInvalid < 4)
                    {
                        try
                        {
                            elementoAjustado = wait.Until(ExpectedConditions.ElementIsVisible(By.TagName(elementTagName)));
                            elementoAjustado.Click();
                            countInvalid = 4;
                        }
                        catch (InvalidOperationException e)
                        {
                            Console.Write("Tentando ajustar InvalidOperationException :" + e);
                            countInvalid++;
                        }
                        catch (WebDriverException e)
                        {
                            Console.Write("Tentando ajustar WebDriverException :" + e);
                            countInvalid++;
                        }
                    }

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
