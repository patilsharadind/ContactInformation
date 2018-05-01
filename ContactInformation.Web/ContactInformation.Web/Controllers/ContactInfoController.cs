using ContactInformation.Business;
using ContactInformation.Domain;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ContactInformation.Web.Controllers
{
    /// <summary>
    /// Contact information controller 
    /// </summary>
    public class ContactInfoController : BaseController
    {
        private readonly IContactManager _iContactManager;

        /// <summary>
        /// Constructor 
        /// </summary>
        /// <param name="iContactManager"></param>
        public ContactInfoController(IContactManager iContactManager)
        {
            _iContactManager = iContactManager;
        }

        /// <summary>
        /// Get contact list 
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            List<ContactDto> contacts = _iContactManager.GetContacts();

            return View(contacts);
        }

        public ActionResult Create()
        {
            return View(new ContactDto());
        }

        /// <summary>
        /// Create contact
        /// </summary>
        /// <param name="contactDto"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Create(ContactDto contactDto)
        {
            bool result = false;
            if (ModelState.IsValid)
                result = _iContactManager.Add(contactDto);
            else
                result = false;

            if (result)
                return RedirectToAction("Index");
            else
                return View(contactDto);
        }

        public ActionResult Edit(int Id)
        {
            return View(_iContactManager.GetContactById(Id));
        }

        /// <summary>
        /// Update Contact
        /// </summary>
        /// <param name="contactDto"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Edit(ContactDto contactDto)
        {
            bool result = false;
            if (ModelState.IsValid)
                result = _iContactManager.Update(contactDto);
            else
                result = false;

            if (result)
                return RedirectToAction("Index");
            else
                return View(contactDto);
        }

        /// <summary>
        /// Delete contact
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public ActionResult Delete(int Id)
        {
            _iContactManager.Delete(Id);
            //TODO: Suscess result messgae generic
            return RedirectToAction("Index");
        }
    }

}


