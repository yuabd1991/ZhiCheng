using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Logic.DataAccess;
using Component.Entities;
using Component;
using Logic.Services;

namespace Logic.ServiceInterface
{
	public class CMenu :BehaviorExtend, IMenu
	{
		public List<MenuEntity> GetAllMenus()
		{
			using (MenuLogic logic = new MenuLogic(_db))
			{
				return logic.GetAllMenus();
			}
		}

		public List<MenuEntity> GetAllPages()
		{
			using (MenuLogic logic = new MenuLogic(_db))
			{
				return logic.GetAllPages();
			}
		}

		public BaseObject InsertMenu(MenuEntity menu)
		{
			using (MenuLogic logic = new MenuLogic(_db))
			{
				return logic.InsertMenu(menu);
			}
		}

		public MenuEntity GetMenuByID(int id)
		{
			using (MenuLogic logic = new MenuLogic(_db))
			{
				return logic.GetMenuByID(id);
			}
		}

		public BaseObject EditMenu(MenuEntity menu)
		{
			using (MenuLogic logic = new MenuLogic(_db))
			{
				return logic.EditMenu(menu);
			}
		}

		public BaseObject DelMenu(int id)
		{
			using (MenuLogic logic = new MenuLogic(_db))
			{
				return logic.DelMenu(id);
			}
		}
		
		public List<MenuList> GetMenus(string ids)
		{
			using (Logic.Services.MenuLogic logic = new Services.MenuLogic(_db))
			{
				return logic.GetMenus(ids);
			}
		}

		public List<MenuTree> GetTreeMenu()
		{
			using (MenuLogic logic = new MenuLogic(_db))
			{
				return logic.GetTreeMenu();
			}
		}
	}
}
