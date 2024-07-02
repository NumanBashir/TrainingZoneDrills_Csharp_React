namespace TrainingZoneDrills.Server.Models
{
    public class Category
    {
        // This model is used to create a many-to-many relationship between the Drill and Category models.

        public int Id { get; set; }
        public string Name { get; set; }
        public List<DrillCategory> DrillCategories { get; set; }
    }
}
