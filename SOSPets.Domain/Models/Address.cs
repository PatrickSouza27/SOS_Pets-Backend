using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSPets.Domain.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
        public string Neighborhood { get; set; }
        public string Complement { get; set; }
        public string City { get; set; }
        public string Number { get; set; }
        public Address() { }
        public Address(string street, string postalCode, string neighborhood, string complement, string number, string city)
        {
            Street = street;
            PostalCode = postalCode;
            Neighborhood = neighborhood;
            Complement = complement;
            Number = number;
            City = city;
        }

    }
}
