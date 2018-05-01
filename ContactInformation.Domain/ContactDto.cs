using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContactInformation.Domain
{
    /// <summary>
    /// Contact domain object
    /// </summary>
    public class ContactDto
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(15)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(15)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(10)]
        [RegularExpression("^(?!0+$)(\\+\\d{1,3}[- ]?)?(?!0+$)\\d{10,15}$", ErrorMessage = "Please enter valid phone no.")]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name = "Status")]
        [Status]
        public string Status { get; set; }

        public List<string> StatusList {
            get
            {
                return new List<string> { "Active", "InActive" };
            } 
        }

      //  public EnumStatus StatusList { get; set; }
    }
    public enum EnumStatus
    {
        Active,
        InActive
    }
}
