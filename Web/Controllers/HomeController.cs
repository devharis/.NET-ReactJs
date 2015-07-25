using System.Collections.Generic;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private static readonly IList<Comment> _comments;

        static HomeController()
        {
            _comments = new List<Comment>
            {
                new Comment
                {
                    Author = "Daniel Lo Nigro",
                    Text = "Hello ReactJS.NET World!"
                },
                new Comment
                {
                    Author = "Pete Hunt",
                    Text = "This is one comment"
                },
                new Comment
                {
                    Author = "Jordan Walke",
                    Text = "This is *another* comment"
                },
            };
        }

        // GET: Home
        public ActionResult Index()
        {
            return View("Index", _comments);
        }

        public ActionResult List()
        {
            return View("List");
        }

        public ActionResult Comments()
        {
            return Json(_comments, JsonRequestBehavior.AllowGet);
        }

        public ActionResult AddComment(Comment comment)
        {
            if (ModelState.IsValid)
            {
                _comments.Add(comment);
                return Content("Success");
            }
            return Content("Error");
        }
    }
}