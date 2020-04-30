using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MusicApp.Services.Contracts;

namespace MusicApp.Controllers
{
    public class SongController : Controller
    {
        private ISongService service;
        public SongController(ISongService service)
        {
            this.service = service;
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(string name, string description, string link, string category)
        {
            this.service.CreateSong(name, description, link, category);

            return this.RedirectToAction("Index", "Home");
        }
    }
}
