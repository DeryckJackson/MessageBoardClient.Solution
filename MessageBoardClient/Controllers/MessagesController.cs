using System.Collections.Generic;

namespace MessageBoardClient.Controllers
{
  public class MessagesController : Controller
  {
    public ActionResult Index()
    {
      var allMessages = message.GetMessages();
      return View(allMessages);
    }

    [HttpGet("/details/{id}")]
    public ActionResult Details(int id)
    {
      var thisMessage = message.GetDetails(id);
      return View(thisMessage);
    }
  }
}