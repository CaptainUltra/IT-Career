using MusicApp.Data;
using MusicApp.Data.Models;
using MusicApp.Services.Contracts;
using MusicApp.ViewModels.Song;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicApp.Services
{
    public class SongService : ISongService
    {
        private MusicAppDbContext context;
        public SongService(MusicAppDbContext context)
        {
            this.context = context;
        }
        public int CreateSong(string name, string description, string link, string category)
        {
            var categoryObj = this.context.Categories.FirstOrDefault(x => x.Name == category);
            var song = new Song()
            {
                Name = name,
                Description = description,
                Link = link,
                CategoryID = categoryObj.Id,
                Views = 1
            };
            this.context.Songs.Add(song);
            categoryObj.Songs.Add(song);
            this.context.SaveChanges();

            return song.Id;
        }

        public IndexSongViewModel IndexSong()
        {
            var songs = context.Songs.Where(x => x.DeletedOn == null).Select(s => new ShowSongViewModel()
            {
                Id = s.Id,
                Name = s.Name,
                Description = s.Description,
                Link = s.Link,
                CategoryName = s.Category.Name
            });

            var songsModel = new IndexSongViewModel() { Songs = songs };
            return songsModel;
        }
    }
}
