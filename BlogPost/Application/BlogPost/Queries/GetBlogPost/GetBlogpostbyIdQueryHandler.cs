using System;
using MediatR;
using System.Data;
using System.Data.Common;
using Dapper;
using System.Data.SqlClient;

namespace Application.BlogPost.Queries.GetBlogPost
{
    public sealed class GetBlogpostbyIdQueryHandler : IRequestHandler<GetBlogPostbyIdQuery, Domain.Entities.BlogPost>
    {       

        public async Task<Domain.Entities.BlogPost> Handle(GetBlogPostbyIdQuery request, CancellationToken cancellationToken)
        {
            string connectionString = "your_connection_string";
            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM BlogPost WHERE Id = @Id";
                var blogPost = connection.QueryFirstOrDefault<Domain.Entities.BlogPost>(sql, new { Id = request.Id });
                if (blogPost is null)
                {
                    throw new Exception("BlogPost not Found");
                }
                return blogPost;
            }
        }
    }
}
