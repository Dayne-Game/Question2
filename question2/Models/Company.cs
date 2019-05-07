using System;
using System.Collections.Generic;
using System.Text;
using question2.Interfaces;

namespace question2.Models
{
    public class Company : ICompany
    {
        public string name { get; set; }
        public string catchPhrase { get; set; }
        public string bs { get; set; }
    }
}
