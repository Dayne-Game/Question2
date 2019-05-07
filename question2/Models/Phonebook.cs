using System;
using System.Collections.Generic;
using System.Text;
using question2.Interfaces;

namespace question2.Models
{
    public class Phonebook
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public IAddress Address { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
        public ICompany Company { get; set; }
    }
}
