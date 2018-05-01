using ContactInformation.Dal.EntityData;
using ContactInformation.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactInformation.Dal.Mappings
{
    internal class ContactDtoMapping
    {
        /// <summary>
        /// Converts the specified Contact list to a list of data transfer objects.
        /// </summary>
        /// <param name="contacts"></param>
        /// <returns>A list of ContactDto objects.</returns>
        public static IList<ContactDto> Convert(IEnumerable<Contact> contacts)
        {
            return contacts == null ? new List<ContactDto>() : contacts.Select(Convert).ToList();
        }
        public static ContactDto Convert(Contact contact)
        {
            if (contact == null)
                throw new ArgumentException("The contact object supplied for conversion cannot be null");

            ContactDto output = new ContactDto
            {
                Id = contact.Id,
                FirstName = contact.FirstName,
                LastName = contact.LastName,
                Email = contact.EmailAddress,
                PhoneNumber = contact.PhoneNumber,
                Status = contact.Status
            };
            return output;
        }

    }
}

