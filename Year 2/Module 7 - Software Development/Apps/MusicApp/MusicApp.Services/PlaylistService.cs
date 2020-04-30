using Microsoft.EntityFrameworkCore;
using MusicApp.Data;
using MusicApp.Data.Models;
using MusicApp.Services.Contracts;
using MusicApp.ViewModels.Playlist;
using MusicApp.ViewModels.Song;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicApp.Services
{
    public class PlaylistService : IPlaylistService
    {
        private MusicAppDbContext context;
        public PlaylistService(MusicAppDbContext context)
        {
            this.context = context;
        }
        public int AddSongToPlaylist(int id)
        {
            var song = this.context.Songs.FirstOrDefault(s => s.Id == id);
            var playlist = this.context.Playlists.FirstOrDefault();

            if(playlist == null )
            {
                playlist = new Playlist();
                this.context.Playlists.Add(playlist);
                this.context.SaveChanges();
            }

            song.PlaylistId = playlist.Id;
            playlist.Songs.Add(song);
            this.context.SaveChanges();

            return playlist.Id;
        }
        public ShowPlaylistViewModel GetPlaylistWithSongs()
        {
            var playlist = this.context.Playlists.Include(p => p.Songs).FirstOrDefault();
            var songs = playlist.Songs.Select(s => new ShowSongViewModel()
            {
                Id = s.Id,
                Name = s.Name,
                Description = s.Description,
                Link = s.Link
            });

            var model = new ShowPlaylistViewModel()
            { Songs = songs };
            return model;
        }
    }
}
