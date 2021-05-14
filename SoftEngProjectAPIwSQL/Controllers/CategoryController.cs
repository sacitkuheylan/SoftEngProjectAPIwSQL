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
    public class CategoryController : ApiController
    {
        SoftEngProjectDBEntitiesFinal db = new SoftEngProjectDBEntitiesFinal();

        public List<CategoryModel> GetAllCategory()
        {
            List<CategoryModel> artistList = db.Category.Select(x => new CategoryModel()
            {
                categoryId = x.categoryId,
                name = x.name,
            }).ToList();

            return artistList;
        }

        [HttpPost]
        public IHttpActionResult AddCategory(CategoryModel _model)
        {
            Category newCategory = new Category()
            {
                categoryId = _model.categoryId,
                name = _model.name,
            };
            db.Category.Add(newCategory);
            db.SaveChanges();
            return Ok();
        }
    }
}
