using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using model_first.Models;

namespace model_first.Controllers
{
    public class PersonelController : Controller
    {
        // GET: Personel
        Model1Container db=new Model1Container();
        public ActionResult Index()
        {
            var result= db.PersonelSet.ToList();
            return View(result);
        }
    }
}