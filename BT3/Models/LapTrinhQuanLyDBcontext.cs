using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BT3.Models
{
    public partial class LapTrinhQuanLyDBcontext : DbContext
    {
        public LapTrinhQuanLyDBcontext()
            : base("name=LapTrinhQuanLyDBcontext")
        {
        }

        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        }
    }

       


