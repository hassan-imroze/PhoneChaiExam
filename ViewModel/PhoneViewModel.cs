﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
namespace ViewModel
{
    public class PhoneViewModel
    {
        public PhoneViewModel(Phone phone)
        {
            this.Id = phone.ID;            
            Name = phone.Name;
            Price = phone.Price;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Cpu { get; set; }
        public string Camera { get; set; }
        public string Memory { get; set; }
        public string Size { get; set; }
        public string Resolution { get; set; }
        public double Price { get; set; }
    }
}
