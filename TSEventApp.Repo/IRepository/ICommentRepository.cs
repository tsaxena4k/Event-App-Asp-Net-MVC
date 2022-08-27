using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSEventApp.Core.Entities;

namespace TSEventApp.Core.IRepository
{
    public interface ICommentRepository
    {
        Task<int> PostComment(Comment response);

        Task<IList<Comment>> GetComments();

        Task<Comment> ViewComment(int commentId);

        int EditComment(Comment response);


    }
}
