using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspNetTodoApp.Models
{
    public class TodoList
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}