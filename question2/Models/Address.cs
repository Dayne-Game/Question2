using System;
using System.Collections.Generic;
using System.Text;
using question2.Interfaces;

namespace question2.Models
{
    public class Address : IAddress
    {
        public string Street { get; set; }
        public string City { get; set; }
    }
}
