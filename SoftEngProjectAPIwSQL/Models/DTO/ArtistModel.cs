using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftEngProjectAPIwSQL.Models.DTO
{
    public class ArtistModel
    {
        public int artistId { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string contact { get; set; }
    }
}