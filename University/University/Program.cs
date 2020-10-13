using System;
using System.Data;
using System.Data.SqlClient;


namespace University
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=university;Integrated Security=True";

            string SqlExpAmountOfTeachers = "SELECT COUNT(id) FROM teacher";
            string SqlExpAmountOfPosts = "SELECT COUNT(id) FROM post";
            string SqlExpAmountOfSubjects = "SELECT COUNT(id) FROM study";
            string SqlExpression1 = "SELECT teacher.* " +
                "FROM teacher INNER JOIN(" +
                "SELECT teacher.id " +
                "FROM teacher INNER JOIN teacher_study_joint ON teacher.id = teacher_study_joint.teacher_id " +
                "GROUP BY teacher.id " +
                "HAVING COUNT(study_id) >= 2 ) AS temp ON teacher.id=temp.id";
            string SqlExpression2 = "SELECT teacher.* FROM teacher INNER JOIN post ON teacher.post_id = post.id WHERE title = 'Доцент'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command1 = new SqlCommand(SqlExpAmountOfTeachers, connection);
                var countTeachers = command1.ExecuteScalar();
                Console.WriteLine("Amount of students: {0}", countTeachers);

                SqlCommand command2 = new SqlCommand(SqlExpAmountOfPosts, connection);
                var countPosts = command2.ExecuteScalar();
                Console.WriteLine("Amount of teachers: {0}", countPosts);

                SqlCommand command3 = new SqlCommand(SqlExpAmountOfSubjects, connection);
                var countSubjects = command3.ExecuteScalar();
                Console.WriteLine("Amount of subjects: {0}", countSubjects);

                SqlCommand command4 = new SqlCommand(SqlExpression1, connection);
                SqlDataReader reader = command4.ExecuteReader();
                Console.WriteLine();
                Console.WriteLine("Teachers those have 2 or more subjects");
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Teacher teacher = new Teacher(reader);
                        Console.WriteLine(teacher.ToShortString());
                    }
                }
                reader.Close();

                SqlCommand command5 = new SqlCommand(SqlExpression2, connection);
                reader = command5.ExecuteReader();
                Console.WriteLine();
                Console.WriteLine("Teachers those have 'Доцент' title");
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Teacher teacher = new Teacher(reader);
                        Console.WriteLine(teacher.ToShortString());
                    }
                }
                reader.Close();

            }
        }
    }
}
