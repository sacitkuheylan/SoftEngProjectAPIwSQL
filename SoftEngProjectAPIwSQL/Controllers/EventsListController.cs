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
    public class EventsListController : ApiController
    {
        SoftEngProjectDBEntitiesFinal db = new SoftEngProjectDBEntitiesFinal();

        public List<EventsListModel> GetAllCategory()
        {
            List<EventsListModel> eventList = db.EventsList.Select(x => new EventsListModel()
            {
                eventId = x.eventId,
                title = x.title,
                detail = x.detail,
                artistId = x.artistId,
                date = x.date,
                guestCount = x.guestCount,
                guestLimit = x.guestLimit,
                VIPLimit = x.VIPLimit,
                address = x.address,
                location = x.location,
                contacts = x.contacts,
                price = x.price,
                categoryId = x.categoryId,
                imageURL = x.imageURL
            }).ToList();

            return eventList;
        }

        [HttpPost]
        public IHttpActionResult AddEvent(EventsListModel _model)
        {
            EventsList newEvent = new EventsList()
            {
                eventId = _model.eventId,
                title = _model.title,
                detail = _model.detail,
                artistId = _model.artistId,
                date = _model.date,
                guestCount = _model.guestCount,
                guestLimit = _model.guestLimit,
                VIPLimit = _model.VIPLimit,
                address = _model.address,
                location = _model.location,
                contacts = _model.contacts,
                price = _model.price,
                categoryId = _model.categoryId,
                imageURL = _model.imageURL
            };
            db.EventsList.Add(newEvent);
            db.SaveChanges();
            return Ok();
        }
    }
}
