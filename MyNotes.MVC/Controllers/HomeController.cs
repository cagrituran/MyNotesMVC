using MyNotes.BusinessLayer;
using MyNotes.BusinessLayer.Models;
using MyNotes.BusinessLayer.ValueObject;
using MyNotes.EntityLayer;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyNotes.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly MyNotesUserManager mum = new MyNotesUserManager();
        private BusinessLayerResult<MyNotesUser> res;
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                res = mum.LoginUser(model);
                if (res.Errors.Count > 0)
                {
                    if (res.Errors.Find(x => x.Code == EntityLayer.Messages.ErrorMessageCode.UserIsNotActive) != null)
                    {
                        ViewBag.SetLink = "http://Home/UserActivate/1234-2345-3456789";

                    }
                    res.Errors.ForEach(s => ModelState.AddModelError("", s.Message));
                    return View(model);
                }
                //Session["Login"] = res.Result
                CurrentSession.Set("Login", res.Result);
                return RedirectToAction("Index");

            }
            return View(model);

        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                MyNotesUserManager mum = new MyNotesUserManager();
                BusinessLayerResult<MyNotesUser> res = mum.RegisterUser(model);
                if (res.Errors.Count > 0)
                {
                    res.Errors.ForEach(s => ModelState.AddModelError("", s.Message));
                    return View(model);

                }
                return RedirectToAction("Login");
            }
            return View(model);
        }

        public ActionResult Index()
        {
            Test test = new Test();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult LogOut()
        {
            Session.Clear();
            CurrentSession.Clear();
            return RedirectToAction("Index");
        }
    }
}