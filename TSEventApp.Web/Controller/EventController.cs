using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TSEventApp.Web.Models;
using TSEventApp.Infrastructure.Repository;
using TSEventApp.Core.Entities;
using TSEventApp.Web.Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace TSWebApp.Controllers
{
    public class EventController : Controller
    {
        private readonly IEventPageService _eventPageService;
        public EventController(IEventPageService eventPageService)
        {
            this._eventPageService = eventPageService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> ViewDetails(int? id)
        {
            var details = await _eventPageService.ViewDetails(id.Value);
            var ans = await _eventPageService.GetAllCommentByEventId(id.Value);
            details.Comments = ans;
            if (details == null)
            {
                return RedirectToAction("GetEvents");
            }
            return View(details);
        }
        [Authorize]
        public ViewResult CreateEvent(bool isSuccess = false, int bookId = 0)
        {
            ViewBag.IsSuccess = isSuccess;
            ViewBag.BookId = bookId;
            return View();
        }
        [Authorize]
        [HttpPost]
        public async Task<ActionResult> CreateEvent(EventViewModel eventViewModel,string organiser)
        {
            //_eventRepository.CreateEvent(bookEventModel);
            if (ModelState.IsValid)
            {
                var result = await _eventPageService.CreateEvent(eventViewModel,organiser);
                if (result > 0)
                {
                    return RedirectToAction(nameof(CreateEvent), new { isSuccess = true, bookId = result });
                }
            }
            
            return View();
        }
        [Authorize]
        public async Task<IActionResult> UpdateEvent(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("GetEvents");
            }
            var ans = await _eventPageService.ViewDetails(id.Value); ;

            if (ans == null)
            {
                return RedirectToAction("GetEvents");
            }

            return View(ans);
        }

        [Authorize]
        [HttpPost]
        public IActionResult UpdateEvent(EventViewModel eventViewModel)
        {
            var _id = _eventPageService.UpdateEvent(eventViewModel);

            if (_id > 0)
            {
                return RedirectToAction("ViewDetails", new { id = _id });
            }
            return View();
        }

        [Authorize]
        public async Task<IActionResult> MyEvents()
        {
            var organiser = User.Identity.Name;
            var eventList = await _eventPageService.MyEvents(organiser);
            return View(eventList);
        }
        [Authorize]
        public async Task<IActionResult> EventsInvitedTo()
        {
            var eventList = await _eventPageService.GetEvents();
            return View(eventList);
        }

        public async Task<IActionResult> GetAllCommentByEventId(int _id)
        {
            var ans = await _eventPageService.GetAllCommentByEventId(_id);
            if (ans == null)
            {
                return RedirectToAction("ViewDetails", new { id = _id });
            }
            return View(ans);
        }
    }
}
