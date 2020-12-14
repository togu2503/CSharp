using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace WebUniversity
{
    public partial class TeacherStudyJoint
    {
        private long _id;
        private long _teacherId;
        private long _studyId;
        private long _hours;

        public long Id 
        { 
            get => _id;
            set => _id = value;
        }
        public long TeacherId 
        { 
            get => _teacherId;
            set => _teacherId = value;
        }
        public long StudyId 
        { 
            get => _studyId;
            set => _studyId = value;
        }
        public long Hours 
        {
            get => _hours; 
            set => _hours = value; 
        }
        public TeacherStudyJoint(long id, long teacherId, long studyId, long hours)
        {
            Id = id;
            TeacherId = teacherId;
            StudyId = studyId;
            Hours = hours;
        }

        public TeacherStudyJoint():this(0,0,0,0)
        {}

    }
}
