using System;
using System.Collections.Generic;

namespace PhoneListApp
{
    public class PhoneList
    {
        private static readonly List<Phone> lists = new List<Phone>();

        public bool AddFruit(int id, string name)
        {
            lists.Add(new Phone { Id = id, Name = name });
            return true;
        }
    }
}
