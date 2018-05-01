using ContactInformation.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContactInformation.Web.Models
{
    public class ContactViewModel
    {
        public ContactDto ContactDto { get; set; }
        public IList<ContactDto> Contacts { get; set; }
    }
}