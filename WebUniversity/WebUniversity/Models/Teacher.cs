using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebUniversity.Models
{
    public partial class Teacher
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
        public Teacher(long id, string fullName, string phone, string workAddress, long postId, string homeAddress, string characteristic)
        {
            Id = id;
            FullName = fullName;
            Phone = phone;
            WorkAddress = workAddress;
            PostId = postId;
            HomeAddress = homeAddress;
            Characteristic = characteristic;
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

        public virtual Post Post { get; set; }
    }
}
