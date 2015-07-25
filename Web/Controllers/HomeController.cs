using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private static readonly IList<Comment> _comments;
        private static readonly IList<Viewer> _viewers;

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

            _viewers = new List<Viewer>
            {
                new Viewer
                {
                    Id = 1,
                    Name = "Haris",
                    Age = 24
                },
                new Viewer
                {
                    Id = 2,
                    Name = "Sharkoon1",
                    Age = 0
                },
                new Viewer
                {
                    Id = 3,
                    Name = "Shrader",
                    Age = 45
                },
                new Viewer
                {
                    Id = 4,
                    Name = "Jessie Pinkman",
                    Age = 23
                },
                new Viewer
                {
                    Id = 5,
                    Name = "Master_card",
                    Age = 41
                }
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

        public ActionResult Items(int page, int take)
        {

            var list = _viewers.Skip(page*take).Take(take);

            return Json(list, JsonRequestBehavior.AllowGet);
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