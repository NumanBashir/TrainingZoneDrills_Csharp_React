namespace TrainingZoneDrills.Server.Models
{
    public class Equipment
    {
        // This model is used to create a many-to-many relationship between the Drill and Equipment models.
        public int Id { get; set; }
        public string Name { get; set; }
        public List<DrillEquipment> DrillEquipments { get; set; }
    }
}
