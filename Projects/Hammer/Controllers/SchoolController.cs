using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EasyUI.Models;
using Entity.Entities;

namespace EasyUI.Controllers
{
    public class SchoolController : Controller
    {
        //
        // GET: /School/

        public ActionResult Index()
        {
			ViewBag.School = new Helpers.SystemHelper().GetDocumentByID(2);
			ViewBag.Dom = new Helpers.SystemHelper().GetDocumentByID(10);
			ViewBag.Our = new Helpers.SystemHelper().GetDocumentByID(11);
			ViewBag.About = "current";

            return View();
        }

		public ActionResult News(int? page)
		{
			ViewBag.Column = new Helpers.SystemHelper().GetColumnById(2);

			var result = new Helpers.SystemHelper().GetArticleImageList(2);
			//var result = new Helpers.SystemHelper().GetArticleImageList(id);
			ViewBag.SchoolNews = "current";
			var model = new SitePaginated<ArticleImageEntity>(result, page ?? 1, 9);

			return View(model);
		}


    }
}
