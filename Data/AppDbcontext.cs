﻿using Microsoft.EntityFrameworkCore;
using MyFirstProject.Models.Entities;

namespace MyFirstProject.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
