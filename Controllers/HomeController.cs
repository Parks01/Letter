using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
    public class HomeController : Controller
    {
      [Route("/Index")]
      public string Index() { return "This is the Index action method!"; }
      [Route("/Hi")]
      public string Hi() { return "Hello Dude"; }

      public string Goodbye() { return "Goodbye friend!"; }
      [Route("/favorite_photos")]
      public ActionResult FavoritePhotos()
      {
        return View();
      }
      [Route("/hello")]
      public ActionResult Hello()
      {
        LetterVariable myLetterVariable = new LetterVariable();
        myLetterVariable.SetRecipient("Erin");
        myLetterVariable.SetSender("Mike");

        return View(myLetterVariable);
      }

      [Route("/form")]
      public ActionResult Form()
      {
        return View();
      }

      [Route("/greeting_card")]
      public ActionResult GreetingCard()
      {
          LetterVariable myLetterVariable = new LetterVariable();
          myLetterVariable.SetRecipient(Request.Query["recipient"]);
          myLetterVariable.SetSender(Request.Query["sender"]);
          return View("Hello", myLetterVariable);
      }
    }
}
