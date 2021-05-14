using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftEngProjectAPIwSQL.Models.DTO
{
    public class UserModel
    {
        public int userID { get; set; }
        public string username { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string mail { get; set; }
        public string password { get; set; }
        public string events { get; set; }
        public string eventsHistory { get; set; }
        public int points { get; set; }
        public string phoneNumber { get; set; }
        public string favorites { get; set; }
        public string profilePhotoURL { get; set; }
    }
}