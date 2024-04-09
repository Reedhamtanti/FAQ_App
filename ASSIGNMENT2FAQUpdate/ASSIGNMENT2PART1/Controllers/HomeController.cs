using ASSIGNMENT2PART1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASSIGNMENT2PART1.Controllers
{
    public class HomeController : Controller
    {
        private string all = "all";
        private DBContext context;

        [Route("")]
        [Route("topic/{activeDivision}")]
        [Route("category/{activeConfiguration}")]
        [Route("category/{activeConfiguration}/{activeDivision}")]
        [Route("topic/{activeDivision}/category/{activeConfiguration}")]
        public IActionResult Index(ListModel model)
        {
            SetSession(model);

            IQueryable<FAQs> query = context.FAQs;

            if (model.ActiveDivision != all)
                query = query.Where(t => t.Topic.Url.ToLower() == model.ActiveDivision.ToLower());

            if (model.ActiveConfiguration != all)
                query = query.Where(t => t.Category.Url.ToLower() == model.ActiveConfiguration.ToLower());

            model.Categories = context.Categories.ToList();
            model.Topics = context.Topics.ToList();
            model.FAQs = query.ToList();

            return View(model);
        }

        public HomeController(DBContext contextfaq)
        {
            context = contextfaq;
        }

        private void SetSession(ListModel model)
        {
            var session = new Session(HttpContext.Session);
            session.SetActiveConfiguration(model.ActiveConfiguration);
            session.SetActiveDivision(model.ActiveDivision);
        }
    }
}
