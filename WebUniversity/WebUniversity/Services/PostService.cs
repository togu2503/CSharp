using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebUniversity.Models;
using WebUniversity.DAL;

namespace WebUniversity.Services
{
    public class PostService : IPostService
    {
        private readonly WebUniversityContext _context;

        public PostService(WebUniversityContext context)
        {
            _context = context;
        }

        // GET: Posts
        public async Task<List<Post>> GetPosts()
        {
            return await _context.Post.ToListAsync();
        }

        // GET: Posts/Details/5
        public async Task<Post> SinglePost(long id)
        {
            return await _context.Post.FindAsync(id);
        }

        // GET: Posts/Create
        public async Task<bool> CreatePost(Post post)
        {
            _context.Add(post);
            try
            {
                await _context.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateException)
            {
                return false;
            }
        }

        // GET: Posts/Edit/5
        public async Task<bool> EditPost(long id, Post post)
        {
            if (id != post.Id)
            {
                return false;
            }

            _context.Entry(post).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return true;
        }

        // GET: Posts/Delete/5
        public async Task<bool> DeletePost(long id)
        {
            var post = await _context.Post.FindAsync(id);
            if (post == null)
            {
                return false;
            }

            _context.Post.Remove(post);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
