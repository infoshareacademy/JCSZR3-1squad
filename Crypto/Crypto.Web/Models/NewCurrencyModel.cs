﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Crypto.Web.Models
{
    public class NewCurrencyModel
    {
        [Key]
        public int CurrencyId { get; set; }
        public string Currency { get; set; }
        public string Prices { get; set; }
        public string Timestamps { get; set; }

    }
}
