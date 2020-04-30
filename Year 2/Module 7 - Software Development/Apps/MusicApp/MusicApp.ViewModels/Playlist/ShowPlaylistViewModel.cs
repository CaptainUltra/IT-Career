using MusicApp.ViewModels.Song;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicApp.ViewModels.Playlist
{
    public class ShowPlaylistViewModel
    {
        public IEnumerable<ShowSongViewModel> Songs { get; set; }
    }
}
