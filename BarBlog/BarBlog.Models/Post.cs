using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarBlog.Models
{
   public class Post
    {
        public int PostID { get; set; }
        public string PostTitle { get; set; }
        public DateTime PostDate { get; set; }
        public string PostBody { get; set; }
        public List<Tag> PostTags { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public List<Category> PostCategories { get; set; }
        public bool IsApproved { get; set; }
        public Author Author { get; set; }
    }
}
