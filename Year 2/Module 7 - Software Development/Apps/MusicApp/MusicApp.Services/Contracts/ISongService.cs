using System;
using System.Collections.Generic;
using System.Text;
using MusicApp.ViewModels.Song;

namespace MusicApp.Services.Contracts
{
    public interface ISongService
    {
        int CreateSong(string name, string description, string link, string category);
        IndexSongViewModel IndexSong();
    }
}
