﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Application.BlogPost.Queries.GetBlogPost;
using MediatR;
using Domain.Entities;
using Application.BlogPost.Commands.CreateBlogPost;


namespace Presentation.Controllers
{
    public sealed class BlogPostController : ApiController
    {

        private readonly IMediator _mediator;

        public BlogPostController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Microsoft.AspNetCore.Mvc.HttpPost]
        [ProducesResponseType(typeof(Guid), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]


      
        public async Task<Guid> CreateBlogPost([Microsoft.AspNetCore.Mvc.FromBody] CreateBlogPostCommand command, CancellationToken cancellationToken)
        {
            var productId = await _mediator.Send(command);
            return productId;

        }

        [Microsoft.AspNetCore.Mvc.HttpGet("{blogPostId:guid}")]
        [ProducesResponseType(typeof(string),StatusCodes.Status200OK)]

        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<Domain.Entities.BlogPost> GetBlogPost(Guid request, CancellationToken cancellationToken)
        {
       
            var query = new GetBlogPostbyIdQuery(request);
            var blogpost=await _mediator.Send(query,cancellationToken);
            return blogpost;

        }
    }
}
