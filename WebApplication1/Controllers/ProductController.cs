using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Detay()
        {       
            
            ProductModel productModel = new ProductModel();
            productModel.Adi = "Şamdan";
            productModel.Ozellikleri = "Beş kollu gümüş şamdan";
            productModel.Fiyati = "250";

            return View(productModel);
        }
    }
}