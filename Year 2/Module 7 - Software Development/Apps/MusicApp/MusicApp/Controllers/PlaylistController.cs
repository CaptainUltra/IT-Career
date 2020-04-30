using Microsoft.AspNetCore.Mvc;
using MusicApp.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicApp.Controllers
{
    public class PlaylistController : Controller
    {
        private IPlaylistService service;
        public PlaylistController(IPlaylistService service)
        {
            this.service = service;
        }

        public IActionResult Index()
        {
            var model = service.GetPlaylistWithSongs();
            return this.View(model);
        }
        public IActionResult AddSongToPlaylist(int id)
        {
            this.service.AddSongToPlaylist(id);

            return this.RedirectToAction("Index", "Playlist");
        }
    }
}
