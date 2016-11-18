using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarBlog.Data;
using BarBlog.Models;

namespace BarBlog.BLL
{
    public class PublicManager
    {
        private static IPostRepository _postRepo;

        public PublicManager()
        {
            _postRepo = new Factory().PostRepository();
        }

        public List<Post> GetAllPosts()
        {
            return _postRepo.GetAllPosts();
        }

        public Post GetPostByID(int id)
        {
            return GetAllPosts().FirstOrDefault(p => p.PostID == id);
          
        }

    }
}
