using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUniversity.Models;

namespace WebUniversity.Services
{
    public interface ITeacherService
    {
        Task<List<Teacher>> GetTeachers();
        Task<bool> CreateTeacher(Teacher teacher);
        Task<bool> EditTeacher(long id, Teacher teacher);
        Task<Teacher> SingleTeacher(long id);
        Task<bool> DeleteTeacher(long id);
    }
}
