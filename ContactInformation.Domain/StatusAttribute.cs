using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContactInformation.Domain
{
    /// <summary>
    /// Custom validation for status, Values can be only Active/Inactive
    /// </summary>
    public class StatusAttribute : ValidationAttribute
    {
        public List<string> statusList = new List<string>() { "Active", "InActive" };
        public override bool IsValid(object value)
        {

            if (value != null && statusList.Contains(value.ToString()))
            {
                return true;
            }
            return false;
        }
    }
}

