using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Alpaca.Notes.Web.Data;
using Alpaca.Notes.Web.Models;

namespace Alpaca.Notes.Web.Controllers
{
    public class NoteUsersController : Controller
    {
        private AlpacaNotesWebContext db = new AlpacaNotesWebContext();

        // GET: NoteUsers
        public ActionResult Index()
        {
            return View(db.NoteUsers.ToList());
        }

        // GET: NoteUsers/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return RedirectToAction("Index","NoteUsers");
            }
            NoteUser noteUser = db.NoteUsers.FirstOrDefault(x => x.UserID == id);
            if (noteUser == null)
            {
                return RedirectToAction("Index", "NoteUsers");
            }
            return View(noteUser);
        }

        // GET: NoteUsers/Create
        public ActionResult Create()
        {
            Models.NoteUser noteUser = new NoteUser();
            noteUser.RecDateTime = DateTime.Now;
            noteUser.UpdateDateTime = DateTime.Now;
            return View(noteUser);
        }

        // POST: NoteUsers/Create
        // 過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        // 詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 をご覧ください。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UserID,UserName,RecDateTime,UpdateDateTime,UserRole")] NoteUser noteUser)
        {
            if (ModelState.IsValid)
            {
                noteUser.RecDateTime = DateTime.Now;
                noteUser.UpdateDateTime = DateTime.Now;
                db.NoteUsers.Add(noteUser);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(noteUser);
        }

        // GET: NoteUsers/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "NoteUsers");
            }
            NoteUser noteUser = db.NoteUsers.FirstOrDefault(x => x.UserID == id);
            if (noteUser == null)
            {
                return RedirectToAction("Index", "NoteUsers");
            }
            return View(noteUser);
        }

        // POST: NoteUsers/Edit/5
        // 過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        // 詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 をご覧ください。
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserID,UserName,RecDateTime,UpdateDateTime,UserRole")] NoteUser noteUser)
        {
            if (ModelState.IsValid)
            {
                db.Entry(noteUser).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(noteUser);
        }

        // GET: NoteUsers/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NoteUser noteUser = db.NoteUsers.FirstOrDefault(x => x.UserID == id);
            if (noteUser == null)
            {
                return HttpNotFound();
            }
            return View(noteUser);
        }

        // POST: NoteUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            NoteUser noteUser = db.NoteUsers.FirstOrDefault(x => x.UserID == id);
            db.NoteUsers.Remove(noteUser);
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
