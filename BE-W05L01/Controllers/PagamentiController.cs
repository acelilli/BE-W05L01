using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BE_W05L01.Controllers
{
    public class PagamentiController : Controller
    {
        // GET: Pagamenti
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Create()
        {
            return View();
        }
    }
}