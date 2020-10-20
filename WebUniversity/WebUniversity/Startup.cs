using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.EntityFrameworkCore.Metadata;


namespace WebUniversity
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseStaticFiles();

            app.Map("", Start);
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

        }

        public void Start(IApplicationBuilder app)
        {
            app.Run(
                async context =>
                {
                    var builder = new ConfigurationBuilder();
                    builder.SetBasePath(Directory.GetCurrentDirectory());
                    builder.AddJsonFile("appsettings.json");
                    var config = builder.Build();
                    string connectionString = config.GetConnectionString("DefaultConnection");

                    var optionsBuilder = new DbContextOptionsBuilder<WebUniversityContext>();
                    var options = optionsBuilder
                        .UseSqlServer(connectionString)
                        .Options;
                    using (WebUniversityContext db = new WebUniversityContext(options))
                    {
                        context.Response.ContentType = "text/html";
                        await context.Response.WriteAsync("<img src=\"/logo.jpg\" class=\"img\" alt=\"Organisation logo\" />");
                        var teachers = from teacher in db.Teacher.Include(p => p.Post)
                                       select teacher;

                        await context.Response.WriteAsync("<h1>Teachers, their posts and salary</h1>");
                        foreach (var teacher in teachers.ToList())
                        {
                            await context.Response.WriteAsync($"{Encoding.UTF8.GetString(Encoding.ASCII.GetBytes(teacher.FullName))} {teacher.Post.Title} {teacher.Post.Salary} <br>");
                        }
                        var query = from joint in db.TeacherStudyJoint
                                    join teacher in db.Teacher on joint.TeacherId equals teacher.Id
                                    join study in db.Study on joint.StudyId equals study.Id
                                    group teacher by new
                                    {
                                        teacher.Id,
                                        teacher.FullName
                                    } into grouped
                                    where grouped.Count() > 1
                                    select new
                                    {
                                        Id = grouped.Key.Id,
                                        FullName = grouped.Key.FullName,
                                        Count = grouped.Count()
                                    };
                        await context.Response.WriteAsync("<h1>Teachers that have more than 1 subject</h1>");
                        foreach (var teacher in query.ToList())
                        {
                            await context.Response.WriteAsync($"{teacher.FullName} {teacher.Count} studies:<br>");
                            var studies = from joint in db.TeacherStudyJoint
                                          join study in db.Study on joint.StudyId equals study.Id
                                          where joint.TeacherId == teacher.Id
                                          select study;
                            foreach (var study in studies.ToList())
                            {
                                await context.Response.WriteAsync($"{study.Title}<br>");
                            }


                        }
                    }
                });

        }
    }
}