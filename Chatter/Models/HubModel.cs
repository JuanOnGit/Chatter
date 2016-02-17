using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Chatter.Models
{
    public class HubModel
    {
        public string HubName { get; set; }
        [Key]
        public int HubID { get; set; }
        public int UserCount { get; set; }
    }
}