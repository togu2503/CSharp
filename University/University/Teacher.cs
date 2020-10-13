using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace lab1
{
    class Teacher
    {
        private long _id;
        private string _fullName;
        private string _phone;
        private string _workAddress;
        private long _postId;
        private string _homeAddress;
        private string _characteristic;
        public long Id
        {
            get => _id;
            set => _id = value;
        }
        public string FullName
        {
            get => _fullName;
            set => _fullName = value;
        }
        public string Phone
        {
            get => _phone;
            set => _phone = value;
        }
        public string WorkAddress
        {
            get => _workAddress;
            set => _workAddress = value;
        }
        public long PostId
        {
            get => _postId;
            set => _postId = value;
        }
        public string HomeAddress
        {
            get => _homeAddress;
            set => _homeAddress = value;
        }
        public string Characteristic
        {
            get => _characteristic;
            set => _characteristic = value;
        }
        public Teacher(int id, string fullName, string phone, string workAddress, int postId, string homeAddress, string characteristic)
        {
            Id = id;
            FullName = fullName;
            Phone = phone;
            WorkAddress = workAddress;
            PostId = postId;
            HomeAddress = homeAddress;
            Characteristic = characteristic;
        }

        public Teacher(SqlDataReader reader)
        {
            Id = reader.GetInt64(0);
            FullName = reader.GetString(1);
            Phone = reader.GetString(2);
            WorkAddress = reader.GetString(3);
            PostId = reader.GetInt64(4);
            HomeAddress = reader.GetString(5);
            Characteristic = reader.GetString(6);
        }
        public Teacher() : this(0, "Empty Full Name", "+380(12)3456789", "work adress", 0, "home address", "characteristic")
        { }

        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            res.Append("id: " + Id+" ");
            res.Append(FullName + " ");
            res.Append(Phone + " ");
            res.Append(WorkAddress + " ");
            res.Append("post id: " + PostId + " ");
            res.Append(HomeAddress + " ");
            res.Append(Characteristic);
            return res.ToString();
        }

        public string ToShortString()
        {
            StringBuilder res = new StringBuilder();
            res.Append(FullName);
            return res.ToString();
        }
    }
}
