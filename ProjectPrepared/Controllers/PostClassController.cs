using ProjectPrepared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectPrepared.Controllers
{
    public class PostClassController : Controller
    {
        // GET: PostClass
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetPost()
        {
            PostClass p = new PostClass();
            List<PostClass> Li = new List<PostClass>();

            Li = p.GetPost();
            ViewData["PostClass"] = Li;
            return View();
        }
    }
}