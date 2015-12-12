using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Fakebook.Entities;

namespace Fakebook.Models
{
    public class HomeViewModel
    {
        public List<Comment> commentList { get; set; }
        public Comment newComment { get; set; }
        public String ownerImage { get; set; }

        public HomeViewModel()
        {
            commentList = new List<Comment>();
        }
    }
}