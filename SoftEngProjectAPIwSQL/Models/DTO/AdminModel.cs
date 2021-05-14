using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftEngProjectAPIwSQL.Models.DTO
{
    public class AdminModel
    {
        public int adminId { get; set; }
        public int userId { get; set; }
        public int organizerId { get; set; }
    }
}