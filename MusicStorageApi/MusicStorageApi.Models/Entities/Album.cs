using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;
using System.Text;

namespace MusicStorageApi.Models.Entities
{
    public class Album
    {
        public Guid AlbumId { get; set; }
        public string Title { get; set; }
        public string ReleaseYear { get; set; }
        public string RecordLabel { get; set; }
        public string Genre { get; set; }
        public Guid AuthorId { get; set; }
        public Author Author { get; set; }
        public List<Song> Songs { get; set; }
    }
}
