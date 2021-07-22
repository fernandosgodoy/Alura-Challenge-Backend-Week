using AluraFlix.Domain.Base;
using System;
using System.ComponentModel.DataAnnotations;

namespace AluraFlix.Domain
{
    public class Video
        : EntityBase
    {

        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }

    }
}
