﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace lab17miya.Models
{
    public class Supplies
    {
        [Key]
        public int SupplyID
        {
            get; set;
        }
        public string Name
        {
            get; set;
        }
        public int Quantity
        {
            get; set;
        }
        public int WeatherID
        {
            get; set;
        }
    }
}
