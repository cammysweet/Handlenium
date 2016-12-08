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
    public static class AjustComboBox
    {

        /// <summary>
        /// Escolhe uma opção em um combobox
        /// </summary>
        /// <param name="elementId">Id do combobox</param>
        /// <param name="labelOption">Texto da opção a ser escolhida</param>
        /// <param name="chromedriver">Instância ativa de chromedriver</param>
        public static void ChooseComboBoxOptionById(string elementId, string labelOption, ChromeDriver chromedriver)
        {
            WebDriverWait wait = new WebDriverWait(chromedriver, TimeSpan.FromSeconds(30));

            int countStale = 0;

            IWebElement elementoAjustado = wait.Until(ExpectedConditions.ElementIsVisible(By.Id(elementId)));

            while (countStale < 4)
            {
                try
                {

                    IList<IWebElement> comboOptions = elementoAjustado.FindElements(By.TagName("option"));
                    foreach (IWebElement option in comboOptions)
                    {
                        if (option.Text == labelOption)
                        {
                            option.Click();
                            break;
                        }
                    }


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
        /// Escolhe uma opção em um combobox
        /// </summary>
        /// <param name="elementName">Name do combobox</param>
        /// <param name="labelOption">Texto da opção a ser escolhida</param>
        /// <param name="chromedriver">Instância ativa de chromedriver</param>
        public static void ChooseComboBoxOptionByName(string elementName, string labelOption, ChromeDriver chromedriver)
        {
            WebDriverWait wait = new WebDriverWait(chromedriver, TimeSpan.FromSeconds(30));

            int countStale = 0;

            IWebElement elementoAjustado = wait.Until(ExpectedConditions.ElementIsVisible(By.Name(elementName)));

            while (countStale < 4)
            {
                try
                {

                    IList<IWebElement> comboOptions = elementoAjustado.FindElements(By.TagName("option"));
                    foreach (IWebElement option in comboOptions)
                    {
                        if (option.Text == labelOption)
                        {
                            option.Click();
                            break;
                        }
                    }


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
        /// Escolhe uma opção em um combobox
        /// </summary>
        /// <param name="elementXPath">XPath do combobox</param>
        /// <param name="labelOption">Texto da opção a ser escolhida</param>
        /// <param name="chromedriver">Instância ativa de chromedriver</param>
        public static void ChooseComboBoxOptionByXPath(string elementXPath, string labelOption, ChromeDriver chromedriver)
        {
            WebDriverWait wait = new WebDriverWait(chromedriver, TimeSpan.FromSeconds(30));

            int countStale = 0;

            IWebElement elementoAjustado = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(elementXPath)));

            while (countStale < 4)
            {
                try
                {

                    IList<IWebElement> comboOptions = elementoAjustado.FindElements(By.TagName("option"));
                    foreach (IWebElement option in comboOptions)
                    {
                        if (option.Text == labelOption)
                        {
                            option.Click();
                            break;
                        }
                    }


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
        /// Escolhe uma opção em um combobox
        /// </summary>
        /// <param name="elementClassName">ClassName do combobox</param>
        /// <param name="labelOption">Texto da opção a ser escolhida</param>
        /// <param name="chromedriver">Instância ativa de chromedriver</param>
        public static void ChooseComboBoxOptionByClassName(string elementClassName, string labelOption, ChromeDriver chromedriver)
        {
            WebDriverWait wait = new WebDriverWait(chromedriver, TimeSpan.FromSeconds(30));

            int countStale = 0;

            IWebElement elementoAjustado = wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName(elementClassName)));

            while (countStale < 4)
            {
                try
                {

                    IList<IWebElement> comboOptions = elementoAjustado.FindElements(By.TagName("option"));
                    foreach (IWebElement option in comboOptions)
                    {
                        if (option.Text == labelOption)
                        {
                            option.Click();
                            break;
                        }
                    }


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
        /// Escolhe uma opção em um combobox
        /// </summary>
        /// <param name="elementTagName">TagName do combobox</param>
        /// <param name="labelOption">Texto da opção a ser escolhida</param>
        /// <param name="chromedriver">Instância ativa de chromedriver</param>
        public static void ChooseComboBoxOptionByTagName(string elementTagName, string labelOption, ChromeDriver chromedriver)
        {
            WebDriverWait wait = new WebDriverWait(chromedriver, TimeSpan.FromSeconds(30));

            int countStale = 0;

            IWebElement elementoAjustado = wait.Until(ExpectedConditions.ElementIsVisible(By.TagName(elementTagName)));

            while (countStale < 4)
            {
                try
                {

                    IList<IWebElement> comboOptions = elementoAjustado.FindElements(By.TagName("option"));
                    foreach (IWebElement option in comboOptions)
                    {
                        if (option.Text == labelOption)
                        {
                            option.Click();
                            break;
                        }
                    }


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
