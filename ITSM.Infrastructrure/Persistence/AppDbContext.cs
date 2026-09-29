using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ITSM.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ITSM.Infrastructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories=> Set<Category>();

        public DbSet<Ticket> Tickets => Set<Ticket>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Ticket>()
                .HasOne(ticket => ticket.Category)
                .WithMany(category => category.Tickets)
                .HasForeignKey(ticket => ticket.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);
        }

    }
}
