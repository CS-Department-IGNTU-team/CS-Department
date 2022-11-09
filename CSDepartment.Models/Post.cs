using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CSDepartment.Models
{
    public class Post
    {
        public string Title { get; set; }

        public DateTime Timestamp { get; set; }

        public string Description { get; set; }

        public ICollection<Media> Media { get; set; }

    }
}
