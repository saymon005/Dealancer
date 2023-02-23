using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectPrepared.Models
{
    public class Registration1
    {
        public int appID { get; set; }
        
        public string appName { get; set; }
        public string appLocation { get; set; }
        public string appPhone { get; set; }
        public string appEmail { get; set; }
        public DateTime appRegDate { get; set; }
        public string appTypes { get; set; }
        [DataType("Password")]
        public string appPassword { get; set; }

    }
    public enum appTypes1
    {
        Investor,
        Startup
    }
}
