using Microsoft.EntityFrameworkCore;
using Model.Model.PhanQuyen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Model
{
    public class banHangContext : DbContext
    {
        public banHangContext(DbContextOptions options): base(options)
        {
                
        }
        DbSet<User> Users { get; set; }
    }
}
