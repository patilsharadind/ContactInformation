using ContactInformation.Business;
using ContactInformation.Domain;
using ContactInformation.Web.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace ContactInformation.Tests.Controllers
{
    [TestClass]
    public class ContactInfoControllerTest
    {
        private Mock<IContactManager> mockContactManager;


        /// <summary>
        /// Setup / Initilize moq data
        /// </summary>
        [TestInitialize]
        public void SetupTests()
        {
            mockContactManager = new Mock<IContactManager>();
            mockContactManager.Setup(m => m.GetContacts()).Returns(Contacts);
        }

        #region Moq data
        /// <summary>
        /// Dummy data for testing / Moq object
        /// </summary>
        /// <returns></returns>
        private List<ContactDto> Contacts()
        {
            List<ContactDto> ContactList = new List<ContactDto>() {
                new ContactDto() { FirstName = "contact 1 first name", Email = "contact@rmail1.com" },
                new ContactDto() { FirstName = "contact 2 first name", Email = "contact@rmail1.com" },
                new ContactDto() { FirstName = "contact 3 first name", Email = "contact@rmail1.com" }
           };
            return ContactList;
        }
        #endregion

        /// <summary>
        /// Test view result is not empty
        /// </summary>
        [TestMethod]
        public void Index()
        {
            ContactInfoController controller = new ContactInfoController(mockContactManager.Object);
            ViewResult result = controller.Index() as ViewResult;
            Assert.IsNotNull(result);
        }

        /// <summary>
        /// Test List count
        /// </summary>
        [TestMethod]
        public void Index_List_Count_IsValid()
        {
            ContactInfoController controller = new ContactInfoController(mockContactManager.Object);
            ViewResult result = controller.Index() as ViewResult;
            var modal = result.Model as List<ContactDto>;
            Assert.AreEqual(modal.Count, 3);
        }

        [TestMethod]
        public void Create()
        {
            ContactInfoController controller = new ContactInfoController(mockContactManager.Object);
            ViewResult result = controller.Index() as ViewResult;
            Assert.IsNotNull(result);
        }

        /// <summary>
        /// Validate first name property in Add method
        /// </summary>
        [TestMethod]
        public void Validate_Add_FirstName()
        {
            ContactInfoController controller = new ContactInfoController(mockContactManager.Object);

            ViewResult result = controller.Create(new ContactDto() { FirstName = "FirstName" }) as ViewResult;

            mockContactManager.Verify(x => x.Add(It.Is<ContactDto>(y => y.FirstName.Equals("FirstName"))), Times.Once()); 
           
            Assert.IsNotNull(result);
        }
    }

}
