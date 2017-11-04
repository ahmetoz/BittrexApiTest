
using System.Web.Mvc;
using TweetSharp;

namespace BittrexApiTest.Controllers
{
    public class TwitterController : Controller
    {
        public ActionResult Details(string screenName = null)
        {
            var service = new TwitterService("Zj0yu6upDzp8QzA7izDbL9SnY", "kKHWJFvijKWLLlZ7fRtMxJPveitObvgS29Gxcb8tcxuTSxmDFv");
            service.AuthenticateWith("905477271301091328-HVASfq6qjxvPULrFyVaSjIv8BHONF5v", "Y0PX4lDj7TOYjwsUGreXMRlwRS4hhNWaC4Pmtp61k7nJJ");

            var model = service.ListTweetsOnUserTimeline(new ListTweetsOnUserTimelineOptions()
            {
                ScreenName = screenName
            });

            return View(model);
        }
    }
}
