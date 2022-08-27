using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TSEventApp.Web.Models;

namespace TSEventApp.Web.Interfaces
{
    public interface IEventPageService
    {
        Task<IList<EventViewModel>> GetEvents();
        Task<EventViewModel> ViewDetails(int eventId);
        Task<int> CreateEvent(EventViewModel eventViewModel,string organiser);

        int UpdateEvent(EventViewModel eventViewModel);

        Task<IList<EventViewModel>> MyEvents(string organiser);
        Task<IList<CommentViewModel>> GetAllCommentByEventId(int eventId);
    }
}
