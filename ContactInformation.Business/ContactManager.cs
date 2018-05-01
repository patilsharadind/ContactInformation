using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactInformation.Domain;
using ContactInformation.Dal;
using ContactInformation.Dal.EntityData;

namespace ContactInformation.Business
{
    public class ContactManager : IContactManager
    {
        private IContactInfoDal _contactInfoDal;
        ContactEntities _context = new ContactEntities();

        public ContactManager()
        {
            _contactInfoDal = new ContactInfoDal(_context);
        }

        public bool Add(ContactDto contactDto)
        {
            try
            {
                Contact contact = new Contact()
                {
                    FirstName = contactDto.FirstName,
                    LastName = contactDto.LastName,
                    EmailAddress = contactDto.Email,
                    PhoneNumber = contactDto.PhoneNumber,
                    Status = contactDto.Status
                };
                _contactInfoDal.Insert(contact);
                _contactInfoDal.Save();
                return true;
            }
            catch
            {
                throw;
            }
        }

        public bool Update(ContactDto contactDto)
        {
            try
            {
                Contact contact = new Contact()
                {
                    Id = contactDto.Id,
                    FirstName = contactDto.FirstName,
                    LastName = contactDto.LastName,
                    EmailAddress = contactDto.Email,
                    PhoneNumber = contactDto.PhoneNumber,
                    Status = contactDto.Status
                };
                _contactInfoDal.Update(contact);
                _contactInfoDal.Save();
                return true;
            }
            catch
            {
                throw;
            }
        }

        public bool Delete(int Id)
        {
            try
            {
                _contactInfoDal.Delete(Id);
                _contactInfoDal.Save();
                return true;
            }
            catch
            {
                throw;
            }
        }

        public ContactDto GetContactById(int Id)
        {
            try
            {
                return _contactInfoDal.GetContactById(Id);
            }
            catch
            {
                throw;
            }
        }

        public List<ContactDto> GetContacts()
        {
            try
            {
                return _contactInfoDal.GetContacts().ToList();
            }
            catch
            {
                throw;
            }
        }

    }
}

