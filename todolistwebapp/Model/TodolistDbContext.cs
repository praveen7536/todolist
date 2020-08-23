using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace todolistwebapp.Model
{
    public class TodolistDbContext:DbContext
    {
        public TodolistDbContext(DbContextOptions<TodolistDbContext> options):base(options)
        {

        }
        public DbSet<Lists> lists { get; set; }
    }
}
