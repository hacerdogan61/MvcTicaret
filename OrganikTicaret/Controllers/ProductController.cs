using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OrganikTicaret.Entity;

namespace OrganikTicaret.Controllers
{
    [Authorize(Roles = "admin")]
    public class ProductController : Controller
    {   
        private DataContext db = new DataContext();

        // GET: Product
        public ActionResult Index()
        {
            var pro = db.pro.Include(p => p.Category);
            return View(pro.ToList());
        }

        // GET: Product/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Products products = db.pro.Find(id);
            if (products == null)
            {
                return HttpNotFound();
            }
            return View(products);
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            ViewBag.CategoryId = new SelectList(db.cat, "Id", "CategoryName");
            return View();
        }

        // POST: Product/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Description,ProductCode,DiametreandSize,OutputDirection,OutputDiametre,Price,Stock,Image,IsHome,IsApproved,CategoryId,IsDelete")] Products products)
        {
            if (ModelState.IsValid)
            {
                db.pro.Add(products);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CategoryId = new SelectList(db.cat, "Id", "CategoryName", products.CategoryId);
            return View(products);
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Products products = db.pro.Find(id);
            if (products == null)
            {
                return HttpNotFound();
            }
            ViewBag.CategoryId = new SelectList(db.cat, "Id", "CategoryName", products.CategoryId);
            return View(products);
        }

        // POST: Product/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Description,ProductCode,DiametreandSize,OutputDirection,OutputDiametre,Price,Stock,Image,IsHome,IsApproved,CategoryId,IsDelete")] Products products)
        {
            if (ModelState.IsValid)
            {
                db.Entry(products).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CategoryId = new SelectList(db.cat, "Id", "CategoryName", products.CategoryId);
            return View(products);
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Products products = db.pro.Find(id);
            if (products == null)
            {
                return HttpNotFound();
            }
            return View(products);
        }

        // POST: Product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Products products = db.pro.Find(id);
            db.pro.Remove(products);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
