using ContactInformation.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactInformation.Business
{
    public interface IContactManager
    {
        /// <summary>
        /// Add contact 
        /// </summary>
        /// <param name="contactDto"></param>
        /// <returns></returns>
        bool Add(ContactDto contactDto);

        /// <summary>
        /// Update contact
        /// </summary>
        /// <param name="contactDto"></param>
        /// <returns></returns>
        bool Update(ContactDto contactDto);

        /// <summary>
        /// Delete conntact
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        bool Delete(int Id);

        /// <summary>
        /// List all contact object
        /// </summary>
        /// <returns></returns>
        List<ContactDto> GetContacts();

        /// <summary>
        /// Get contact by Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        ContactDto GetContactById(int Id);
    }
}
