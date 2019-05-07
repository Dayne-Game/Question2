using System;
using System.Collections.Generic;
using System.Text;
using question2.Interfaces;

namespace question2.Models
{
    class Geo : IGeo
    {
        public string lat { get; set; }
        public string lng { get; set; }
    }
}
