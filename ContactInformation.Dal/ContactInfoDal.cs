using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactInformation.Domain;
using ContactInformation.Dal.EntityData;
using ContactInformation.Dal.Mappings;

namespace ContactInformation.Dal
{
    /// <summary>
    /// Contact repository
    /// </summary>
    public class ContactInfoDal : Repository<Contact>, IContactInfoDal
    {
        public ContactInfoDal(ContactEntities _context) : base(_context)
        {

        }
        public IList<ContactDto> GetContacts()
        {
            var contacts = Get();
            return ContactDtoMapping.Convert(contacts);
        }

        public ContactDto GetContactById(int Id)
        {
            var contacts = context.Contacts.Where(x => x.Id == Id).SingleOrDefault();
            return ContactDtoMapping.Convert(contacts);
        }

    }

}
