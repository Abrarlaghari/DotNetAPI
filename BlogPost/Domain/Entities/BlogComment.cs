using Domain.Premitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    internal sealed class BlogComment : Entity
    {
        public BlogComment(Guid id, Guid postId, string content) {
            PostId = postId;
            Content = content;
            
        }

        public Guid PostId { get; private set;}

        public string Content { get; private set;}
    }
}
