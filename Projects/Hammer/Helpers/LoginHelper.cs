﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Component;
using Logic.Services;
using Component.Component;

namespace EasyUI.Helpers
{
	public class LoginHelper
	{
		public LoginHelper()
		{
		}
		//登录
		public BaseObject Login(string userName, string clearPassword, bool rememberMe)
		{
			using (UserLogic logic = new UserLogic())
			{
				return logic.Login(userName, clearPassword, rememberMe);
			}
		}

		public static string _userName;
		public static string UserName
		{
			get
			{
				if (string.IsNullOrEmpty(_userName))
				{
					return HttpContext.Current.Session["UserName"].UString();
				}

				return _userName;
			}
		}
	}
}