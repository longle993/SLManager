using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLBH.DTO
{
    public class Account
    {
        private string id;
        private string name;
        private DateTime birth;
        private string password;
        private string phone;

        public Account() { }
        public Account(string id, string name, DateTime birth, string password, string phone)
        {
            this.id = id;
            this.name = name;
            this.birth = birth;
            this.password = password;
            this.phone = phone;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public DateTime Birth { get => birth; set => birth = value; }
        public string Password { get => password; set => password = value; }
        public string Phone { get => phone; set => phone = value; }
    }
}
