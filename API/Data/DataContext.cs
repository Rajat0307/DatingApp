using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext  //session with database
    {
        public DataContext(DbContextOptions options) : base(options)    // constructor
        {
                 
        } // to use this configuration for other parts of application add to starter class (configure service method)

        public DbSet<AppUser> Users { get; set; }   // it takes type as class for which we want to create database 
    }
}