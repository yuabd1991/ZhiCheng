using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EasyUI.Controllers
{
    public class ContactController : Controller
    {
        //
        // GET: /Contact/

        public ActionResult Index()
        {
			ViewBag.Con = new Helpers.SystemHelper().GetDocumentByID(3);
			ViewBag.Bus = new Helpers.SystemHelper().GetDocumentByID(12);
			ViewBag.ZhaoPin = new Helpers.SystemHelper().GetDocumentByID(13);
			ViewBag.Contact = "current";
            return View();
        }

    }
}
