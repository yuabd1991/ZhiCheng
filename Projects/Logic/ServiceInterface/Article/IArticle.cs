using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Component.Entities;
using Component;

namespace Logic.ServiceInterface
{
	public interface IArticle
	{
		List<ArticleEntity> GetArticleList(GetReportDataParams param, out int totalCount);

		BaseObject InsertArticle(ArticleEntity param);

		ArticleEntity GetArticleByID(int id);

		BaseObject UpdateArticle(ArticleEntity param);

		BaseObject DelArticle(int id);
	}
}
