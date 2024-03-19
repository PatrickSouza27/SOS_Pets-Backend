using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSPets.Domain.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Cpf { get; set; }
        public DateTime Birthday { get; set; }
        public string PhotoLink { get; set; }
        public Address Address { get; set; }
        public Contact Contact { get; set; }
        public User() { }

        public User(string name, string lastName, string cpf, DateTime birthday, string photoLink)
        {
            Name = name;
            LastName = lastName;
            Cpf = cpf;
            Birthday = birthday;
            PhotoLink = photoLink;
        }

        public User(string name, string lastName, string cpf, DateTime birthday,  Address address, Contact contact) : this (name, lastName, cpf, birthday)
        {
            Address = address;
            Contact = contact;
        }

        public void SetAddress(Address address) => Address = address;
        public void SetContact(Contact contact) => Contact = contact;
    }
}
