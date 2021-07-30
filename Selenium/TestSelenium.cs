using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading;

namespace Selenium
{
    public class TestSelenium
    {
        [Test]
        public void SeleniumCheck()
        {
            var driver = new ChromeDriver();
            driver.Url = "https://www.amazon.com";
            var element = driver.FindElementByXPath("/html/body/div[1]/header/div/div[1]/div[2]/div/form/div[2]/div[1]/input");
            element.SendKeys("qa testing for beginners");
            element = driver.FindElementByXPath("/html/body/div[1]/header/div/div[1]/div[2]/div/form/div[3]/div/span/input");
            element.Click();
            Thread.Sleep(1000);
            element = driver.FindElementByXPath("/html/body/div[1]/div[2]/div[1]/div/div[1]/div/span[3]/div[2]/div[1]/div/span/div/div/div[2]/div[2]/div/div/div[1]/h2/a/span");
            element.Click();
            element = driver.FindElementByXPath("/html/body/div[1]/div[2]/div[4]/div[9]/div/div[2]/div[2]/div/div/div[2]/div[1]/div/div/div/div/div/div/div[2]/div/div[2]/div/form/div/div/div[12]/div[1]/span/span/input");
            element.Click();
            element = driver.FindElementByXPath("/html/body/div[1]/div/div[3]/div[2]/div[1]/div/div/div[4]/div/div/div/span[2]/span/a");
            element.Click();
        }
        [Test]
        public void StatusCodeCheckGet()
        {
            RestClient client = new RestClient("http://dummy.restapiexample.com/api/v1/employees/1");
            RestRequest request = new RestRequest("nl/3825", Method.GET);
            IRestResponse response = client.Execute(request);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            var data= response.Content;
            Console.WriteLine(data);
            Console.ReadLine();
        }
        [Test]
        public void StatusCodeCheckDelete()
        {
            //
            RestClient client = new RestClient("http://dummy.restapiexample.com/public/api/v1/delete/2");
            RestRequest request = new RestRequest("nl/3825", Method.DELETE);
            IRestResponse response = client.Execute(request);
            Assert.That(response.StatusCode, Is.EqualTo(HttpStatusCode.OK));
            Console.WriteLine("\"message\": \"successfully! deleted Records\"");
        }
    }
}
