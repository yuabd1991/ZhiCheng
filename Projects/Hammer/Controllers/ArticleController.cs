using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EasyUI.Helpers;

namespace EasyUI.Controllers
{
    public class ArticleController : Controller
    {
        //
        // GET: /Article/

		public ActionResult Detail(int id)
        {
			var result = new SystemHelper().GetArticleByID(id);
			ViewBag.Column = new Helpers.SystemHelper().GetColumnById((int)result.ColumnID);

			return View(result);
        }

    }
}
