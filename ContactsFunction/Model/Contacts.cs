using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsFunction.Model
{
    public class Contact
    {
        public Guid Id { get; set; }
        public string? Fullname { get; set; }
        public long Phone { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? Nickname { get; set; }
    }

    public class NewContact
    {
        public string? Fullname { get; set; }
        public long Phone { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? Nickname { get; set; }
    }
}
