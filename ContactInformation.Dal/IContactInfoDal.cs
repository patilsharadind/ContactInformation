using ContactInformation.Dal.EntityData;
using ContactInformation.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactInformation.Dal
{
    public interface IContactInfoDal:IRepository<Contact>
    {
        /// <summary>
        /// Get contacts 
        /// </summary>
        /// <returns></returns>
        IList<ContactDto> GetContacts();

        /// <summary>
        /// Get contact by Id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        ContactDto GetContactById(int Id);
    }
}
