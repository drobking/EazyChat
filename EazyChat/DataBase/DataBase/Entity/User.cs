using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    class User
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
        public Byte[] Avatar { get; set; }
        public virtual ICollection<Contact> Contacts{ get; set; }
    }
    class UserContext : DbContext {
        public UserContext():base("DBConnection"){}
        public DbSet<User> Users { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Massage> Massages { get; set; }
    }
}
