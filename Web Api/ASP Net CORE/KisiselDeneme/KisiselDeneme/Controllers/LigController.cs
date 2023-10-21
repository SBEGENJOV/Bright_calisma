using Microsoft.AspNetCore.Mvc;
using Data_Access_Layer.Abstract;
using Data_Access_Layer.Concreate;
using Data_Access_Layer.Repostory;
using System;
using System.Collections.Generic;
using EntityLayer.Models;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace KisiselDeneme.Controllers
{
    public class LigController : Controller
    {
        public readonly Context context;

        public LigController(Context context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View(context.Lig1s.ToList());
        }
    }
}
