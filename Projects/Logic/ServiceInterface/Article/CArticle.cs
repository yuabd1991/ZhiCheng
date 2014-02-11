using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Logic.DataAccess;
using Logic.Services;

namespace Logic.ServiceInterface.Article
{
	public class CArticle :BehaviorExtend, IArticle
	{

		public List<Component.Entities.ArticleEntity> GetArticleList(Component.GetReportDataParams param, out int totalCount)
		{
			using (ArticleLogic logic = new ArticleLogic(_db))
			{
				return logic.GetArticleList(param, out totalCount);
			}
		}

		public Component.BaseObject InsertArticle(Component.Entities.ArticleEntity param)
		{
			using (ArticleLogic logic = new ArticleLogic(_db))
			{
				return logic.InsertArticle(param);
			}
		}

		public Component.Entities.ArticleEntity GetArticleByID(int id)
		{
			using (ArticleLogic logic = new ArticleLogic(_db))
			{
				return logic.GetArticleByID(id);
			}
		}

		public Component.BaseObject UpdateArticle(Component.Entities.ArticleEntity param)
		{
			using (ArticleLogic logic = new ArticleLogic(_db))
			{
				return logic.UpdateArticle(param);
			}
		}

		public Component.BaseObject DelArticle(int id)
		{
			using (ArticleLogic logic = new ArticleLogic(_db))
			{
				return logic.DelArticle(id);
			}
		}
	}
}
