namespace TrainingZoneDrills.Server.Models
{
    public class DrillEquipment
    {
        // This model is used to create a many-to-many relationship between the Drill and Equipment models.
        // The DrillEquipment model has two properties: DrillId and EquipmentId.
        // These properties are used to create foreign keys for the Drill and Equipment models.
        public int DrillId { get; set; }
        public Drill Drill { get; set; }
        public int EquipmentId { get; set; }
        public Equipment Equipment { get; set; }
    }
}
