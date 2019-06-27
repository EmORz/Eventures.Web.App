using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eventures.Data;
using Eventures.Domain;
using Eventures.Models.BindingModels;
using Eventures.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Eventures.Controllers
{
    public class EventsController : Controller
    {
        private readonly EventuresDbContext _context;

        public EventsController(EventuresDbContext context)
        {
            _context = context;
        }

        public IActionResult Create()
        {
            return this.View();
        }
        [HttpPost]
        public IActionResult Create(EventCreateBindingModel bindingModel)
        {
            if (this.ModelState.IsValid)
            {
                Event eventForDb = new Event()
                {
                    Name = bindingModel.Name,
                    End = bindingModel.End,
                    Start = bindingModel.Start,
                    Place = bindingModel.Place,
                    PricePerTicket = bindingModel.PricePerTicket,
                    TotalTckets = bindingModel.TotalTickets
                };
                _context.Events.Add(eventForDb);
                _context.SaveChanges();

                return this.Redirect("All");
            }
            return this.View();
        }


        public IActionResult All()
        {
            List<EventAllViewModel> events = _context.Events
                .Select(eventFromDb => new EventAllViewModel
                {
                    Name = eventFromDb.Name,
                    End = eventFromDb.End.ToString(),
                    Start = eventFromDb.Start.ToString(),
                    Place = eventFromDb.Place

                }).ToList();
            return View(events);
        }
    }
}