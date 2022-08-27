using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TSEventApp.Core.Entities;
using TSEventApp.Core.IRepository.Base;

namespace TSEventApp.Core.IRepository
{
    public interface IEventRepository :IRepository<Event>
    {
        Task<IList<Event>> GetEvents();
        Task<Event> ViewDetails(int eventId);

        Task<int> CreateEvent(Event eventViewModel,string organiser);

        int UpdateEvent(Event eventViewModel);

        Task<IList<Event>> MyEvents(string organiser);
        Task<IList<Comment>> GetAllCommentByEventId(int eventId);
    }
}
