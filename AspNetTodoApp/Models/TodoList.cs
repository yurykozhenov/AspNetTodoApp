using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspNetTodoApp.Models
{
    public class TodoList
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public ICollection<Todo> Todos { get; set; }
    }
}