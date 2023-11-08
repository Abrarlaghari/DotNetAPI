using Domain.Abstractions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Application.BlogPost.Commands.CreateBlogPost;

internal sealed class CreateBlogPostCommandHandler : IRequestHandler<CreateBlogPostCommand, Guid>
{
    private readonly IBlogPostRepository _blogPostRepository;

    public CreateBlogPostCommandHandler(IBlogPostRepository blogPostRepository)
    {
        _blogPostRepository = blogPostRepository;

    }
    public Task<Guid> Handle(CreateBlogPostCommand request, CancellationToken cancellationToken)
    {
       var blogPost=_blogPostRepository.Insert(new Domain.Entities.BlogPost(Guid.NewGuid(),request.BlogTitle,request.Author, request.Content));
       return Task.FromResult(blogPost);

    }
}

