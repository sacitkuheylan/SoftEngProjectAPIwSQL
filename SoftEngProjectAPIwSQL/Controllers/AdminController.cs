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
    public class AdminController : ApiController
    {
        SoftEngProjectDBEntitiesFinal db = new SoftEngProjectDBEntitiesFinal();

        public List<AdminModel> GetAllAdmins()
        {
            List<AdminModel> adminList = db.Admin.Select(x => new AdminModel()
            {
                adminId = x.adminId,
                organizerId = x.organizerId,
                userId = x.userId
            }).ToList();


            return adminList;
        }

        [HttpPost]
        public IHttpActionResult AddAdmin(Admin _model)
        {
            Admin newAdmin = new Admin()
            {
                adminId = _model.adminId,
                organizerId = _model.organizerId,
                userId = _model.userId
            };
            db.Admin.Add(newAdmin);
            db.SaveChanges();
            return Ok();
        }
    }
}
