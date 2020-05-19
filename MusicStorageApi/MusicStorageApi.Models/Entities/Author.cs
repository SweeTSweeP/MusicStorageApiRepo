using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MusicStorageApi.Models.Entities
{
    public class Author
    {
        [Key] public Guid AuthorId { get; set; }
        public string AuthorName { get; set; }
        public List<Album> Albums { get; set; }
        public List<Song> Songs { get; set; }
    }
}
