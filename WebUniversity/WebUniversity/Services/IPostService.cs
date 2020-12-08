using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUniversity.Models;

namespace WebUniversity.Services
{
    public interface IPostService
    {
        Task<List<Post>> GetPosts();
        Task<bool> CreatePost(Post post);
        Task<bool> EditPost(long id, Post post);
        Task<Post> SinglePost(long id);
        Task<bool> DeletePost(long id);
    }
}
