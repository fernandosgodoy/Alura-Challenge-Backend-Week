using System;
using System.ComponentModel.DataAnnotations;

namespace AluraFlix.Domain
{
    public class Video
    {

        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }

    }
}
