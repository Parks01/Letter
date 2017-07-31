using Microsoft.AspNetCore.Mvc;

namespace FriendLetter.Controllers
{
    public class HomeController : Controller
    {
      [Route("/Index")]
      public string Index() { return "This is the Index action method!"; }
      [Route("/Hi")]
      public string Hi() { return "Hello Dude"; }
      [Route("/Goodbye")]
      public string Goodbye() { return "Goodbye friend!"; }
    }
}
