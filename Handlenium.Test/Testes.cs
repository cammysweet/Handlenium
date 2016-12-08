using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Handlenium;

namespace Handlenium.Test
{
    public class Testes
    {
        public Testes()
        {

        }

        ChromeDriver chromedriver;

        ChromeDriver abreChrome()
        {
            chromedriver = new ChromeDriver();
            chromedriver.Manage().Window.Maximize();
            chromedriver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(2));
            chromedriver.Navigate().GoToUrl("http://teste.bne.com.br/");
            return chromedriver;
        }


        public void Testando()
        {
            chromedriver = abreChrome();

            AjustClick a = new AjustClick();

            a.ClickById("btiEntrar", chromedriver);

        }

    }
}
