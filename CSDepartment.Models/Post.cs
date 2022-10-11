using System;
using System.Collections.Generic;
using System.Text;

namespace CSDepartment.Models
{
    public class Post
    {
        public string PostId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public Media Media { get; set; }
    }
}
