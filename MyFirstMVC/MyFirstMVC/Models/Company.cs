﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstMVC.Models
{
    public class Company : Entity
    {
        public string Name { get; set; }


        public IEnumerable<Phone> Phones { get; set; }
    }
}
