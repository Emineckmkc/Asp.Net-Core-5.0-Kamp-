﻿using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesslayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-7S388FV\\SQLEXPRESS; database=CoreBlogDb; integrated security=true;");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog>  Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment>  Comments { get; set; }
        public DbSet<Contact>  Contacts { get; set; }
        public DbSet<Writer>   Writers { get; set; }

    }
}
