using LogicLoopAssignment2.Models;
using LogicLoopAssignment2.Utility;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Routing;

namespace LogicLoopAssignment2.Controllers
{
    public class CurrencyConvertorController : ApiController
    {
        public string apiKey = ConfigurationManager.AppSettings["fixerAPItoken"].ToString();
        
        [HttpGet]
        [Route("USD/{amount}/INR")]
        public string GetR(decimal amount)
        {
            var x = getfixerData();
            decimal oneEuroInUSD = x.rates.USD;
            decimal oneEuroInINR = x.rates.INR;

            decimal oneUSDInEuro = 1 / oneEuroInUSD;
            decimal USDInINR = oneUSDInEuro * oneEuroInINR * amount;
            return amount + " USD in INR will be Rs. " + Math.Round(USDInINR,2).ToString();
        }

        [HttpGet]
        [Route("EUR/{amount}/USD")]
        public string GetD(decimal amount)
        {
            var x = getfixerData();
            decimal oneEuroInUSD = x.rates.USD;
            decimal EuroInUSD = oneEuroInUSD * amount;
            return amount + " EURO in USD will be $" + Math.Round(EuroInUSD, 2).ToString();
        }

        private ForeignExchange getfixerData()
        {
            var responseString = "";
            var request = (HttpWebRequest)WebRequest.Create(apiKey);
            request.Method = "GET";
            request.ContentType = "application/json";

            using (var response1 = request.GetResponse())
            {
                using (var reader = new StreamReader(response1.GetResponseStream()))
                {
                    responseString = reader.ReadToEnd();
                }
            }
            return JsonConvert.DeserializeObject<ForeignExchange>(responseString);
        }
    }
}