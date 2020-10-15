using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace University
{
    public partial class Post
    {
        private long _id;
        private string _title;
        private float _salary;

        public long Id
        {
            get => _id;
            set => _id = value;
        }

        public string Title
        {
            get => _title;
            set => _title = value;
        }

        public float Salary
        {
            get => _salary;
            set => _salary = value;
        }
        public Post(long id,string title, float salary)
        {
            Id = id;
            Title = title;
            Salary = salary;
        }

        public Post():this(0,"Title",0)
        { }

        public override string ToString() 
        {
            StringBuilder res = new StringBuilder();
            res.Append("id: "+Id+" "+Title+" "+Salary);
            return res.ToString();
        }
    }
}
