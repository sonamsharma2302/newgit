using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppGitExercise.Models;

namespace WebAppGitExercise.Controllers
{
    public class PlayerController : Controller
    {
        // GET: Player
        public ActionResult Index()
        {
            List<Player> playerlist = new List<Player>
            { 
                new Player{PId=1,PName="Rohit sharma",Pteam="Mumbai Indians"},
                new Player{PId=2,PName="MSD",Pteam="CSK"},
                new Player{PId=3,PName="Virat Kohli",Pteam="RCB"},
                new Player{PId=4,PName="Ishan sharma",Pteam="Mumbai Indians"}
            };
            return View(playerlist);
        }
    }
}