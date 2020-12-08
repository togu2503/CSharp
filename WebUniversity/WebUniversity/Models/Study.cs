﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebUniversity.Models
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
            Title = Title;
        }
        public Study() : this(0, "Empty Title")
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
