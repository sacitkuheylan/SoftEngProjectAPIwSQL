using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoftEngProjectAPIwSQL.Models.DTO
{
    public class CommentModel
    {
        public int commentId { get; set; }
        public int userId { get; set; }
        public int eventId { get; set; }
        public string title { get; set; }
        public string detail { get; set; }

    }
}