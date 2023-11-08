using Domain.Entities;

namespace Domain.Abstractions
{
    internal interface ICommentBlogRepository
    {
        Guid Insert(BlogComment blogComment);
    }
}
