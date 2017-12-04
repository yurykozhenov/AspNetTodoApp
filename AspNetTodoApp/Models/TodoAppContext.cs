using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AspNetTodoApp.Models
{
    public class TodoAppContext: DbContext
    {
        public DbSet<TodoList> TodoLists { get; set; }
        public DbSet<Todo> Todos { get; set; }
        public DbSet<User> Users { get; set; }
    }

    public class TodoAppDbInitializer : DropCreateDatabaseAlways<TodoAppContext>
    {
        protected override void Seed(TodoAppContext db)
        {
            var u1 = new User { Name = "Kozhenov Yury" };
            var u2 = new User { Name = "John Doe" };

            db.Users.Add(u1);
            db.Users.Add(u2);

            var tl1 = new TodoList
            {
                Name = "Best Todo List",
                User = u1
            };

            db.TodoLists.Add(tl1);

            var t1 = new Todo
            {
                Title = "Buy groceries",
                Description = "- Bread \n - Milk \n - Eggs",
                IsComplete = true,
                TodoList = tl1
            };

            var t2 = new Todo
            {
                Title = "Clean house",
                Description = "Better do this today",
                IsComplete = true,
                TodoList = tl1
            };

            var t3 = new Todo
            {
                Title = "Feed cat",
                Description = "He is hungry",
                IsComplete = true,
                TodoList = tl1
            };

            db.Todos.Add(t1);
            db.Todos.Add(t2);
            db.Todos.Add(t3);

            base.Seed(db);
        }
    }
}