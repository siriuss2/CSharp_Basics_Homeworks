using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.HomeWork_Class._06_Task01.Models
{
    public class User
    {

        public User(int id , string username, string password)
        {
            Username = username;
            Password = password;
            Id = id;
        }
        public User(int id, string username, string password, string[] messages)
        {
            Id = id;
            Username = username;
            Password = password;
            Messages = messages;
        }
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string[] Messages { get; set; }

    }
}
