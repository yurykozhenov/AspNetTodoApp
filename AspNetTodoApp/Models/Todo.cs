using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AspNetTodoApp.Models
{
    public class Todo
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [MaxLength(2500)]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public bool IsComplete { get; set; }

        public int TodoListId { get; set; }
        public TodoList TodoList { get; set; }
    }
}