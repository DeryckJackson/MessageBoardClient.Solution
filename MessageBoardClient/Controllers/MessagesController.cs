using Microsoft.AspNetCore.Mvc;
using MessageBoardClient.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MessageBoardClient.Controllers
{
  public class MessagesController : Controller
  {
    [HttpGet]
    public ActionResult Index()
    {
      var allMessages = Message.GetMessages();
      return View(allMessages);
    }

    [HttpGet("/details/{id}")]
    public ActionResult Details(int id)
    {
      var thisMessage = Message.GetDetails(id);
      return View(thisMessage);
    }
  }
}