using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using KhumaloCraft_.Models;

namespace KhumaloCraft_.Data
{
    public class KhumaloCraft_Context : DbContext
    {
        public KhumaloCraft_Context (DbContextOptions<KhumaloCraft_Context> options)
            : base(options)
        {
        }

        public DbSet<KhumaloCraft_.Models.About> About { get; set; } = default!;
        public DbSet<KhumaloCraft_.Models.Contact> Contact { get; set; } = default!;
        public DbSet<KhumaloCraft_.Models.Work> Work { get; set; } = default!;
    }
}
