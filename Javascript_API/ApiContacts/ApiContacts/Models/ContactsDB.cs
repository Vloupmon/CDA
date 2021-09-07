using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ApiContacts.Models
{
  
    public class ContactsDB : DbContext
    {
       
        public ContactsDB(DbContextOptions<ContactsDB> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
    }
}
