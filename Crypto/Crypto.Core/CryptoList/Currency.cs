﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crypto.Core.CryptoList
{
    public class CurrencyTest
    {
        public string Currency { get; set; }
        public string[] Prices { get; set; }
        public string[] Timestamps { get; set; }
    }
}
