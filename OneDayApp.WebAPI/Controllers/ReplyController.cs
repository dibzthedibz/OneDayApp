using Microsoft.AspNet.Identity;
using OneDay.Models;
using OneDay.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OneDayApp.WebAPI.Controllers
{
    public class ReplyController : ApiController
    {
        [Authorize]
        private ReplyService CreateReplyService()
        {
            var authorId = Guid.Parse(User.Identity.GetUserId());
            var replyService = new ReplyService(authorId);
            return replyService;
        }

        public IHttpActionResult Get()
        {
            ReplyService replyService = CreateReplyService();
            var replies = replyService.GetReplies();
            return Ok(replies);
        }

        public IHttpActionResult Post(CreateReply reply)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var service = CreateReplyService();

            if (!service.CreateReply(reply))
            {
                return InternalServerError();
            }

            return Ok();
        }
    }
}
