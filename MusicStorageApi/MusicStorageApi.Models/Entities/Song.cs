using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;
using System.Text;

namespace MusicStorageApi.Models.Entities
{
    public class Song
    {
        public Guid SongId { get; set; }
        public string title { get; set; }
        public string ReleaseYear { get; set; }
        public string RecordLabel { get; set; }
        public Guid? AlbumId { get; set; }
        public Album Album { get; set; }
        public Guid? AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
