namespace TrainingZoneDrills.Server.Models
{
    public class DrillCategory
    {
        // Compare this snippet from TrainingZoneDrills.Server/Models/DrillCategory.cs:
        // This model is used to create a many-to-many relationship between the Drill and Category models.
        // The DrillCategory model has two properties: DrillId and CategoryId.
        // These properties are used to create foreign keys for the Drill and Category models.
        public int DrillId { get; set; }
        public Drill Drill { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
