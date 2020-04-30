using System;
using System.Collections.Generic;
using System.Text;

namespace MusicApp.ViewModels.Song
{
    public class ShowSongViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public string CategoryName { get; set; }
    }
}
