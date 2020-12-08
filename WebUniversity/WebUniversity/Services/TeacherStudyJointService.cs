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
    public class TeacherStudyJointService : ITeacherStudyJointService
    {
        private readonly WebUniversityContext _context;

        public TeacherStudyJointService(WebUniversityContext context)
        {
            _context = context;
        }

        public async Task<List<TeacherStudyJoint>> GetTeacherStudyJoints()
        {
            var webUniversityContext = _context.TeacherStudyJoint.Include(t => t.Study).Include(t => t.Teacher);
            return await webUniversityContext.ToListAsync();
        }

        public async Task<TeacherStudyJoint> SingleTeacherStudyJoint(long id)
        {
            var teacherStudyJoint = await _context.TeacherStudyJoint
                .Include(t => t.Study)
                .Include(t => t.Teacher)
                .FirstOrDefaultAsync(m => m.Id == id);

            return teacherStudyJoint;
        }

        public async Task<bool> CreateTeacherStudyJoint(TeacherStudyJoint teacherStudyJoint)
        {
            _context.Add(teacherStudyJoint);
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

        public async Task<bool> EditTeacherStudyJoint(long id,TeacherStudyJoint teacherStudyJoint)
        {
            if (id != teacherStudyJoint.Id)
            {
                return false;
            }

            _context.Entry(teacherStudyJoint).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteTeacherStudyJoint(long id)
        {
            var teacherStudyJoint = await _context.TeacherStudyJoint.FindAsync(id);
            if (teacherStudyJoint == null)
            {
                return false;
            }

            _context.TeacherStudyJoint.Remove(teacherStudyJoint);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
