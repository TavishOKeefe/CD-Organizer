using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Organizer.Models;

namespace Organizer.Controllers
{
  public class CDController : Controller
  {
    [HttpGet("/CD/New")]
    public ActionResult New()
    {
      return View();
    }
  }
}
