using System;
namespace StoreDataIOS
{
    public class Contacts
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public Contacts(string name,string phone)
        {
            Name = name;
            PhoneNumber = phone;
        }

        public override string ToString()
        {
            return Name + "  " + PhoneNumber;
        }
    }
}
