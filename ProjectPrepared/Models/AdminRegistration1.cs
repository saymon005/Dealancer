using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectPrepared.Models
{
    public class AdminRegistration1
    {
        public int AdminId { get; set; }
        
        public string AdminFirstName { get; set; }
       
        public string AdminLastName { get; set; }
        
        public string AdminEmail { get; set; }
        [DataType(DataType.Password)]
        public string AdminPassword { get; set; }
    }
}