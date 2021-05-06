using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileUploadApp.Models
{
    public class FilesContext : DbContext
    {
        public DbSet<Person> People { get; set; }
        public FilesContext(DbContextOptions<FilesContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
