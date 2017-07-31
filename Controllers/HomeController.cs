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

      [Produces("text/html")]
      [Route("/")]
      public string Letter()
      {
        return
        "<!DOCTYPE html>" +
        "<html>" +
        "<head>" +
          "<title>Hello Friend!</title>" +
          "<link rel='stylesheet' href='https://maxcdn.bootstrapcdn.com/bootstrap/3.2.0/css/bootstrap.min.css'>" +
        "</head>" +
        "<body>" +
          "<h1>Hello From Afar</h1>" +
          "<p>Dear Friend,</p>" +
          "<p>How are you? I hope that you are having a nice weekend. I'm learning programming while in Iceland! </p>" +
          "<p>Friend, you would not believe how cold it is here. I should have gone to Hawaii instead.</p>" +
          "<p>But I like programming a lot, so I've got that going for me. </p>" +
          "<p>Looking forward to seeing you soon. I'll bring you back a souvenir. </p>" +
          "<p>Cheers,</p>" +
          "<p>Travel Enthusiast Jane</p>" +
          "<li><img src='/img/white-fox.jpg'/></li>" +
          "<li><img src='/img/fox-pic.jpg'/></li>" +
        "</body>" +
        "</html>" ;


      }
      [Produces("text/html")]
      [Route("/favorite_photos")]
      public string FavoritePhotos()
      {
      return
        "<!DOCTYPE html>" +
        "<html>" +
          "<head>" +
            "<title>Hello Friend!</title>" +
            "<link rel='stylesheet' href='https://maxcdn.bootstrapcdn.com/bootstrap/3.2.0/css/bootstrap.min.css'>" +
          "</head>" +
          "<body>" +
            "<h1>Favorite Traveling Photos</h1>" +
            "<ul>" +
              "<li><img src='/img/white-fox.jpg'/></li>" +
              "<li><img src='/img/fox-pic.jpg'/></li>" +
            "</ul>" +
          "</body>" +
        "</html>";
    }
    }
}
