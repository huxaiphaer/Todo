using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Todo.Models;

namespace Todo.DBContext
{
    public class TodoDBContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public TodoDBContext(DbContextOptions<TodoDBContext> options) : base(options)
        {
        }

        public DbSet<TodoItem> Todos { get; set; }
    }
}
