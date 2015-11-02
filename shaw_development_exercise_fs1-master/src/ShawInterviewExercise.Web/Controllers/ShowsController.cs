using ShawInterviewExercise.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShawInterviewExercise.Web.Controllers
{

    public class ShowsController : Controller
    {
        //
        // GET: /Shows/
        
        
        public ActionResult Index()
        {
            
            Show ss = new Show(1,"Rookie Blue","Could be the best of all time!!!");
            List<Show> lstShow = new List<Show>();
            showslst.FinalList(lstShow,ss);
            return View(showslst.lstshowlistshow);
        }
        [HttpGet]
        public ActionResult Create()
        {
            //TODO: Change this to look up show from API
            return View();
        }
        [HttpPost]
        public ActionResult Create(Show showCreate)
        {

           
            int count = showslst.lstshowlistshow.Count;
            showslst.FinalList(showslst.lstshowlistshow, showCreate);
            showslst.lstshowlistshow.Add(showCreate);
            return Redirect("Index");
            
        }


    }

    public static class showslst
    {
        
        public static List<Show> lstshowlistshow { get; set; }
        

        public static List<Show> FinalList(List<Show> lsShow, Show ss)
        {
            lsShow.Add(ss);
            lstshowlistshow = lsShow;
            return lsShow;
        }

    }

}
