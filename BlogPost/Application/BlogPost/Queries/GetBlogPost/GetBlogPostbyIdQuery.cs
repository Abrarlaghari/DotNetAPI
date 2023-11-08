using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BlogPost.Queries.GetBlogPost;

public sealed record GetBlogPostbyIdQuery(Guid Id) : IRequest<Domain.Entities.BlogPost>;


