using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarBlog.Data;
using BarBlog.Models;

namespace BarBlog.BLL
{
    public class AdminManager
    {
        private static IPostRepository _postRepo;

        public AdminManager()
        {
            _postRepo = new Factory().PostRepository();
        }

        public void AddPost(Post post)
        {
            if (GetAllPosts().Count != 0)
            {
                post.PostID = GetAllPosts().LastOrDefault().PostID + 1;
            }
            else
            {
                post.PostID = 1;
            }
            post.PostDate = DateTime.Now;

            _postRepo.AddPost(post);
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
