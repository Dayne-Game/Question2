using System;
using System.Collections.Generic;
using System.Text;
using question2.Models;

namespace question2.Interfaces
{
    public interface IPerson
    {
        string Name { get; set; }
        string Phone { get; set; }
        string Email { get; set; }
        string Display_Data(List<Person> Data);
    }
}
