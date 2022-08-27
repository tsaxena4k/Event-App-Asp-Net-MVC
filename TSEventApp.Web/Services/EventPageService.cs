using AutoMapper;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TSEventApp.Application.Interfaces;
using TSEventApp.Application.Models;
using TSEventApp.Web.Interfaces;
using TSEventApp.Web.Models;

namespace TSEventApp.Web.Services
{
    public class EventPageService: IEventPageService
    {
        private readonly IEventService _eventService;
        private readonly IMapper _mapper;
        private readonly ILogger<EventPageService> _logger;
        public EventPageService(IEventService eventService, IMapper mapper, ILogger<EventPageService> logger)
        {
            this._eventService = eventService ?? throw new ArgumentNullException(nameof(eventService));
            this._mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            this._logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<IList<EventViewModel>> GetEvents()
        {
            var list = await _eventService.GetEvents();
            var mapped = _mapper.Map<List<EventViewModel>>(list);
            return mapped;
        }
        public async Task<EventViewModel> ViewDetails(int eventId)
        {
            var _event = await _eventService.ViewDetails(eventId);
            var mapped = _mapper.Map<EventViewModel>(_event);
            return mapped;
        }

        public async Task<int> CreateEvent(EventViewModel eventViewModel,string orgainser)
        {
            // mapping from viewmodel to application model
            var mapped = _mapper.Map<EventModel>(eventViewModel);
            if (mapped == null)
                throw new Exception($"Entity could not be mapped.");
            ///calling application layer using mapped
            //outputting result in the same return type
            return await _eventService.CreateEvent(mapped,orgainser);

            //var result = _mapper.Map<EventViewModel>(entityDto);
            //return result;
        }

        public int UpdateEvent(EventViewModel eventViewModel)
        {
            var mapped = _mapper.Map<EventModel>(eventViewModel);
            if (mapped == null)
                throw new Exception($"Entity could not be mapped.");

            return _eventService.UpdateEvent(mapped);
        }

        public async Task<IList<EventViewModel>> MyEvents(string organiser)
        {
            var eventList = await _eventService.MyEvents(organiser);
            var mapped = _mapper.Map<IList<EventViewModel>>(eventList);
            return mapped;

        }

        public async Task<IList<CommentViewModel>> GetAllCommentByEventId(int eventId)
        {
            var commentList = await _eventService.GetAllCommentByEventId(eventId);
            var mapped = _mapper.Map<IList<CommentViewModel>>(commentList);
            return mapped;
        }
    }
}
