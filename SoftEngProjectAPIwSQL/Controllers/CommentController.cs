using SoftEngProjectAPIwSQL.Models;
using SoftEngProjectAPIwSQL.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SoftEngProjectAPIwSQL.Controllers
{
    public class CommentController : ApiController
    {
        SoftEngProjectDBEntitiesFinal db = new SoftEngProjectDBEntitiesFinal();

        public List<CommentModel> GetAllComments()
        {
            List<CommentModel> artistList = db.Comments.Select(x => new CommentModel()
            {
                commentId = x.commentId,
                userId = x.userId,
                eventId = x.eventId,
                title = x.title,
                detail = x.detail
            }).ToList();

            return artistList;
        }

        [HttpPost]
        public IHttpActionResult AddComment(CommentModel _model)
        {
            Comments newComment = new Comments()
            {
                commentId = _model.commentId,
                userId = _model.userId,
                eventId = _model.eventId,
                title = _model.title,
                detail = _model.detail
            };
            db.Comments.Add(newComment);
            db.SaveChanges();
            return Ok();
        }
    }
}
