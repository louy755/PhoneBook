using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PhoneListApp
{
    public class Phone
    {
        private static readonly List<Phone> lists = new List<Phone>();

        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }


        public string PhoneFormating(string value)
        {
            return PhoneNumber = Regex.Replace($"{value}", @"(\d{3})(\d{3})(\d{4})", "$1-$2-$3");
        }

        public Phone() { }
        public string getData()
        {
            return "| " + Id + "- | " + Name + " | " + PhoneFormating(PhoneNumber) + " |";
        }
        
    }
}
