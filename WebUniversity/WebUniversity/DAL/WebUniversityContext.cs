using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebUniversity.Models;

namespace WebUniversity.DAL
{
    public class WebUniversityContext : DbContext
    {
        public WebUniversityContext (DbContextOptions<WebUniversityContext> options)
            : base(options)
        {
        }

        public DbSet<Post> Post { get; set; }

        public DbSet<Study> Study { get; set; }

        public DbSet<Teacher> Teacher { get; set; }

        public DbSet<TeacherStudyJoint> TeacherStudyJoint { get; set; }
    }
}
