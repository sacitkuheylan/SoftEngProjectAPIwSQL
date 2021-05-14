using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftEngProjectAPIwSQL.Models.DTO
{
    public class ProductModel
    {
        public int productId { get; set; }
        public Nullable<int> eventId { get; set; }
        public string imageURL { get; set; }
        public string title { get; set; }
        public string detail { get; set; }
        public Nullable<int> size { get; set; }
        public Nullable<int> price { get; set; }
        public Nullable<int> discountId { get; set; }
    }
}