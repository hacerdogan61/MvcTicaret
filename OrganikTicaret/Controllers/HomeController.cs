using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OrganikTicaret.Entity;
using OrganikTicaret.Models;

namespace OrganikTicaret.Controllers
{
    
    public class HomeController : Controller
    { DataContext db=new DataContext();
        // GET: Home
        public ActionResult Index()
        {
            var li = db.pro.Where(i=>i.IsApproved  && i.IsHome).Select(i=>new ProductModel
            {
                Id = i.Id,
                Name = i.Name.Length>20?i.Name.Substring(0,20)+"...":i.Name,
                Description = i.Description.Length>50?i.Description.Substring(0,47)+"...":i.Description,
                DiametreandSize = i.DiametreandSize,
                OutputDiametre = i.OutputDiametre,
                OutputDirection = i.OutputDirection,
                ProductCode = i.ProductCode,
                Image = i.Image??"mango.jpg",
                CategoryId = i.CategoryId
             
            }).ToList();
            return View(li);
        }
        public ActionResult Details(int id)
        {
            return View(db.pro.Where(i => i.Id==id).FirstOrDefault());
        }
        public ActionResult List(int? id)
        {

            var li = db.pro.Where(i => i.IsApproved ).Select(i => new ProductModel
            {
                Id = i.Id,
                Name = i.Name,
                Description = i.Description.Length > 50 ? i.Description.Substring(0, 47) + "..." : i.Description,
                DiametreandSize = i.DiametreandSize,
                OutputDiametre = i.OutputDiametre,
                ProductCode = i.ProductCode,
                OutputDirection = i.OutputDirection,
                Image = i.Image,
                CategoryId = i.CategoryId

            }).AsQueryable();
            if (id!=null)
            {
                li = li.Where(i => i.CategoryId == id);
            }
            return View(li.ToList());
        }
        public PartialViewResult GetCategory()
        {
            return PartialView(db.cat.ToList());
        }
    }
}