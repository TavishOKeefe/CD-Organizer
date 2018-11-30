using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Organizer.Models;

namespace Organizer.Controllers
{
  public class CDController : Controller
  {
    [HttpGet("/CD")]
    public ActionResult Index()
    {
      return View();
    }
    [HttpGet("/CD/New")]
    public ActionResult New()
    {
      return View();
    }
    [HttpPost("/CD")]
    public ActionResult Create(string title)
    {
      CD myCD = new Cd(title);
      L

    }
  }
}
