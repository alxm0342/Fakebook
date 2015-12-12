using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Fakebook.Entities;
using Fakebook.Models;

namespace Fakebook.Controllers
{
    public class HomeController : Controller
    {
        private FakebookEntities db = new FakebookEntities();

        public ActionResult Index()
        {
            HomeViewModel viewModel = new HomeViewModel();
            Person owner = db.Persons.SingleOrDefault(p => p.Username == "The Guest");
            viewModel.commentList = db.Comments.ToList();
            viewModel.ownerImage = (owner != null ? owner.Image : "fb_default.png");
            return View(viewModel);
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
    }
}