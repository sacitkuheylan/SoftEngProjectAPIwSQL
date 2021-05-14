using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftEngProjectAPIwSQL.Models.DTO
{
    public class OrganizerModel
    {
        public int organizerId { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string location { get; set; }
        public string contact { get; set; }
    }
}