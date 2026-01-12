using System;
using System.Collections.Generic;
using System.Text;

namespace Contact.Models
{
    public class Profile
    {
        public string nickname, password;
        public Contact[] contacts;

        public Profile(string nickname, string password)
        {
            this.nickname = nickname;
            this.password = password;
            contacts = new Contact[1];
        }
    }
}
