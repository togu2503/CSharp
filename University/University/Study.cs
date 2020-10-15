using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace University
{
    public partial class Study
    {
        private long _id;
        private string _title;

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

        Study(long id, string name)
        {
            Id = id;
            Title = name;
        }

        Study():this(0,"title of study")
        { }

        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            res.Append("id: " + Id);
            res.Append(Title);
            return res.ToString();
        }

    }
}
