using MusicApp.ViewModels.Playlist;
using System;
using System.Collections.Generic;
using System.Text;

namespace MusicApp.Services.Contracts
{
    public interface IPlaylistService
    {
        int AddSongToPlaylist(int id);
        ShowPlaylistViewModel GetPlaylistWithSongs();
    }
}
