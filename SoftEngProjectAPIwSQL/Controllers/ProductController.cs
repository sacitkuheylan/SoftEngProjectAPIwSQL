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
    public class ProductController : ApiController
    {
        SoftEngProjectDBEntitiesFinal db = new SoftEngProjectDBEntitiesFinal();

        public List<ProductModel> GetAllProducts()
        {
            List<ProductModel> productList = db.Product.Select(x => new ProductModel()
            {
               productId = x.productId,
               eventId = x.eventId,
               imageURL = x.imageURL,
               title = x.title,
               detail = x.detail,
               size = x.size,
               price = x.price,
               discountId = x.discountId
            }).ToList();


            return productList;
        }

        [HttpPost]
        public IHttpActionResult AddProduct(Product _model)
        {
            Product newProduct = new Product()
            {
                productId = _model.productId,
                eventId = _model.eventId,
                imageURL = _model.imageURL,
                title = _model.title,
                detail = _model.detail,
                size = _model.size,
                price = _model.price,
                discountId = _model.discountId
            };
            db.Product.Add(newProduct);
            db.SaveChanges();
            return Ok();
        }

    }
}
