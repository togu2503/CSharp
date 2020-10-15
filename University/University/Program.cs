using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Metadata;


namespace University
{
    class Program
    {
        static void Main(string[] args)
        {
            using (UniversityContext db = new UniversityContext())
            {
                var teachers = from teacher in db.Teacher.Include(p =>p.Post)
                               select teacher;

                Console.WriteLine("Teachers, their posts and salary");
                foreach (var teacher in teachers.ToList())
                    Console.WriteLine($"{teacher.FullName} {teacher.Post.Title} {teacher.Post.Salary}");
                Console.WriteLine();

                var query = from joint in db.TeacherStudyJoint
                                     join teacher in db.Teacher on joint.TeacherId equals teacher.Id
                                     join study in db.Study on joint.StudyId equals study.Id
                                     group teacher by new { teacher.Id, teacher.FullName } into grouped
                                     where grouped.Count() > 1
                                     select new { Id = grouped.Key.Id, FullName = grouped.Key.FullName , Count = grouped.Count()};
                Console.WriteLine("Teachers that have more than 1 subject");
                foreach (var teacher in query.ToList())
                {
                    Console.WriteLine($"{teacher.FullName} {teacher.Count} studies:");
                    var studies = from joint in db.TeacherStudyJoint
                                  join study in db.Study on joint.StudyId equals study.Id
                                  where joint.TeacherId == teacher.Id
                                  select study;
                    foreach (var study in studies.ToList())
                    {
                        Console.WriteLine($"{study.Title}");
                    }

                    Console.WriteLine();
                }
            }


        }
    }
}
