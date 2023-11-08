using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public sealed class BlogPostController : ApiController
    {
        [Microsoft.AspNetCore.Mvc.HttpPost]
        [ProducesResponseType(typeof(Guid), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        
        public async Task<IActionResult> CreateBlogPost(Guid request, CancellationToken cancellationToken)
        {

            return null;
        }

        [Microsoft.AspNetCore.Mvc.HttpGet("{blogPostId:guid}")]
        [ProducesResponseType(typeof(string),StatusCodes.Status200OK)]

        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<string> GetBlogPost(Guid blogPostId, CancellationToken cancellationToken)
        {

           return "";

        }
    }
}
