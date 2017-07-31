using Microsoft.AspNetCore.Mvc;

namespace FriendLetter.Controllers
{
    public class HomeController : Controller
    {
      [Route("/Index")]
      public string Index() { return "This is the Index action method!"; }
      [Route("/Hi")]
      public string Hi() { return "Hello Dude"; }

      public string Goodbye() { return "Goodbye friend!"; }

      [Route("/hello")]
      public ActionResult Hello()
      {
        return View();
      }

      [Route("/favorite_photos")]
        public ActionResult FavoritePhotos()
        {
          return View();
        }
    }
}
