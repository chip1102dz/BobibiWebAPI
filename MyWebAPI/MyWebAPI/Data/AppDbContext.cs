﻿using Microsoft.EntityFrameworkCore;
using MyWebAPI.Models;

namespace MyWebAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Category> Category { get; set; }
    }
}
