using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarBlog.Models;

namespace BarBlog.Data
{
 public interface IPostRepository
    {
        List<Post> GetAllPosts();
        void AddPost(Post post);
        void EditPost(Post post);
        void DeleteDVD(int id);
        
    }
}
