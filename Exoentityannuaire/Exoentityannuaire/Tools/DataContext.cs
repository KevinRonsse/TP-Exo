﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exoentityannuaire
{
    public class DataContext : DbContext
    {
        public DbSet<Contact> Contacts{get; set;}
        public DataContext() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source(LocalDb)\CoursDotNet; integrated Security=true");
        }

    }
}