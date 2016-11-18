using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarBlog.Models;

namespace BarBlog.Data
{
  class PostMockRepository : IPostRepository
  {
      private static List<Post> _posts;

      public PostMockRepository()
      {
          if (_posts == null)
          {
              _posts = new List<Post>()
              {
                  new Post()
                  {
                      PostID = 1,
                      PostTitle = "Why I am terrible",
                      Author =
                      {
                          AuthorName = "Douglas Wachtel",
                          AuthorID = 1
                      },
                      IsApproved = true,
                      PostBody = "Somebody kill me.",
                      PostDate = DateTime.Now,


                  }
              };
          }
      }
        public List<Post> GetAllPosts()
        {
            return _posts;
        }

        public void AddPost(Post post)
        {
            _posts.Add(post);
        }

        public void EditPost(Post post)
        {
            var selectedPost = _posts.FirstOrDefault(p => p.PostID == post.PostID);
            selectedPost.PostID = post.PostID;
            selectedPost.Author = post.Author;
            selectedPost.PostTitle = post.PostTitle;
            //add more later, I'm tired
        }

        public void DeleteDVD(int id)
        {
            _posts.RemoveAll(p => p.PostID == id);
        }
    }
}
