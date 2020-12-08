using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebUniversity.Models;

namespace WebUniversity.Services
{
    public interface ITeacherStudyJointService
    {
        Task<List<TeacherStudyJoint>> GetTeacherStudyJoints();
        Task<bool> CreateTeacherStudyJoint(TeacherStudyJoint teacherStudyJoint);
        Task<bool> EditTeacherStudyJoint(long id, TeacherStudyJoint teacherStudyJoint);
        Task<TeacherStudyJoint> SingleTeacherStudyJoint(long id);
        Task<bool> DeleteTeacherStudyJoint(long id);
    }
}
