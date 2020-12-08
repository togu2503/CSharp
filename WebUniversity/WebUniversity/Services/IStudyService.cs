using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUniversity.Models;

namespace WebUniversity.Services
{
    public interface IStudyService
    {
        Task<List<Study>> GetStudies();
        Task<bool> CreateStudy(Study study);
        Task<bool> EditStudy(long id, Study study);
        Task<Study> SingleStudy(long id);
        Task<bool> DeleteStudy(long id);
    }
}
