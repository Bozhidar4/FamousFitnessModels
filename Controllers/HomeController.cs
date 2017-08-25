using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FamousFitnessModels.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Most Famous Male Fitness Models.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //[HttpPost]
        //public ActionResult Edit([Bind(Include =
        //    "id, Name, Description, Nationality, Current_Team, Matches_Played, Highest_Score,Likes, Dislikes, Picture, User")]
        //    Player player)
        //{
        //    if (player.Picture == null)
        //    {
        //        player.Picture = "http://tinyurl.com/z6bu9a9";
        //    }
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(player).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(player);
        //}
    }
}