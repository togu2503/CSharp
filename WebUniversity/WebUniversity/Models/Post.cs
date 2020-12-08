using System;
using System.Collections.Generic;
using System.Text;

namespace WebUniversity.Models
{
    public partial class Post
    {
        private long _id;
        private string _title;
        private Double _salary;

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

        public Double Salary
        {
            get => _salary;
            set => _salary = value;
        }
        public Post() : this(0, "Empty Title", 0.0)
        { }
        public Post(long id,string title, Double salary)
        {
            Id = id;
            Title = title;
            Salary = salary;
        }

        public override string ToString() 
        {
            StringBuilder res = new StringBuilder();
            res.Append("id: "+Id+" "+Title+" "+Salary);
            return res.ToString();
        }
    }
}
