using Domain.Premitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public sealed class BlogPost : Entity
    {
        public BlogPost(Guid id, string blogTitle,string author, string content)
        {
            BlogTitle=blogTitle;
            Author=author;
            Content=content; 


        }

        public string BlogTitle { get; private set; }
        public string Author { get; private set; }

        public string Content { get; private set; }
    }
}
