using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TSEventApp.Web.Models;

namespace TSEventApp.Web.Interfaces
{
    public interface ICommentPageService
    {

        Task<int> PostComment(CommentViewModel response);

        Task<IList<CommentViewModel>> GetComments();

        Task<CommentViewModel> ViewComment(int commentId);

        int EditComment(CommentViewModel response);
    }
}
