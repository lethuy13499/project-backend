using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class UserDetail
    {
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Position { get; set; }
        public string GroupName { get; set; }
        public UserDetail(string fullName, string username, string email, string pos, string group)
        {
            this.FullName = fullName;
            this.UserName = username;
            this.Email = email;
            this.Position = pos;
            this.GroupName = group;
        }
        public UserDetail() { }
    }
}