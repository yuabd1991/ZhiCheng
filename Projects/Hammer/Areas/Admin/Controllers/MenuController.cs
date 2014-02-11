using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Logic;
using Component;
using Entity.Entities;

namespace EasyUI.Areas.Admin.Controllers
{
	[Authorize]
	public class MenuController : BaseController
    {
        //
        // GET: /Admin/Menu/

        public ActionResult MenuList()
        {
			//var menus = logic.GetMenus();

			return View();
        }

		public ActionResult MenuJosn(string id)
		{
			var list = new Helpers.SystemHelper().GetMenus(id);

			return Json(list);
		}

		public ActionResult AddMenu()
		{
			return View();
		}

		public ActionResult AddMenuJson(MenuEntity menu)
		{
			menu.Enable = "Y";
			menu.SystemID = 1;
			var result = new Helpers.SystemHelper().InsertMenu(menu);

			return Json(result);
		}

		public ActionResult EditMenu(int id)
		{
			var menu = new Helpers.SystemHelper().GetMenuByID(id);

			return View(menu);
		}

		public ActionResult EditMenuJson(MenuEntity menu)
		{
			var result = new Helpers.SystemHelper().EditMenu(menu);

			return Json(result);
		}

		public ActionResult EditPage()
		{
			//var page = new Helpers.Helper().getpa
			return View();
		}

        public ActionResult DeleteMenu(int id, string state, string type)
        {
            var result = new Helpers.SystemHelper().DisEnableMenu(id, state, type);
            return Json(result);
        }
    }
}
