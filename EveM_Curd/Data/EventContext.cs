using EveM_Curd.Models;
using Microsoft.EntityFrameworkCore;

namespace EveM_Curd.Data
{
    public class EventContext : DbContext
    {
        public EventContext(DbContextOptions<EventContext> options) : base(options)
        {

        }
        public DbSet<EventCashFlow> EventCashFlows { get; set; }

        public DbSet<EventExpense> EventExpenses { get; set; }

        public DbSet<EventDetail> EventDetails { get; set; }

        public DbSet<VendorDetail> VendorDetails { get; set; }

        public DbSet<EventForm> EventForms { get; set; }


        /* protected override void OnModelCreating(ModelBuilder modelBuilder)
         {
             modelBuilder.Entity<EventDetail>()
                 .HasMany(e => e.EventIncomes)
                 .WithOne(i => i.EventDetail)
                 .HasForeignKey(i => i.Event_id);

             modelBuilder.Entity<EventDetail>()
                 .HasMany(e => e.EventExpenses)
                 .WithOne(exp => exp.EventDetail)
                 .HasForeignKey(exp => exp.Event_id);
         }*/

    }
}
