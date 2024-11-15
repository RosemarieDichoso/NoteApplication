﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NoteApplication.Models;

namespace NoteApplication.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<NoteItem> NoteItems { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.
                UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=NotesAppDB;Trusted_Connection=True;");
        }
    }
}
