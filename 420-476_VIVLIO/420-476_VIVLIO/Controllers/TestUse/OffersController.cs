using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _420_476_VIVLIO.Models;

namespace _420_476_VIVLIO.Controllers.TestUse
{
    public class OffersController : Controller
    {
        private FSPCEntities1 db = new FSPCEntities1();

        // GET: Offers
        public ActionResult Index()
        {
            var offer = db.Offer.Include(o => o.Matiere).Include(o => o.Niveau).Include(o => o.User);
            return View(offer.ToList());
        }

        // GET: Offers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Offer offer = db.Offer.Find(id);
            if (offer == null)
            {
                return HttpNotFound();
            }
            return View(offer);
        }

        // GET: Offers/Create
        public ActionResult Create()
        {
            ViewBag.MatiereID = new SelectList(db.Matiere, "MatiereID", "SubjectMatter");
            ViewBag.NiveauID = new SelectList(db.Niveau, "NiveauID", "NiveauName");
            ViewBag.UserID = new SelectList(db.User, "UserID", "Login");
            return View();
        }

        // POST: Offers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OfferID,MatiereID,NiveauID,UserID,Price,CreationDate,PostedDate,Status,Photo,Author_CompanyName,Condition,Description,Name")] Offer offer)
        {
            if (ModelState.IsValid)
            {
                db.Offer.Add(offer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MatiereID = new SelectList(db.Matiere, "MatiereID", "SubjectMatter", offer.MatiereID);
            ViewBag.NiveauID = new SelectList(db.Niveau, "NiveauID", "NiveauName", offer.NiveauID);
            ViewBag.UserID = new SelectList(db.User, "UserID", "Login", offer.UserID);
            return View(offer);
        }

        // GET: Offers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Offer offer = db.Offer.Find(id);
            if (offer == null)
            {
                return HttpNotFound();
            }
            ViewBag.MatiereID = new SelectList(db.Matiere, "MatiereID", "SubjectMatter", offer.MatiereID);
            ViewBag.NiveauID = new SelectList(db.Niveau, "NiveauID", "NiveauName", offer.NiveauID);
            ViewBag.UserID = new SelectList(db.User, "UserID", "Login", offer.UserID);
            return View(offer);
        }

        // POST: Offers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OfferID,MatiereID,NiveauID,UserID,Price,CreationDate,PostedDate,Status,Photo,Author_CompanyName,Condition,Description,Name")] Offer offer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(offer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MatiereID = new SelectList(db.Matiere, "MatiereID", "SubjectMatter", offer.MatiereID);
            ViewBag.NiveauID = new SelectList(db.Niveau, "NiveauID", "NiveauName", offer.NiveauID);
            ViewBag.UserID = new SelectList(db.User, "UserID", "Login", offer.UserID);
            return View(offer);
        }

        // GET: Offers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Offer offer = db.Offer.Find(id);
            if (offer == null)
            {
                return HttpNotFound();
            }
            return View(offer);
        }

        // POST: Offers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Offer offer = db.Offer.Find(id);
            db.Offer.Remove(offer);
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
