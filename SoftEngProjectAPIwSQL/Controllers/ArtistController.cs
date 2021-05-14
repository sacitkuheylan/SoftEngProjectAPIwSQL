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
    public class ArtistController : ApiController
    {
        SoftEngProjectDBEntitiesFinal db = new SoftEngProjectDBEntitiesFinal();

        public List<ArtistModel> GetAllArtists()
        {
            List<ArtistModel> artistList = db.Artist.Select(x => new ArtistModel()
            {
                artistId = x.artistId,
                name = x.name,
                surname = x.surname,
                contact = x.contact
            }).ToList();

            return artistList;
        }

        [HttpPost]
        public IHttpActionResult AddArtist(ArtistModel _model)
        {
            Artist newArtist = new Artist()
            {
                artistId = _model.artistId,
                name = _model.name,
                surname = _model.surname,
                contact = _model.contact
            };
            db.Artist.Add(newArtist);
            db.SaveChanges();
            return Ok();
        }
    }
}
