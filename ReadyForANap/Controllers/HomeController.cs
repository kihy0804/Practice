using ReadyForANap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ReadyForANap.Controllers
{
    public class HomeController : Controller
    {
        public static List<Team> listTeam = new List<Team>();
        // GET: Home
        public ActionResult Index()
        {
            //Scaffolding --> Work on building something, make things more flexible
            return View();
        }
        [HttpPost]
        public ActionResult Index(Team myTeam)
        {
            //Making IDs using the data the user enters for TeamDescription
            myTeam.TeamID = myTeam.TeamDescription.Substring(0, 2) + " NUM# " + listTeam.Count().ToString();
            //Add the data to the object
            listTeam.Add(myTeam);

            return View();
        }
    }
}