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
    public class StudyService : IStudyService
    {
        private readonly WebUniversityContext _context;

        public StudyService(WebUniversityContext context)
        {
            _context = context;
        }

        public async Task<List<Study>> GetStudies()
        {
            return await _context.Study.ToListAsync();
        }

        public async Task<Study> SingleStudy(long id)
        {
            return await _context.Study.FindAsync(id);

        }

        public async Task<bool> CreateStudy(Study study)
        {
            _context.Add(study);
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

        public async Task<bool> EditStudy(long id, Study study)
        {

            if (id != study.Id)
            {
                return false;
            }

            _context.Entry(study).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteStudy(long id)
        {
            var study = await _context.Study.FindAsync(id);
            if (study == null)
            {
                return false;
            }

            _context.Study.Remove(study);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
