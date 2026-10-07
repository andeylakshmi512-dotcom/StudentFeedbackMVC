using StudentFeedbackMVC.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace StudentFeedbackMVC.Controllers
{
    public class FeedbackController : Controller
    {
        static List<Feedback> feedbackList = new List<Feedback>();

        // GET: Feedback
        public ActionResult Index()
        {
            return View();
        }

        // GET: Feedback/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Feedback/Create
        [HttpPost]
        public ActionResult Create(Feedback feedback)
        {
            feedbackList.Add(feedback);

            return RedirectToAction("List");
        }

        // GET: Feedback/List
        public ActionResult List()
        {
            return View(feedbackList);
        }
    }
}