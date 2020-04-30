using System;
using System.Collections.Generic;
using System.Text;

namespace MusicApp.ViewModels.Song
{
    public class IndexSongViewModel
    {
        public IEnumerable<ShowSongViewModel> Songs { get; set; }
    }
}
