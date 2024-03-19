using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSPets.Domain.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string WhatsappNumber { get; set; }
        public Contact() { }
        public Contact(string phone, string email, string whatsappNumber)
        {
            Phone = phone;
            Email = email;
            WhatsappNumber = whatsappNumber;
        }
    }
}
