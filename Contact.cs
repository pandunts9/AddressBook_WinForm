using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AddressBook
{
    class Contact
    {
        public Guid id;
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String FullName => $"{FirstName} {LastName}";
        public String Email { get; set; }
        public int PhoneNumber { get; set; }
        public String PhysicalAddress { get; set; }
        

        public Contact()
        {
            id = new Guid();
        }
        public Contact(string firstName,string lastName,string email,string physicalAddress,int phoneNumber)
        {
            firstName = FirstName;
            LastName  = LastName;
            email = Email;
            phoneNumber = PhoneNumber;
            physicalAddress = PhysicalAddress;
        }
    }
}
