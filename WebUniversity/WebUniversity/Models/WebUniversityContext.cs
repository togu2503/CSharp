using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebUniversity;

namespace WebUniversity.Models
{
    public class WebUniversityContext : DbContext
    {
        public WebUniversityContext (DbContextOptions<WebUniversityContext> options)
            : base(options)
        {
        }

        public DbSet<WebUniversity.Post> Post { get; set; }

        public DbSet<WebUniversity.Study> Study { get; set; }

        public DbSet<WebUniversity.Teacher> Teacher { get; set; }

        public DbSet<WebUniversity.TeacherStudyJoint> TeacherStudyJoint { get; set; }
    }
}
