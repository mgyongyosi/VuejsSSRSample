using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using VuejsSSRSample.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace VuejsSSRSample.Controllers
{
    [Route("/Home")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var initialMessages = FakeMessageStore.FakeMessages.OrderByDescending(m => m.Date).Take(2);

            var initialValues = new ClientState() {
                Messages = initialMessages,
                LastFetchedMessageDate = initialMessages.Last().Date
            };

            return View(initialValues);
        }

        [Route("fetchMessages")]
        public JsonResult FetchMessages(DateTime lastFetchedMessageDate)
        {
            return Json(FakeMessageStore.FakeMessages.OrderByDescending(m => m.Date).SkipWhile(m => m.Date >= lastFetchedMessageDate).Take(1));
        }
    }
}
