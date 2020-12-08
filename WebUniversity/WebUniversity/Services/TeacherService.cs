using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebUniversity.DAL;
using WebUniversity.Models;

namespace WebUniversity.Services
{
    public class TeacherService : ITeacherService
    {
        private readonly WebUniversityContext _context;

        public TeacherService(WebUniversityContext context)
        {
            _context = context;
        }

        // GET: Teachers
        public async Task<List<Teacher>> GetTeachers()
        {
            var webUniversityContext = _context.Teacher.Include(t => t.Post);
            return await webUniversityContext.ToListAsync();
        }

        public async Task<Teacher> SingleTeacher(long id)
        {
            var teacher = await _context.Teacher
                .Include(t => t.Post)
                .FirstOrDefaultAsync(m => m.Id == id);
            return teacher;
        }

        public async Task<bool> CreateTeacher(Teacher teacher)
        {
            _context.Add(teacher);
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

        public async Task<bool> EditTeacher(long id, Teacher teacher)
        {
            if (id != teacher.Id)
            {
                return false;
            }

            _context.Entry(teacher).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteTeacher(long id)
        {
            var teacher = await _context.Post.FindAsync(id);
            if (teacher == null)
            {
                return false;
            }

            _context.Post.Remove(teacher);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
