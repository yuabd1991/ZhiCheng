using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Component.Entities;
using Component;

namespace Logic.ServiceInterface
{
	public interface IMenu
	{
		List<MenuEntity> GetAllMenus();

		List<MenuEntity> GetAllPages();

		BaseObject InsertMenu(MenuEntity menu);

		MenuEntity GetMenuByID(int id);

		BaseObject EditMenu(MenuEntity menu);

		BaseObject DelMenu(int id);

		List<MenuList> GetMenus(string ids);

		List<MenuTree> GetTreeMenu();
	}
}
