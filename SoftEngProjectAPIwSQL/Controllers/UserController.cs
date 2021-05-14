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
    public class UserController : ApiController
    {
        SoftEngProjectDBEntitiesFinal db = new SoftEngProjectDBEntitiesFinal();

        public List<UserModel> GetAllUsers()
        {
            List<UserModel> userList = db.User.Select(x => new UserModel()
            {
                userID = x.userId,
                username = x.username,
                name = x.name,
                surname = x.surname,
                mail = x.mail,
                password = x.password,
                events = x.events,
                eventsHistory = x.eventsHistory,
                points = x.points,
                phoneNumber = x.phoneNumber,
                favorites = x.favorites,
                profilePhotoURL = x.profilePhotoURL
            }).ToList();

            return userList;
        }

        [HttpPost]
        public IHttpActionResult AddUser(UserModel _model)
        {
            User newUser = new User()
            {
                userId = _model.userID,
                username = _model.username,
                name = _model.name,
                surname = _model.surname,
                mail = _model.mail,
                password = _model.password,
                events = _model.events,
                eventsHistory = _model.eventsHistory,
                points = _model.points,
                phoneNumber = _model.phoneNumber,
                favorites = _model.favorites,
                profilePhotoURL = _model.profilePhotoURL
            };
            db.User.Add(newUser);
            db.SaveChanges();
            return Ok();
        }
    }
}
