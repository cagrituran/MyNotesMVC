using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MyNotes.BusinessLayer;
using MyNotes.DataAccessLayer;
using MyNotes.EntityLayer;

namespace MyNotes.MVC.Controllers
{
    public class CommentController : Controller
    {
        private MyNoteContext db = new MyNoteContext();
        private NoteManager nm = new NoteManager();
        private CommandManager cm = new CommandManager();

        // GET: Comment
        public ActionResult Index()
        {
            var comments = db.Comments.Include(c => c.Note).Include(c => c.Owner);
            return View(comments.ToList());
        }

        // GET: Comment/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Comment comment = db.Comments.Find(id);
            if (comment == null)
            {
                return HttpNotFound();
            }
            return View(comment);
        }

        // GET: Comment/Create
        public ActionResult Create()
        {
            ViewBag.NoteId = new SelectList(db.Notes, "Id", "Tittle");
            ViewBag.OwnerId = new SelectList(db.MyNotesUsers, "Id", "Name");
            return View();
        }

        // POST: Comment/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Text,NoteId,OwnerId,CreatedOn,ModifiedOn,ModifiedUserName")] Comment comment)
        {
            if (ModelState.IsValid)
            {
                db.Comments.Add(comment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.NoteId = new SelectList(db.Notes, "Id", "Tittle", comment.NoteId);
            ViewBag.OwnerId = new SelectList(db.MyNotesUsers, "Id", "Name", comment.OwnerId);
            return View(comment);
        }

        // GET: Comment/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Comment comment = db.Comments.Find(id);
            if (comment == null)
            {
                return HttpNotFound();
            }
            ViewBag.NoteId = new SelectList(db.Notes, "Id", "Tittle", comment.NoteId);
            ViewBag.OwnerId = new SelectList(db.MyNotesUsers, "Id", "Name", comment.OwnerId);
            return View(comment);
        }

        // POST: Comment/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Text,NoteId,OwnerId,CreatedOn,ModifiedOn,ModifiedUserName")] Comment comment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(comment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.NoteId = new SelectList(db.Notes, "Id", "Tittle", comment.NoteId);
            ViewBag.OwnerId = new SelectList(db.MyNotesUsers, "Id", "Name", comment.OwnerId);
            return View(comment);
        }

        // GET: Comment/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Comment comment = db.Comments.Find(id);
            if (comment == null)
            {
                return HttpNotFound();
            }
            return View(comment);
        }

        // POST: Comment/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Comment comment = db.Comments.Find(id);
            db.Comments.Remove(comment);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult ShowNoteComments(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Note note = nm.QList().Include("Comments").FirstOrDefault(s => s.Id == id);
            if (note == null)
            {
                return HttpNotFound();
            }
            return PartialView("_PartialComments", note.Comments);
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
