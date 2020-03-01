using Codebase.Domain;

namespace Codebase.Features.Comments
{
    public class CommentEnvelope
    {
        public CommentEnvelope(Comment comment)
        {
            Comment = comment;
        }

        public Comment Comment { get; }
    }
}