using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MediatR;
using TestWebDotNetFramework.Application.Events;

namespace TestWebDotNetFramework.Controllers
{
    public class HomeController : Controller
    {
        private IMediator _mediator;

        public HomeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public ActionResult Index()
        {
            var evnt = new TestEvent("This is the test data");

            _mediator.Publish(evnt);
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
    }
}