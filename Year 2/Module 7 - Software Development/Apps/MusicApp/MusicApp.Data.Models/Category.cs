using System;
using System.Collections.Generic;
using System.Text;

namespace MusicApp.Data.Models
{
    public class Category
    {
        public Category()
        {
            this.CreatedOn = DateTime.UtcNow;
            this.Songs = new List<Song>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? DeletedOn { get; set; }
        public ICollection<Song> Songs { get; set; }
    }
}
