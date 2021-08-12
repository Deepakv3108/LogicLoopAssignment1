using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace LogicLoopAssignment2.Models
{
    public class ForeignExchange
    {
        public ForeignExchange()
        {
            rates = new Rates();
        }
        public bool success { get; set; }
        [JsonProperty(PropertyName = "base")]
        public string baseCurrency { get; set; }
        public string date { get; set; }
        public Rates rates { get; set; }
    }
}