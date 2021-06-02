using OneDay.Data;
using OneDay.Models;
using OneDayApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneDay.Services
{
    public class ReplyService
    {
        private readonly Guid _authorId;

        public ReplyService(Guid replyId)
        {
            _authorId = replyId;
        }

        public bool CreateReply(CreateReply model)
        {
            var entity =
                new Reply()
                {                 
                    Text = model.Text,                    
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Replies.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<ReplyListItem> GetReplies()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .Replies
                        .Where(e => e.AuthorId == _authorId)
                        .Select(
                            e =>
                                new ReplyListItem
                                {
                                    ReplyId = e.ReplyId,
                                    Text = e.Text,                                 
                                }
                         );
                return query.ToArray();
            }
        }
    }
}
