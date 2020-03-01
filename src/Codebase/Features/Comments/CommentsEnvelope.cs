using System.Collections.Generic;
using Codebase.Domain;

namespace Codebase.Features.Comments
{
    public class CommentsEnvelope
    {
        public CommentsEnvelope(List<Comment> comments)
        {
            Comments = comments;
        }

        public List<Comment> Comments { get; }
    }
}