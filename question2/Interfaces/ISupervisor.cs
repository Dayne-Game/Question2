using System;
using System.Collections.Generic;
using System.Text;
using question2.Models;

namespace question2.Interfaces
{
    interface ISupervisor
    {
        string Name { get; set; }
        string Phone { get; set; }
        string Email { get; set; }
        Address Address { get; set; }
        string Display_Data(List<Supervisor> Data);
    }
}
