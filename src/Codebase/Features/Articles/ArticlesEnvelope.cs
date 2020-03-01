using System.Collections.Generic;
using Codebase.Domain;

namespace Codebase.Features.Articles
{
    public class ArticlesEnvelope
    {
        public List<Article> Articles { get; set; }

        public int ArticlesCount { get; set; }
    }
}