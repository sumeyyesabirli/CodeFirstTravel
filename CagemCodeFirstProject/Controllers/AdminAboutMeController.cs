﻿using CagemCodeFirstProject.DAL.Context;
using CagemCodeFirstProject.DAL.Entities;
using System.Linq;
using System.Web.Mvc;

namespace CagemCodeFirstProject.Controllers
{
    
    public class AdminAboutMeController : Controller
    {
        TravelContext travelContext = new TravelContext();
        public ActionResult Index()
        {
            var values = travelContext.AboutMes.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AdminAboutMeUpdate(int id)
        {
            var value = travelContext.AboutMes.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult AdminAboutMeUpdate(AboutMe p)
        {
            var value = travelContext.AboutMes.Find(p.AboutMeId);
            value.Title1 = p.Title1;
            value.Title2 = p.Title2;
            value.Description1 = p.Description1;
            value.Description2 = p.Description2;
            value.ImageUrl1 = p.ImageUrl1;
            value.ImageUrl2 = p.ImageUrl2;
            travelContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}