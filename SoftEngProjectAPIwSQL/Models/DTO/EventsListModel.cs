using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftEngProjectAPIwSQL.Models.DTO
{
    public class EventsListModel
    {
        public int eventId { get; set; }
        public string title { get; set; }
        public string detail { get; set; }
        public int artistId { get; set; }
        public string date { get; set; }
        public int guestCount { get; set; }
        public int guestLimit { get; set; }
        public int VIPLimit { get; set; }
        public string address { get; set; }
        public string location { get; set; }
        public string contacts { get; set; }
        public int price { get; set; }
        public int categoryId { get; set; }
        public string imageURL { get; set; }
    }
}