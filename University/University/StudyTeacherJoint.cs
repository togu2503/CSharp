using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace lab1
{
    class StudyTeacherJoint
    {
        private long _id;
        private long _teacherId;
        private long _studyId;
        private int _hours;

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
        public int Hours 
        {
            get => _hours; 
            set => _hours = value; 
        }
        public StudyTeacherJoint(int id, int teacherId, int studyId, int hours)
        {
            Id = id;
            TeacherId = teacherId;
            StudyId = studyId;
            Hours = hours;
        }

        public StudyTeacherJoint(SqlDataReader reader)
        {
            Id = reader.GetInt64(0);
            TeacherId = reader.GetInt64(1);
            StudyId = reader.GetInt64(2);
            Hours = reader.GetInt32(3);
        }

        public StudyTeacherJoint():this(0,0,0,0)
        {}
    }
}
