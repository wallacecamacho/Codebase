using System.Linq;
using Codebase.Domain;
using Microsoft.EntityFrameworkCore;

namespace Codebase.Features.Articles
{
    public static class ArticleExtensions
    {
        public static IQueryable<Article> GetAllData(this DbSet<Article> articles)
        {
            return articles
                .Include(x => x.Author)
                .Include(x => x.ArticleFavorites)
                .Include(x => x.ArticleTags)
                .AsNoTracking();
        }
    }
}