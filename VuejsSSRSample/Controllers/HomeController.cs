using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using VuejsSSRSample.Models;

namespace VuejsSSRSample.Controllers
{    public class HomeController : Controller
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

        public JsonResult FetchMessages(DateTime lastFetchedMessageDate)
        {
            return Json(FakeMessageStore.FakeMessages.OrderByDescending(m => m.Date).SkipWhile(m => m.Date >= lastFetchedMessageDate).Take(1));
        }
    }
}
