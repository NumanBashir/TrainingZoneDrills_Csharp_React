using Microsoft.EntityFrameworkCore;
using TrainingZoneDrills.Server.Models;

namespace TrainingZoneDrills.Server.Context
{
    public class TrainingZoneContext : DbContext
    {
        public DbSet<Drill> Drills { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<DrillCategory> DrillCategories { get; set; }
        public DbSet<DrillEquipment> DrillEquipments { get; set; }

        public TrainingZoneContext(DbContextOptions<TrainingZoneContext> options)
            : base(options)
        {
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Below we are defining the many-to-many relationships between the Drill, Category, and Equipment models.
            modelBuilder.Entity<DrillCategory>()
                .HasKey(dc => new { dc.DrillId, dc.CategoryId });

            modelBuilder.Entity<DrillEquipment>()
                .HasKey(de => new { de.DrillId, de.EquipmentId });

            // Below we are defining the relationship between the Drill and DrillCategory models.
            // We are saying that a Drill can have many DrillCategories.
            // We are also saying that the DrillId property in the DrillCategory model is a foreign key that references the Id property in the Drill model.
            // This is a one-to-many relationship between the Drill and DrillCategory models.
            modelBuilder.Entity<DrillCategory>()
                .HasOne(dc => dc.Drill)
                .WithMany(d => d.DrillCategories)
                .HasForeignKey(dc => dc.DrillId);

            // Below we are defining the relationship between the Category and DrillCategory models.
            // We are saying that a Category can have many DrillCategories.
            // We are also saying that the CategoryId property in the DrillCategory model is a foreign key that references the Id property in the Category model.
            modelBuilder.Entity<DrillCategory>()
            .HasOne(dc => dc.Category)
            .WithMany(c => c.DrillCategories)
            .HasForeignKey(dc => dc.CategoryId);

            // Below we are defining the relationship between the Drill and DrillEquipment models.
            // We are saying that a Drill can have many DrillEquipments.
            modelBuilder.Entity<DrillEquipment>()
                .HasOne(de => de.Drill)
                .WithMany(d => d.DrillEquipments)
                .HasForeignKey(de => de.DrillId);

            // Below we are defining the relationship between the Equipment and DrillEquipment models.
            // We are saying that an Equipment can have many DrillEquipments.
            modelBuilder.Entity<DrillEquipment>()
                .HasOne(de => de.Equipment)
                .WithMany(e => e.DrillEquipments)
                .HasForeignKey(de => de.EquipmentId);
        }

    }
}
