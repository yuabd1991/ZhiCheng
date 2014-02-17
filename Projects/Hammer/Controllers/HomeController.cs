using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Component;
using EasyUI.Models;
using Entity.Entities;

namespace EasyUI.Controllers
{
	public class HomeController : Controller
	{

		//
		// GET: /Home/

		//public ActionResult Test()
		//{
		//    var 
		//    return View();
		//}

		public ActionResult Index()
		{
			//var help = new Helpers.SystemHelper();
			ViewBag.Mfjq = new Helpers.SystemHelper().GetArticleImageList(8).Take(7);
			ViewBag.Bjys = new Helpers.SystemHelper().GetArticleImageList(9).Take(7);
			ViewBag.Xxsj = new Helpers.SystemHelper().GetArticleImageList(10).Take(7);
			//图片作品
			ViewBag.ZuoPin = new Helpers.SystemHelper().GetArticleImageList(18).Take(5);
			ViewBag.HuodongZhanShi = new Helpers.SystemHelper().GetArticleImageList(19).Take(8);
			ViewBag.XueSheng = new Helpers.SystemHelper().GetArticleImageList(7).Take(8);

			ViewBag.NewsFir = new Helpers.SystemHelper().GetArticleImageList(2).FirstOrDefault();
			ViewBag.News = new Helpers.SystemHelper().GetArticleImageList(2).Skip(1).Take(9);

			ViewBag.Zsjd = new Helpers.SystemHelper().GetHomeArticleList(11).Take(6);
			ViewBag.Xsgy = new Helpers.SystemHelper().GetHomeArticleList(12).Take(6);
			ViewBag.Zpxx = new Helpers.SystemHelper().GetHomeArticleList(13).Take(6);
			ViewBag.Qzxx = new Helpers.SystemHelper().GetHomeArticleList(14).Take(6);

			ViewBag.Links = new Helpers.SystemHelper().GetLinksForHome();
			ViewBag.System = new Helpers.SystemHelper().GetSystemConfig();

			ViewBag.Home = "current";
			return View();
		}

		public ActionResult Document(int id, int? current = 0)
		{
			var result = new Helpers.SystemHelper().GetDocumentByID(id);
			ViewBag.Current = current;
			return View(result);
		}

		public ActionResult NewsList(int id, int? page)
		{
			ViewBag.Column = new Helpers.SystemHelper().GetColumnById(id);

			var result = new Helpers.SystemHelper().GetArticleImageList(id);

			switch (id)
			{
				case 2: ViewBag.SchoolNews2 = "current"; break;
				case 3: ViewBag.SchoolNews3 = "current"; break;
				case 4: ViewBag.SchoolNews4 = "current"; break;
				case 5: ViewBag.SchoolNews5 = "current"; break;
				case 6: ViewBag.SchoolNews6 = "current"; break;
				case 7: ViewBag.SchoolNews7 = "current"; break;
				default: ViewBag.SchoolNews2 = "current"; break;
			}

			var model = new SitePaginated<ArticleImageEntity>(result, page ?? 1, 9);

			return View(model);
		}

		/// <summary>
		/// 1代表图文集 2代表文章
		/// </summary>
		/// <param name="id"></param>
		/// <param name="type"></param>
		/// <returns></returns>
		public ActionResult Detail(int id)
		{
			var detail = new Helpers.SystemHelper().GetArticleByID(id);
			ViewBag.Column = new Helpers.SystemHelper().GetColumnById((int)detail.ColumnID);

			return View(detail);
		}

		//public ActionResult Tuwen(int id, int? page)
		//{
		//    ViewBag.Column = new Helpers.SystemHelper().GetColumnById(id);

		//    var result = new Helpers.SystemHelper().GetArticleImageList(id);
		//    //var result = new Helpers.SystemHelper().GetArticleImageList(id);
		//    ViewBag.Current = id;
		//    var model = new SitePaginated<ArticleImageEntity>(result, page ?? 1, 9);

		//    return View(model);
		//}

		public ActionResult TDetail(int id)
		{
			var tuwen = new Helpers.SystemHelper().GetArticleImageByID(id);
			ViewBag.Column = new Helpers.SystemHelper().GetColumnById((int)tuwen.ColumnID);

			return View(tuwen);
		}

		public ActionResult MenuHelper()
		{
			ViewBag.Menu = new Helpers.SystemHelper().GetMenuHelper();

			return View();
		}

		public ActionResult SiteNews()
		{
			//var news = new Helpers.SystemHelper().GetHomeArticleList(17).Take(8);
			//ViewBag.SchoolNews = news;

			int tCount = 0;
			GetReportDataParams param = new GetReportDataParams();
			List<KeyValue> where = new List<KeyValue>();
			where.Add(new KeyValue { Key = "ColumnID", Value = "13" });

			param.PageIndex = 1;
			param.PageSize = 8;
			param.Order = Request["sort"] == null ? "" : Request["sort"] + " " + Request["order"];
			param.Where = where;

			ViewBag.Classes = new Helpers.SystemHelper().GetArticleImageList(param, out tCount).Take(8);

			return PartialView();
		}
	}
}
