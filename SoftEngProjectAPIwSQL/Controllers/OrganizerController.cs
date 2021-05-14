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
    public class OrganizerController : ApiController
    {

        SoftEngProjectDBEntitiesFinal db = new SoftEngProjectDBEntitiesFinal();

        public List<OrganizerModel> GetAlOrganizers()
        {
            List<OrganizerModel> organizerList = db.Organizer.Select(x => new OrganizerModel()
            {
                organizerId = x.organizerId,
                name = x.name,
                address = x.address,
                location = x.location,
                contact = x.contact
            }).ToList();


            return organizerList;
        }

        [HttpPost]
        public IHttpActionResult AddUser(Organizer _model)
        {
            Organizer newOrganizer = new Organizer()
            {
               organizerId = _model.organizerId,
               name = _model.name,
               address = _model.name,
               location = _model.address,
               contact = _model.contact
            };
            db.Organizer.Add(newOrganizer);
            db.SaveChanges();
            return Ok();
        }
    }
}
