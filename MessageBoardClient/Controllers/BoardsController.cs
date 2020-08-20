using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MessageBoardClient.Models;

namespace MessageBoardClient.Controllers
{
  public class BoardsController : Controller
  {
    public IActionResult Index()
    {
      var allMessages = Message.GetMessages();
      return View(allMessages);
    }
  }
}